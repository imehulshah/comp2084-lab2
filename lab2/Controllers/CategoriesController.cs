using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(String Categories)
        {
            @ViewBag.Categories = "You selected Category: " + Categories;
            return View();


        }
    }
}