﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomCustomerViewModel
    {
        public Movie Movie { get; set; }

        public Customer Customer { get; set; }
        //public List<Customer> Customers { get; set; }
    }
}