using DemoTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoTodo.Controllers
{
    public class TodoController : Controller
    {
        private List<Todo> Todos = new List<Todo> {
            new Todo{ Id=1, Libelle="Acheter du pain", Etat=true },
            new Todo{ Id=2, Libelle="Sortir le chien", Etat=false},
            new Todo{ Id=3, Libelle="Récupérer les enfants", Etat=true },
        };
        // GET: Todo
        public ActionResult Index()
        {
            return View(Todos);
        }
    }
}