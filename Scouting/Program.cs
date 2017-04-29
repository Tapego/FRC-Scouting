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
            Application.Run(new Form1());
        }


        /*
        static async Task RunAsync()
        {

            response = await client.GetAsync("team/frc5663");
            
            HttpContent content = response.Content;
            System.IO.Stream stream = await content.ReadAsStreamAsync();
            byte[] stringContent = await content.ReadAsByteArrayAsync();
            Encoding encoding = Encoding.UTF8;
            string responseString = encoding.GetString(stringContent, 0, stringContent.Length);
            System.IO.BinaryReader br = new System.IO.BinaryReader(stream);
            Team GroundControl = JsonConvert.DeserializeObject<Team>(responseString);
            Console.Write(GroundControl.name);
            

        }*/

        /*
        static async Task<Product> GetProductAsync(string path)
        {
            Product product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsStringAsync();
            }
            return product;
        }
        */
    }
}
