using ASPNetAvecEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetAvecEF
{
    public class Repository
    {
        private AdvContext Context = new AdvContext();
        internal IEnumerable<Personne> GetPersonnes()
        {
            return Context.People.Select(p => new Personne { Nom = p.LastName, Prenom = p.FirstName });
        }

        internal IEnumerable<Ville> GetVilles()
        {
            return Context.Addresses
                .Select(p => new Ville { Nom = p.City })
                .OrderBy(v => v.Nom);

        }
    }
}