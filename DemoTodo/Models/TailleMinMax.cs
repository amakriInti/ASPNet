using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoTodo.Models
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TailleMinMax : ValidationAttribute
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public TailleMinMax(int min)
        {
            Min = min;  
        }
        public override bool IsValid(object value)
        {
            return value.ToString().Length >= Min && value.ToString().Length <= Max;
        }
    }
}