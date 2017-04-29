using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Data;

namespace Scouting
{
    public static class TBAHTTP
    {
        public enum RequestType { Event, EventRanking, Matches};
        public static async Task RequestTBA(HttpClient client,RequestType type, string data, EventView form)
        {
            byte[] byteResponse;
            HttpResponseMessage response = new HttpResponseMessage();
            switch (type)
            {
                case RequestType.Event:
                    {
                        response = await client.GetAsync("event/" + data);
                        byteResponse = await response.Content.ReadAsByteArrayAsync();
                        string stringResponse = Encoding.UTF8.GetString(byteResponse, 0, byteResponse.Length);
                        EventView frcEvent = JsonConvert.DeserializeObject<EventView>(stringResponse);
                        form.frcEvent = frcEvent;
                        break;
                    }
                case RequestType.EventRanking:
                    {
                        DataTable tableResponse = new DataTable();
                        response = await client.GetAsync("event/" + data + "/rankings");
                        byteResponse = await response.Content.ReadAsByteArrayAsync();
                        string stringResponse = Encoding.UTF8.GetString(byteResponse, 0, byteResponse.Length);

                        string[][] rankings = JsonConvert.DeserializeObject<string[][]>(stringResponse);
                        for (int i = 0; i < rankings[0].Length; i++)
                        {
                            tableResponse.Columns.Add(rankings[0][i]);
                        }
                        for (int i = 1; i < rankings.Length; i++)
                        {
                            DataRow row = tableResponse.NewRow();
                            row.ItemArray = rankings[i];
                            tableResponse.Rows.Add(row);
                        }
                        form.Rankings = tableResponse;
                        break;
                    }
                case RequestType.Matches:
                    {
                        DataTable tableResponse = new DataTable();
                        response = await client.GetAsync("event/" + data + "/matches");
                        byteResponse = await response.Content.ReadAsByteArrayAsync();
                        string stringresponse = Encoding.UTF8.GetString(byteResponse, 0, byteResponse.Length);
                        List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(stringresponse);
                        Type typeMatch = typeof(Match);
                        var properties = typeMatch.GetProperties();
                        foreach (var property in properties)
                        {
                            tableResponse.Columns.Add(property.Name);
                        }
                        foreach(Match match in matches)
                        {
                            var props = match.GetType().GetProperties();
                            DataRow row = tableResponse.NewRow();
                            for(int i = 0; i < props.Length; i++)
                            {
                                row.ItemArray[i] = match.GetType().GetProperty(props[i].Name);
                            }
                            tableResponse.Rows.Add(row);
                        }
                        form.Matches = tableResponse;
                        break;
                    }
            }
        }
    }
}
