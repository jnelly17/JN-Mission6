using JN_Mission6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace JN_Mission6.Controllers
{
    public class HomeController : Controller
    {

        private MovieApplicationContext _context;

        public HomeController(MovieApplicationContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View("MovieForm");
        }
        [HttpPost]
        public IActionResult MovieForm(MovieSubmit response)
        {
            _context.Applications.Add(response);
            _context.SaveChanges();

            return View("Confirmation");
        }

        public IActionResult Display ()
        {
            var applications = _context.Applications
                .Include("Category")
                .ToList();

            return View(applications);
        }

    }
}
