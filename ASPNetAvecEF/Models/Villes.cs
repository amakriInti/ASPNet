using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetAvecEF.Models
{
    public class Villes : List<Ville>
    {
        private Repository Repo = new Repository();

        public Villes()
        {
            AddRange(Repo.GetVilles());

        }
    }
    public class Ville
    {
        public string Nom;
    }
}