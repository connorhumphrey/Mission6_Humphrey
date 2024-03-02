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
            ViewBag.Categories = _context.Categories;
         
            return View("MovieForm1", new Submission1());
        }


        [HttpPost]
        public IActionResult MovieForm1(Submission1 response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //Add to database
                _context.SaveChanges();
                return View("Confirmation", response);
            }
            else //invalid
            {
                ViewBag.Categories = _context.Categories;
                return View(response);
            }
        }

        public IActionResult ViewMovies ()
        {
            var submissions = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(submissions);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories;
            return View("MovieForm1", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Submission1 updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("ViewMovies");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
            .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Submission1 deleted)
        {
            _context.Movies.Remove(deleted);
            _context.SaveChanges();

            return RedirectToAction("ViewMovies");
        }

    }
}
