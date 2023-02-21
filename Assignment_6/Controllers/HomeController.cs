using Assignment_6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext mContext { get; set; }

        public HomeController(MoviesContext someName)
        {
            mContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnterMovies()
        {
            ViewBag.MovieCategories = mContext.MovieCategories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult EnterMovies (MovieResponse ar)
        {
            //Added from class comments
            if (ModelState.IsValid)
            {
                mContext.Add(ar);
                mContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            ViewBag.MovieCategories = mContext.MovieCategories.ToList();

            var movies = mContext.Responses
                .Include(x => x.MovieCategory)
                .ToList();

            return View(movies);
        }

        public IActionResult Edit()
        {
            ViewBag.MovieCategories = mContext.MovieCategories.ToList();

            var movie = mContext.Responses.Single();

            return View("EnterMovies");
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
