﻿using System.ComponentModel.DataAnnotations;

namespace BeerCollection.Models
{
    public class BeerObj
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        public decimal? Rating { get; set; }
    }
}