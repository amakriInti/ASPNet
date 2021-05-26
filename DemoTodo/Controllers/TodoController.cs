using DemoTodo.Data;
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
        private TodoContext Context = new TodoContext();
        //private List<Todo> Todos = new List<Todo> {
        //    new Todo{ Id=1, Libelle="Acheter du pain", Etat=true, DateCreation=DateTime.Now, DateModif=DateTime.Now },
        //    new Todo{ Id=2, Libelle="Sortir le chien", Etat=false, DateCreation=DateTime.Now, DateModif=DateTime.Now},
        //    new Todo{ Id=3, Libelle="Récupérer les enfants", Etat=true, DateCreation=DateTime.Now, DateModif=DateTime.Now },
        //};
        // GET: Todo
        public ActionResult Index()
        {
            ViewBag.Utilisateur = "Ali";
            var todos = Context.Todos.ToList();
            return View(todos);
        }
        public ActionResult Create()
        {
            var todo = new Todo();
            return View(todo);
        }
        [HttpPost]
        public ActionResult Create(Todo todo)
        {
            todo.DateCreation = DateTime.Now;
            Context.Todos.Add(todo);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var todo = Context.Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return RedirectToAction("Index");
            return View(todo);
        }
        // Avec ModelBinder par défaut
        //[HttpPost]
        //public ActionResult Edit(Todo todoModifie)
        //{
        //    var todo = Todos.FirstOrDefault(t => t.Id == todoModifie.Id);
        //    if (todo == null) return RedirectToAction("Index");
        //    todo.Libelle = todoModifie.Libelle;
        //    todo.Etat = todoModifie.Etat;
        //    return View(todo);
        //}

        // Sans ModelBinder par défaut
        //[HttpPost]
        //public ActionResult Edit()
        //{
        //    var todo = new Todo();
        //    todo.Id = int.Parse(Request.Form["Id"].ToString());
        //    todo.Libelle = Request.Form["Libelle"].ToString();
        //    todo.Etat = bool.Parse(Request.Form.GetValues("Etat")[0]);

        //    return View(todo);
        //}

        // Avec ModelBinder personnalisé
       [HttpPost]
        public ActionResult Edit(Todo todoModifie)
        {
            var todo = Context.Todos.FirstOrDefault(t => t.Id == todoModifie.Id);
            if (todo == null) return RedirectToAction("Index");
            todo.Libelle = todoModifie.Libelle;
            todo.Etat = todoModifie.Etat;
            todo.DateModif = DateTime.Now;
            Context.SaveChanges();
            return View(todo);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            var todoASupprimer = Context.Todos.FirstOrDefault(t => t.Id == id);
            if (todoASupprimer == null) return RedirectToAction("Index");
            return View(todoASupprimer);
        }
        [HttpPost]
        public ActionResult Delete(int? id, int? a)
        {
            var todo = Context.Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null) return RedirectToAction("Index");
            Context.Todos.Remove(todo);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        public PartialViewResult Commentaire()
        {
            return PartialView();
        }
    }
}