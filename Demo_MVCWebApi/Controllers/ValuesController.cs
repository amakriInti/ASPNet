using Demo_MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
        public string Get(int id)
        {
            return "value";
        }
        public IEnumerable<Personne> Get(string ville)
        {
            var liste = new List<Personne> {
            new Personne{ Id=1, Nom="Alban", Ville="Agen"  },
            new Personne{ Id=2, Nom="Baltazar", Ville="Berne"  },
            new Personne{ Id=3, Nom="Carmen", Ville="Agen"  }
            };
            return liste.Where(p => ville == null || p.Ville == ville);
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
