using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoCache
{
    public class Repository
    {
        private List<String> Liste = new List<string>();
        public List<string> Get()
        {
            Liste.Add("Data1");
            Liste.Add("Data2");
            Liste.Add(DateTime.Now.ToString("HH:mm:ss"));
            return Liste;
        }
    }
}