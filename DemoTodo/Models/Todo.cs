using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoTodo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public bool Etat { get; set; }
    }
}