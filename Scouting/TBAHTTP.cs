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
        public enum RequestType { Event, EventRanking};
        public static async Task RequestTBA(HttpClient client,RequestType type, string data, Form1 form)
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
                        Event frcEvent = JsonConvert.DeserializeObject<Event>(stringResponse);
                        form.frcEvent = frcEvent;
                        break;
                    }
                case RequestType.EventRanking:
                    {
                        DataTable tableResponse = new DataTable();
                        response = await client.GetAsync("event/" + data + "/rankings");
                        byteResponse = await response.Content.ReadAsByteArrayAsync();
                        string stringResponse = Encoding.UTF8.GetString(byteResponse, 0, byteResponse.Length);
                        Console.WriteLine(stringResponse);

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
            }
        }
    }
}
