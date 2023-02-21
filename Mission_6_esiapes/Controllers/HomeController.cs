using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private MovieEntryContext MovieContext { get; set; }
        public HomeController( MovieEntryContext x)
        {
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
            ViewBag.Categories = MovieContext.Category.ToList();

            return View();
        }
        [HttpPost]//post method and result
        public IActionResult MovieEntry(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                MovieContext.Add(ar);
                MovieContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Majors = MovieContext.Category.ToList();

                return View(ar);
            }
        }

        public IActionResult MovieList()
        {
            var movies = MovieContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int movieID)
        {
            ViewBag.Categories = MovieContext.Category.ToList();

            var entry = MovieContext.Responses
                .Single(x => x.MovieID == movieID);

            return View("MovieEntry", entry);
        }
        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            MovieContext.Update(blah);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int movieId)
        {
            var entry = MovieContext.Responses
                .Single(x => x.MovieID == movieId);

            return View(entry);
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            MovieContext.Responses.Remove(ar);
            MovieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
