using JN_Mission6.Models;
using Microsoft.AspNetCore.Mvc;
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
            return View("MovieForm");
        }
        [HttpPost]
        public IActionResult MovieForm(MovieSubmit response)
        {
            _context.Applications.Add(response);
            _context.SaveChanges();

            return View("Confirmation");
        }

    }
}
