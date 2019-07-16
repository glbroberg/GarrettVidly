using GarrettVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarrettVidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}