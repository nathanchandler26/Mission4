using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MoviesContext moviesContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MoviesContext movie)
        {
            _logger = logger;
            moviesContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View("AddMovie");
        }

        [HttpPost]
        public IActionResult AddMovie(MovieResponse mr)
        {
            moviesContext.Add(mr);
            moviesContext.SaveChanges();
            return View("Confirmation", mr);
        }
        public IActionResult MyPodcasts()
        {
            return View("MyPodcasts");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
