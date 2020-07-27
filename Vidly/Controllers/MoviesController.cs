﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        
        // GET: Movies
        public ActionResult Random()
        {



            var movie = new Movie() { Name = "Shrek!" };

            //return View(movie);

            //return new ViewResult();

            //return Content("Hello World!");

            //return HttpNotFound();

            //return new EmptyResult();

            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
        [Route("movies/released{year}/{monthj:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        
    }
}