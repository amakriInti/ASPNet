using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Personne { Nom = "Gérard", Ville = "Grenoble" };
            var p2 = new Personne { Nom = "Héloïse", Ville = "Honfleur" };
            List<Personne> ps = new List<Personne> { p1, p2 };

            // Personne à l'index 0
            var p0 = ps[0];

            // Liste
            foreach(var p in ps)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
    class Personne
    {
        public string Nom;
        public string Ville;
    }
}
