using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo2_MVCWebApi.Models
{
    public class Repository
    {
        private FootContext Context = new FootContext();

        public IEnumerable<Rencontre> GetMatches(int id=0)
        {
            if (id==0) return Context.Rencontres;
            return Context.Rencontres.Where(r => r.Id == id);
        }
    }
}