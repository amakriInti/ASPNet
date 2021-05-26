using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoTodo2.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Titre { get; set; }
        public bool Etat { get; set; }
    }
}