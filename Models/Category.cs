using System.ComponentModel.DataAnnotations;

namespace EF.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "This field is Mandatory")]
        [MaxLength(60, ErrorMessage = "This field must contain between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "This field must contain between 3 and 60 characters")]
        public string Title { get; set; }
    }
}