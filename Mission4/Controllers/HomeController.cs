using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4.Models;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {

        private MoviesContext moviesContext { get; set; }

        public HomeController(MoviesContext movie)
        {
            moviesContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categories = moviesContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(MovieResponse mr)
        {
            if (ModelState.IsValid)
            {
                moviesContext.Add(mr);
                moviesContext.SaveChanges();
                return View("Confirmation", mr);
            }
            else // If Invalid
            {
                ViewBag.Categories = moviesContext.Categories.ToList();
                return View();
            }
        }
        public IActionResult MyPodcasts()
        {
            return View("MyPodcasts");
        }

        [HttpGet]
        public IActionResult MovieList ()
        {
            var movies = moviesContext.Movies
                .Include(x => x.Category)
                // You can do something like this to filter: .Where(x => x.Title == Batman)
                // This above line would only show movies where the title is Batman
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = moviesContext.Categories.ToList();
            var movie = moviesContext.Movies.Single(x => x.MovieId == movieid);
            return View("AddMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit (MovieResponse x)
        {
            moviesContext.Update(x);
            moviesContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var movie = moviesContext.Movies.Single(x => x.MovieId == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            moviesContext.Movies.Remove(mr);
            moviesContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
