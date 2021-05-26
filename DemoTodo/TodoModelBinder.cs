using DemoTodo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoTodo
{
    public class TodoModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var todo = new Todo();
            if (controllerContext.HttpContext.Request.Path.Contains("Create"))
            {
                todo.Libelle = controllerContext.HttpContext.Request.Form["Libelle"].ToString();
                todo.Etat = bool.Parse(controllerContext.HttpContext.Request.Form.GetValues("Etat")[0]);
            }
            else if (controllerContext.HttpContext.Request.Path.Contains("Edit"))
            {
                todo.Id = int.Parse(controllerContext.HttpContext.Request.Form["Id"].ToString());
                todo.Libelle = controllerContext.HttpContext.Request.Form["Libelle"].ToString();
                todo.Etat = bool.Parse(controllerContext.HttpContext.Request.Form.GetValues("Etat")[0]);
            }
            return todo;
        }
    }
}