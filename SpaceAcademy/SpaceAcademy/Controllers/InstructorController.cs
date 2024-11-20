using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpaceAcademy.Models;

namespace SpaceAcademy.Controllers
{
    public class InstructorController : Controller
    {
        // GET: Instructor
        public ActionResult Index()
        {
            ViewData["ins"] = InstructorController.GetInstruktors();
            return View();
        }
        public static List<Instructor> GetInstruktors()
        {
            List<Instructor> people = new List<Instructor>();
            people.Add(new Instructor(1,"Mitko", 39, "i have over 10 years of experience in the space field","Mitko.jpg"));
            people.Add(new Instructor(2,"Petq", 45, "i have been a space academy teacher for the past 15 years","Petkana.jpg"));
            people.Add(new Instructor(3,"Gosho", 50, "Ever since i was a child i was obsessed with space so you know i know what i am doing","gosho3.jpg"));

            return people;
        }
        public ActionResult Mitko()
        {
            return View();
        }
        public ActionResult Petq()
        {
            return View();
        }
        public ActionResult Gosho()
        {
            return View();
        }
    }
}