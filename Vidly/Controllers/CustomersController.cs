using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Random()
        {
            var customer = new List<Customer> {

            new Customer() { Name = "Alex Rauenzahn" },
            new Customer() { Name = "Gabe Newell" },
            new Customer() { Name = "Elon Musk"},
            new Customer() {Name = "Alan Turing"}
            };


            var movie = new List<Movie>
            {

                new Movie() {Name = "Lord of the Rings" },
                new Movie() {Name = "Inception" },
                new Movie() {Name = "Emperor's New Groove" },
                new Movie() {Name = "The Departed" }
            };

            var viewModel = new RandomCustomerViewModel()
            {
                Customers = customer
            };
            return View(viewModel);
        }
    }
}