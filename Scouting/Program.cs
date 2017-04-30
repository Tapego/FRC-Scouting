using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
namespace Scouting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static HttpClient client = new HttpClient();
        [STAThread]
        static void Main()
        {
            client.BaseAddress = new Uri("https://www.thebluealliance.com/api/v2/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-TBA-App-Id", "luke:luke:0.1");
            //RunAsync().Wait();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Window());
        }

    }
}
