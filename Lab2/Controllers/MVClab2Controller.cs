using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2.Models;


namespace Lab2.Controllers
{
    public class MVClab2Controller : Controller
    {
        // GET: MVClab2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {


            List<Courses> courses = new List<Courses>()
            {
                 new Courses() { id = 1, name = "c sharp" },
                 new Courses() { id = 2, name = "java" },
                new Courses() { id = 3, name = "php" },
                 new Courses() { id = 4, name = "js" }
        };

            return View(courses);
         
        }
    }
}