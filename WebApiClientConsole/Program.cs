using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebApiClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choix");
            var choix = Console.ReadLine();

            WebClient WebClient1 = new WebClient { Encoding = Encoding.UTF8 };
            string url; byte[] octets; string s; 
            switch (choix)
            {
                case "1":
                    url = "http://localhost:65160/api/values/1";
                    octets = WebClient1.DownloadData(url);
                    s = Encoding.Default.GetString(octets);
                    Console.WriteLine(s);
                    break;
                case "2":
                    url = "http://localhost:65160/api/personne/values/Agen";
                    octets = WebClient1.DownloadData(url);
                    s = Encoding.Default.GetString(octets);
                    var ps = JsonConvert.DeserializeObject<List<Personne>>(s);
                    foreach(var p in ps) Console.WriteLine(p);
                    break;
            }



            Console.ReadLine();
        }
    }
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Ville { get; set; }
        public override string ToString()
        {
            return $"{Nom}:{Ville}";
        }
    }

}

