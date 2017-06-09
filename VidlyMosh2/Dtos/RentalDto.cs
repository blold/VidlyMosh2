using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMosh2.Models;

namespace VidlyMosh2.Dtos
{
    public class RentalDto
    {
        public int CustomerId { get; set; }
        public List<int> MovieId { get; set; }
    }
}