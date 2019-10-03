﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalCrossing.Data;
using AnimalCrossing.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimalCrossing.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AnimalCrossingContext _context;

        public AnimalController(AnimalCrossingContext context)
        {
            _context = context;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var cats = _context.Cats.ToList();
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
            if (ModelState.IsValid) {
                ViewBag.Thanks = c.Name;
                ViewBag.Cat = c;

                _context.Cats.Add(c);
                _context.SaveChanges();

                return View("Thanks", c);
            }
            return View(c);

        }



    }
}
