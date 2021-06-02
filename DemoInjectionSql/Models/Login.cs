using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoInjectionSql.Models
{
    public class Login
    {
        [DisplayName("Nom")]
        [RegularExpression(@"[^;'].")]
        public string Name { get; set; }

        [DisplayName("Mot de passe")]
        [RegularExpression(@"[^;'].")]
        public string Password { get; set; }
    }
}