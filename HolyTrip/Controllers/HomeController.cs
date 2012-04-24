using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HolyTrip.Models;
using System.Web.Helpers;
namespace HolyTrip.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public JsonResult People()
        {
            List<Person> personItems = new List<Person>();
            Person person = new Person();
            person.Name = "Zé Berdeu";
            person.Occupation = "Capataz";
            person.Age = 25;
            personItems.Add(person);

            person = new Person();
            person.Name = "Chico Bento";
            person.Occupation = "Fazendeiro";
            person.Age = 30;
            personItems.Add(person);

            People people = new People();
            people.Items = personItems;

            return Json(people, JsonRequestBehavior.AllowGet);
        }
    }
}
