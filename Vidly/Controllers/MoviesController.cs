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


            var movie = new Movie() { Name = "Inception" };
            /*var movies = new List<Movie>
            {
                new Movie() {Name = "Lord of the Rings" },
                new Movie() {Name = "Inception" },
                new Movie() {Name = "Emperor's New Groove" },
                new Movie() {Name = "The Departed" }
            };
            */
            
            var customers = new List<Customer> {

            new Customer() { Name = "Alex Rauenzahn" },
            new Customer() { Name = "Gabe Newell" },
            new Customer() { Name = "Elon Musk"},
            new Customer() {Name = "Alan Turing"}
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