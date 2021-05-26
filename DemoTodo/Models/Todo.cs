using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoTodo.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength =10, ErrorMessage ="Tapez entre 10 et 50 caractères")]
        [DisplayName("Libellé")]
        public string Libelle { get; set; }
        public bool Etat { get; set; }

        [DisplayName("Date de modification")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateModif { get; set; }

        [DisplayName("Date de Création")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateCreation { get; set; }
    }
}