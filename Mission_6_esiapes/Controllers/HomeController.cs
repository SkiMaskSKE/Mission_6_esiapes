﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_6_esiapes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6_esiapes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieEntryContext MovieContext { get; set; }
        public HomeController(ILogger<HomeController> logger, MovieEntryContext x)
        {
            _logger = logger;
            MovieContext = x;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]//get method and result
        public IActionResult MovieEntry()
        {
            return View();
        }
        [HttpPost]//post method and result
        public IActionResult MovieEntry(ApplicationResponse ar)
        {
            MovieContext.Add(ar);
            MovieContext.SaveChanges();
            return View("Confirmation");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
