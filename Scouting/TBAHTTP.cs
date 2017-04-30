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

                        //go through each string and try to convert to a double. If successful, set column as double.
                        for (int i = 0; i < rankings[0].Length; i++)
                        {
                            double value;
                            DataColumn column = tableResponse.Columns.Add(rankings[0][i]);
                            if (double.TryParse(rankings[1][i], out value))
                            {
                                //If the first number happens to be a perfect round but others aren't, this will fail. This is faster however and should work in most cases.
                                if (value == (int)value)
                                {
                                    column.DataType = typeof(int);
                                }
                                else
                                {
                                    column.DataType = typeof(double);
                                }
                            }
                        }
                        for (int i = 1; i < rankings.Length; i++)
                        {
                            DataRow row = tableResponse.NewRow();
                            for (int j = 0; j < rankings[i].Length; j++)
                            {
                                if (tableResponse.Columns[j].DataType == typeof(double))
                                {
                                    row[j] = Math.Round(double.Parse(rankings[i][j]),2);
                                }
                                else if (tableResponse.Columns[j].DataType == typeof(int))
                                {
                                    row[j] = Convert.ToInt32(double.Parse(rankings[i][j]));
                                }
                                else //it's just a string
                                {
                                    Console.Write(rankings[i][j]);
                                    row[j] = rankings[i][j];
                                }
                            }
                            //row.ItemArray = rankings[i];
                            tableResponse.Rows.Add(row);
                        }
                        form.Rankings = tableResponse;
                        break;
                    }

                case RequestType.Matches:
                    {
                        DataTable viewMatchData = new DataTable();
                        response = await client.GetAsync("event/" + data + "/matches");
                        byteResponse = await response.Content.ReadAsByteArrayAsync();
                        string stringresponse = Encoding.UTF8.GetString(byteResponse, 0, byteResponse.Length);
                        List<Match> matches = null;
                        try
                        {
                            matches = JsonConvert.DeserializeObject<List<Match>>(stringresponse);
                        }
                        catch
                        {

                        }

                        viewMatchData.Columns.Add("Time", typeof(DateTime));
                        viewMatchData.Columns.Add("Stage", typeof(string));
                        viewMatchData.Columns.Add("Set", typeof(int));
                        viewMatchData.Columns.Add("Match No.", typeof(int));
                        for (int i = 1; i <= 3; i++)
                        {
                            viewMatchData.Columns.Add("Blue "+ i, typeof(int));
                        }
                        for (int i = 1; i <= 3; i++)
                        {
                            viewMatchData.Columns.Add("Red " + i, typeof(int));
                        }
                        viewMatchData.Columns.Add("Blue Score", typeof(int));
                        viewMatchData.Columns.Add("Red Score", typeof(int));
                        viewMatchData.Columns.Add("Videos", typeof(string));

                        foreach(Match match in matches)
                        {
                            DataRow row = viewMatchData.NewRow();
                            DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                            time = time.AddSeconds(match.time).ToLocalTime();
                            row["Time"] = time;
                            row["Stage"] = Match.CompToString(match.comp_level);
                            row["Set"] = match.set_number;
                            row["Match No."] = match.match_number;
                            for (int i = 1; i <= 3; i++)
                            {
                                //remove the start of the number "frc"
                                row["Blue " + i] = int.Parse(match.alliances.blue.teams[i-1].Remove(0, 3));
                            }
                            for (int i = 1; i <= 3; i++)
                            {
                                row["Red " + i] = int.Parse(match.alliances.red.teams[i-1].Remove(0,3));
                            }
                            row["Blue Score"] = match.alliances.blue.score;
                            row["Red Score"] = match.alliances.red.score;
                            row["Videos"] = match.videos;
                            viewMatchData.Rows.Add(row);
                        }

                        form.Matches = matches;
                        form.MatchesDataTable = viewMatchData;
                        break;
                    }
            }
        }
    }
}
