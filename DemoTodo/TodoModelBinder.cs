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
            int id = int.Parse(controllerContext.HttpContext.Request.Form["Id"]);
            string libelle = controllerContext.HttpContext.Request.Form["Libelle"];
            //bool etat = controllerContext.HttpContext.Request.Form.GetValues("Etat")[0] == "on";

            var todo = new Todo { Id = id, Libelle = libelle, Etat = false };
            return todo;
        }
    }
}