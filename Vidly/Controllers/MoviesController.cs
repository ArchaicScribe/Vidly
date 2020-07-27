using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {


        // GET: Movies
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Shrek: Happily Ever After!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name = "Jane Doe"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);





        }
    }
}