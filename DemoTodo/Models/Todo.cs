using DemoTodo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoTodo.Models
{
    public class TodoEtendu
    {
        private TodoContext Context = new TodoContext();

        public bool ClearAll()
        {
            try
            {
                Context.Todos.RemoveRange(Context.Todos);
                Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Insert(string libelle, bool etat)
        {
            try
            {
                Context.Todos.Add(new Todo { Libelle = libelle, Etat = etat });
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public TodoEtendu()
        {

            Todos = Context.Todos.ToList();
        }
        public int Compteur
        {
            get
            {
                return Context.Todos.Count(t => !t.Etat);
            }
        }
        public List<Todo> Todos { get; set; }
    }
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        //[TailleMinMax(5, Max = 50, ErrorMessage = "Taille de texte incorrect")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Entre 5 et 50 caractères")]
        [DisplayName("Libellé")]
        public string Libelle { get; set; }

        public bool Etat { get; set; }

        [DisplayName("Date de modification")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateModif { get; set; } = DateTime.Now;

        [DisplayName("Date de Création")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateCreation { get; set; } = DateTime.Now;
    }
}