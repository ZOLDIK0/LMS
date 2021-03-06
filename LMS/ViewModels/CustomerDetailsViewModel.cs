﻿using LMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.ViewModels
{
    public class CustomerDetailsViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<Rental> Rentals { get; set; }
    }
}