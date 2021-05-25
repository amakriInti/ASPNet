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
        internal IEnumerable<Produit> GetProduits()
        {
            return Context.Products
                .Select(p => new Produit { Nom = p.Name })
                .OrderBy(v => v.Nom);

        }
        internal IEnumerable<Produit> GetProduits(int? cat)
        {
            if (cat != null)
                return Context.Products
                    .Where(p => p.ProductSubcategory.ProductCategoryID == cat)
                    .Select(p => new Produit { Nom = p.Name })
                    .OrderBy(v => v.Nom);
            return Context.Products
                .Select(p => new Produit { Nom = p.Name })
                .OrderBy(v => v.Nom);
        }
        internal IEnumerable<Produit> GetProduits(string cat)
        {
            if (cat != null)
                return Context.Products
                .Where(p => p.ProductSubcategory.ProductCategory.Name == cat)
                .Select(p => new Produit { Nom = p.Name })
                .OrderBy(v => v.Nom);
            return Context.Products
            .Select(p => new Produit { Nom = p.Name })
            .OrderBy(v => v.Nom);
        }

    }
}