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
        private IAnimalRepository animalRepository;

        public AnimalController(IAnimalRepository animalRepo)
        {
            this.animalRepository = animalRepo;
        }


        // GET: /<controller>/
        public IActionResult Index(string searchString)
        {
            var cats = from m in animalRepository.Get()
                       //where m.Name.Contains(searchString)
                       select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                cats = cats.Where(cat => cat.Name.Contains(searchString));
            }

            return View("ShowCats", cats.ToList());
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

                animalRepository.Save(c);
                
                return View("Thanks", c);
            }
            return View(c);

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Create an edit view
            // Look up cat object from catId in the database
            // Show an edit view to the user, displaying the cat object
            Cat cat = animalRepository.Get(id);


            return View(cat);
        }

        [HttpPost]
        public IActionResult Edit(Cat c)
        {
            if (ModelState.IsValid)
            {
                animalRepository.Save(c);
                // Save it to the database
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}
