using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetAvecEF.Models
{
    public class Produits : List<Produit>
    {
        private Repository Repo = new Repository();

        public Produits()
        {
            AddRange(Repo.GetProduits());

        }

        public Produits(int? cat)
        {
            AddRange(Repo.GetProduits(cat));
        }
        public Produits(string cat)
        {
            AddRange(Repo.GetProduits(cat));
        }
    }
    public class Produit
    {
        public string Nom;
    }
}