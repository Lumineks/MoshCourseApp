using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoshCourseApp.Data;
using MoshCourseApp.Models;
using MoshCourseApp.ViewModels;

namespace MoshCourseApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.Include(m => m.Genre).ToListAsync());//return View(await _context.Customers.Include(c => c.MembershipType).ToListAsync());
        }

        public IActionResult New()
        {
            var viewModel = new MovieFormViewModel()
            {
                Movie = new Movie(),
                Genres = _context.Genre.ToList()
            };

            return View("MovieForm", viewModel);
        }

        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            var viewModel = new MovieFormViewModel()
            {
                Genres = _context.Genre.ToList(),
                Movie = movie
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public IActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return new NotFoundResult();

            return View(movie);
        }
        // Get: Movies/Random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //return Content("Hello World");
            //return NotFound();
            //return new EmptyResult();            
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "Name"});

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }


        //[Route("movies/released/{year:range(1970, 2021)}/{month:regex(\\d{{2}}):range(1,12)}")]
        //public IActionResult ByReleasedDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        //public IActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //public IActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content($"PageIndex = {pageIndex}&sortBy = {sortBy}");
        //}
    }
}