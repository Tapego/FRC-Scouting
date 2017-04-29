using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scouting
{
    //https://www.thebluealliance.com/api/v2/event/<event key>/awards
    public class Team
    {
        public string website { get; set; }
        public string name { get; set; }
        public string locality { get; set; }
        public int rookie_year { get; set; }
        public int team_number { get; set; }
        public string location { get; set; }
        public string key { get; set; }
        public string country_name { get; set; }
        public string nickname { get; set; }
    }

    public class Event
    {
        public string key { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }
        public string event_code { get; set; }
        public string event_type_string { get; set; }
        public int event_type { get; set; }
        public string event_district_string { get; set; }
        public string event_district { get; set; }
        public int year { get; set; }
        public int week { get; set; }
        public string location { get; set; }
        public string venue_address { get; set; }
        public string timezone { get; set; }
        public string website { get; set; }
        public bool official { get; set; }
        public List<Team> teams { get; set; }
        public List<Match> matches { get; set; }
        public string[] webcast { get; set; }
        public Alliance[] alliances { get; set; }
        public string district_points { get; set; }
        private DateTime timestamp = DateTime.Now;
        public DateTime Timestamp { get; }
    }

    public class Match
    {
        public enum Comp { qm, ef, qf, sf, f}
        public string key { get; set; }
        public Comp comp_level { get; set; }
        public int set_number { get; set; }
        public int match_number { get; set; }
        public Alliances alliances { get; set; }
        public teamScore score_breakdown { get; set; }
        public string event_key { get; set; }
        public List<Video> videos { get; set; }
        public string time_string { get; set; }
        public ulong time { get; set; } 
    }

    public class teamScore
    {
        public Dictionary<string, string> blue, red;
    }
    
    public class Video
    {
        public string type { get; set; }
        public string key { get; set; }
    }

    public class Alliances
    {
        public Alliance blue, red;
    }
    public class Alliance
    {
        public string[] surrogates { get; set; }
        public int score { get; set; }
        public string[] teams {get; set; }
    }

    public class EventRanking
    {
        public string[] rankings;
    }
}
