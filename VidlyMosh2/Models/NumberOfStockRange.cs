using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyMosh2.Models
{
    public class NumberOfStockRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;

            if (movie.NumberInStock == 0)
            {
                return ValidationResult.Success;
            }

            if (movie.NumberInStock > 0 && movie.NumberInStock < 20)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Numberof Stock should between 0 and 20!");
            }

            return base.IsValid(value, validationContext);


        }

       
    }
}