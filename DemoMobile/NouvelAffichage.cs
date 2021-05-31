using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace DemoMobile
{
    public class NouvelAffichage
    {
        public NouvelAffichage()
        {
            DisplayModeProvider.Instance.Modes.Insert(0,
                new DefaultDisplayMode("IPhone")
                {
                    ContextCondition= x=>x.Request.UserAgent.IndexOf("iPhone", StringComparison.OrdinalIgnoreCase) > 0
                }
                );
        }
    }
}