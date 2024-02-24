using Microsoft.AspNetCore.Mvc;
using Mission6_Humphrey.Models;
using System.Diagnostics;

namespace Mission6_Humphrey.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext1 _context;
        public HomeController(MovieFormContext1 temp) { //constructor
            
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm1()
        {
         
            return View();
        }


        [HttpPost]
        public IActionResult MovieForm1(Submission1 response)
        {
            _context.Movies.Add(response); //Add to database
            _context.SaveChanges();
            return View("Index", response);
        }

        public IActionResult ViewMovies ()
        {
            var submissions = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(submissions);
        }

        public IActionResult Edit()
        {
            return View("MovieForm1");
        }
    }
}
