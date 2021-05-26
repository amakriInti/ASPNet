using DemoTodo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoTodo2.Controllers
{
    public class TodoController : Controller
    {
        private List<Todo> todos = new List<Todo> {
                new Todo { TodoId = 1, Titre = "Chercher du pain", Etat = false },
                new Todo { TodoId = 2, Titre = "Partir en Week-end", Etat = false },
                new Todo { TodoId = 3, Titre = "Aller au cinéma", Etat = true } };
        // GET: Todo
        public ActionResult Index()
        {
            return View(todos);
        }

        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Todo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Todo/Edit/5
        public ActionResult Edit(int id)
        {
            var todo = todos.Where(t => t.TodoId == id).FirstOrDefault();
            if (todo == null) return RedirectToAction("Index");
            return View(todo);
        }

        // POST: Todo/Edit/5
        [HttpPost]
        public ActionResult Edit(Todo todoModifie)
        {
            var todo = todos.Where(t => t.TodoId == todoModifie.TodoId).FirstOrDefault();
            todo.Titre = todoModifie.Titre;
            todo.Etat = todoModifie.Etat;
            return View();
        }

        // GET: Todo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Todo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
