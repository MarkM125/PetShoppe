using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PetsModel = PetShoppe.Models.PetsModel;

namespace PetShoppe.Controllers
{
    public class HomeController : Controller
    {
        public static List<PetsModel> petDataBase = new List<PetsModel>() {
            new PetsModel("Frank", 3, "Dog"),
            new PetsModel("Ben", 3, "Cat"),
            new PetsModel("Dug", 3, "Dog"),
            new PetsModel("Nutty", 3, "Hampster")
            };

        public ActionResult Index()
        {

            return View(petDataBase);
        }
    }
}
