using DemoInjectionSql.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace DemoInjectionSql.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Login login)
        {
            //Match match = Regex.Match(login.Password, "[';]");
            //if (match.Success) return View();

            var cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=InjectionSQLDB;Integrated Security=True";
            cnx.Open();

            var cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select Name from Login where Name='{login.Name}' and Password='{login.Password}'";
            var rd = cmd.ExecuteReader();
            if (rd.Read()) return RedirectToAction("Gagne");
            return View();
        }
        [RequireHttps]
        public ActionResult Gagne()
        {
            return View();
        }
    }
}