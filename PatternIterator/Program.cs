using System;
using System.Collections;
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
            var ps = new Personnes();
            ps.Add(p1);
            ps.Add(p2);
            ps.Remove(p1);

            // Personne à l'index 0
            var p0 = ps[0];

            // Liste
            foreach (var p in ps)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
    class Personnes : IEnumerable<Personne>
    {
        private List<Personne> ListeInterne = new List<Personne>();
        public void Add(Personne p)
        {
            ListeInterne.Add(p);
        }
        public IEnumerator<Personne> GetEnumerator()
        {
            return new PersonneEnumerator(ListeInterne);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PersonneEnumerator(ListeInterne);
        }

        internal void Remove(Personne p1)
        {
            ListeInterne.Remove(p1);
        }
        public int Count
        {
            get { return ListeInterne.Count; }
        }
        public void AddRange(List<Personne> ps)
        {
            ListeInterne.AddRange(ps);
        }
        public Personne this [int index]
        {
            get
            {
                return ListeInterne[index];
            }
        }
    }
    class PersonneEnumerator : IEnumerator<Personne>
    {
        private List<Personne> ListeInterne;
        private int Index = -1;
        public PersonneEnumerator(List<Personne> listeInterne)
        {
            ListeInterne = listeInterne;
        }

        public Personne Current => ListeInterne[Index];

        object IEnumerator.Current => ListeInterne[Index];

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            Index++;
            return Index < ListeInterne.Count;
        }

        public void Reset()
        {
            Index = -1;
        }
    }
    class Personne
    {
        public string Nom;
        public string Ville;
        public override string ToString()
        {
            return $"{Nom} : {Ville}";
        }
    }
}
