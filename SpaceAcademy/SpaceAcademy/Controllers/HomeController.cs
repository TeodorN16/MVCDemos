using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceAcademy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewData["spaceObj"] = SpaceObjController.GetObjects();
            return View();
        }
        public ActionResult Trainers()
        {
            ViewData["ins"] = InstructorController.GetInstruktors();
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}