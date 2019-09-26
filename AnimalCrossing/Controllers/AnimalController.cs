using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalCrossing.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimalCrossing.Controllers
{
    public class AnimalController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public string Hello()
        {
            return "Well, hello there! We are learning .NET Core now...";
        }

        public IActionResult MyFirstView()
        {
            ViewBag.MyWifeSays = "Go buy groceries, clean up, make dinner";
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cat c)
        {
            return View("Thanks");
        }



    }
}
