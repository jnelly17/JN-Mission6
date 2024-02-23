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

            return View("MovieForm", new MovieSubmit());
        }
        [HttpPost]
        public IActionResult MovieForm(MovieSubmit response)
        {

            if(ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirmation");
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName).ToList();

                return View(response);
            }

        }

        public IActionResult Display ()
        {
            var applications = _context.Movies
                .Include("Category")
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {

            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View("MovieForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieSubmit updateInfo)
        {

            if (ModelState.IsValid)
            {
                _context.Update(updateInfo);
                _context.SaveChanges();

                return RedirectToAction("Display");
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName).ToList();

                return View("MovieForm", updateInfo);
            }
            
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(MovieSubmit deleteInfo)
        {
            _context.Movies.Remove(deleteInfo); //change applications andall other tables to "Movies"
            _context.SaveChanges();

            return RedirectToAction("Display");
        }

    }
}
