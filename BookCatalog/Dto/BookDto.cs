using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Dto
{
    public record BookDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal Price { get; set; }
    }
}
