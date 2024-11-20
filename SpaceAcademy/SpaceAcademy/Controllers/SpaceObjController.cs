using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpaceAcademy.Models;


namespace SpaceAcademy.Controllers
{
    public class SpaceObjController : Controller
    {
        // GET: Space
        public ActionResult Index()
        {

            return View();
        }
        public static List<SpaceObj> GetObjects()
        {
            List<SpaceObj> objects = new List<SpaceObj>();

            objects.Add(new SpaceObj(1,"Black Hole", "a place in space where gravity pulls so much that even light can not get out.","blackHole.jpg"));
            objects.Add(new SpaceObj(2,"Saturn", " a massive ball made mostly of hydrogen and helium.", "saturnn.jpg"));
            objects.Add(new SpaceObj(3,"Jupiter", "the fifth planet from the Sun and the largest in the Solar System", "jupiter.jpg"));

            return objects;
        }
        public ActionResult BlackHole()
        {
            return View();
        }
        public ActionResult Saturn()
        {
            return View();
        }
        public ActionResult Jupiter()
        {
            return View();
        }
    }
}