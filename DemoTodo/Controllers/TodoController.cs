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
        private List<Todo> Todos = new List<Todo>
        {
            new Todo{Id=1, Libelle = "Acheter du pain", Etat=true },
            new Todo{Id=2, Libelle = "Sortir le chien" , Etat=false },
            new Todo{Id=3, Libelle = "Récupérer les enfants", Etat=false },
        };
        public ActionResult Index()
        {

            return View(Todos);
        }
        public ActionResult Edit(int? id)
        {
            if (id != null)
            {
                var todo = Todos.Where(t => t.Id == id).FirstOrDefault();
                if (todo != null) return View(todo);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit()
        {
            int id = int.Parse(Request.Form["Id"]);
            string libelle = Request.Form["Libelle"];
            bool etat = Request.Form.GetValues("Etat")[0] == "on";

            var todo = new Todo { Id = id, Libelle = libelle, Etat = etat };
            return View(todo);

        }
    }
}