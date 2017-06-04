using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMosh2.Models;

namespace VidlyMosh2.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}