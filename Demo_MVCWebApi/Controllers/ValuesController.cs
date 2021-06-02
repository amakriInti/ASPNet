using Demo_MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace Demo_MVCWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Index()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int entier)
        {
            return "value int";
        }
        public string Get(string id)
        {
            return "value string";
        }
        public IEnumerable<Personne> GetPersonne(string ville)
        {
            var liste = (List<Personne>)HttpContext.Current.Application["Personne"];
            if (ville.ToUpper() == "TOUT") return liste;
            return liste.Where(p => ville == null || p.Ville == ville);
        }

        // Insertion
        public string Post(string nom, string ville)
        {
            var liste = (List<Personne>)System.Web.HttpContext.Current.Application["Personne"];

            var id = liste.Select(p => p.Id).Max() + 1;
            liste.Add(new Personne { Id = id, Nom = nom, Ville = ville });
            return "Ok";
        }
        // Modif
        public string Post(int id, string nom, string ville)
        {
            var liste = (List<Personne>)System.Web.HttpContext.Current.Application["Personne"];
            var p = liste.FirstOrDefault(x => x.Id == id);
            if (p == null) return null;
            p.Nom = nom;
            p.Ville = ville;
            return "Ok";
        }
        public string PostAutre(int id)
        {
            var liste = (List<Personne>)System.Web.HttpContext.Current.Application["Personne"];
            var p = liste.FirstOrDefault(x => x.Id == id);
            if (p == null) return null;
            liste.Remove(p);
            return "Ok";
        }
    }
}
