using Microsoft.AspNetCore.Mvc;
using Mission6_Humphrey.Models;
using System.Diagnostics;

namespace Mission6_Humphrey.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;
        public HomeController(MovieFormContext temp) { //constructor
            
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
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Submission response)
        {
            _context.Submissions.Add(response); //Add to database
            _context.SaveChanges();
            return View("Index", response);
        }

    }
}
