using GarrettVidly.Models;
using GarrettVidly.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarrettVidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new MovieIndexViewModel()
            {
                Movies = new List<Movie>
                {
                    new Movie {Name = "Fight Club"},
                    new Movie {Name = "Sin City"}
                }
            };
            return View(viewModel);
        }



        //GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek"
            };

            var customers = new List<Customer>()
            {
                new Customer() { Name = "Garrett" },
                new Customer() { Name = "Meredith" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return Content("Hello Garrett");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });

        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        [Route("movies/release/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}