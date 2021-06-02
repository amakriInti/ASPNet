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
            while (true)
            {
                Console.WriteLine("Choix");
                var choix = Console.ReadLine();

                WebClient WebClient1 = new WebClient { Encoding = Encoding.UTF8 };
                string url; byte[] octets; string s, nom, ville, id;
                switch (choix)
                {
                    case "1": // Get string
                        url = "http://localhost:65160/api/values/1";
                        octets = WebClient1.DownloadData(url);
                        s = Encoding.Default.GetString(octets);
                        Console.WriteLine(s);
                        break;
                    case "2": // Get Personnes
                        url = "http://localhost:65160/api/personne/values/Agen";
                        octets = WebClient1.DownloadData(url);
                        s = Encoding.Default.GetString(octets);
                        var ps = JsonConvert.DeserializeObject<List<Personne>>(s);
                        foreach (var p in ps) Console.WriteLine(p);
                        break;
                    case "3": // Insert Personne
                        Console.Write("Nom: ");
                        nom = Console.ReadLine();
                        Console.Write("Ville: ");
                        ville = Console.ReadLine();

                        url = $"http://localhost:65160/api/personne/values/?nom={nom}&ville={ville}";
                        octets = WebClient1.UploadData(url, "POST", new byte[] { });
                        s = Encoding.Default.GetString(octets);
                        Console.WriteLine("Insertion : {0}", s);
                        break;
                    case "4": // Update Personne
                        Console.Write("Id: ");
                        id = Console.ReadLine();
                        Console.Write("Nom: ");
                        nom = Console.ReadLine();
                        Console.Write("Ville: ");
                        ville = Console.ReadLine();

                        url = $"http://localhost:65160/api/personne/values/?id={id}&nom={nom}&ville={ville}";
                        octets = WebClient1.UploadData(url, "POST", new byte[] { });
                        s = Encoding.Default.GetString(octets);
                        if (s == null)
                            Console.WriteLine("Modif impossible");
                        else
                            Console.WriteLine("Modif : {0}", s);
                        break;
                    case "5": // Delete Personne
                        Console.Write("Id: ");
                        id = Console.ReadLine();

                        url = $"http://localhost:65160/api/personne/values/?id={id}";
                        octets = WebClient1.UploadData(url, "Post", new byte[] { });
                        s = Encoding.Default.GetString(octets);
                        if (s == null)
                            Console.WriteLine("suppression impossible");
                        else
                            Console.WriteLine("suppression : {0}", s);
                        break;
                }

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
            return $"{Id}. {Nom}:{Ville}";
        }
    }

}

