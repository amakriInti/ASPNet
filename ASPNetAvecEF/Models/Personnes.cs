using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetAvecEF.Models
{
    public class Personnes : List<Personne>
    {
        private Repository Repo = new Repository();
        public Personnes()
        {
            AddRange(Repo.GetPersonnes());
        }
    }
    public class Personne
    {
        public string Nom;
        public string Prenom;
    }
}