﻿using System;
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
            var customer = new Customer() { Name = "Gabe Newell" };
           /* var customers = new List<Customer> {

            new Customer() { Name = "Alex Rauenzahn" },
            new Customer() { Name = "Gabe Newell" },
            new Customer() { Name = "Elon Musk"},
            new Customer() {Name = "Alan Turing"}
            };
*/

         

            var viewModel = new RandomCustomerViewModel()
            {
                Customer = customer
            };
            return View(viewModel);
        }
    }
}