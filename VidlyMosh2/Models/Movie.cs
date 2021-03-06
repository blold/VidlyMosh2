﻿
using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyMosh2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie`s name!!!!!!")]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [NumberOfStockRange]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

    }
}