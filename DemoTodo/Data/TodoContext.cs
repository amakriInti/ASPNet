using DemoTodo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoTodo.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext() : base("name=TodoConfig") { }
        public DbSet<Todo> Todos { get; set; }
    }
}