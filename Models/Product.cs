using System.ComponentModel.DataAnnotations;

namespace EF.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [MaxLength(60, ErrorMessage = "This field must contain between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "This field must contain between 3 and 60 characters")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "This field must countain max 1024 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [Range(1, int.MaxValue, ErrorMessage = "The price must be greater than zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "This field is mandatory")]
        [Range(1, int.MaxValue, ErrorMessage = "This field is mandatory")]
        public int CategoryId { get; set; }

        public Category Category { get; set; } 
    }
}