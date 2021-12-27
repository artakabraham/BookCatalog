﻿using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Dto
{
    public class CreateOrUpdateBookDto
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal Price { get; set; }
    }
}
