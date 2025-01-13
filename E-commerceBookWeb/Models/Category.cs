using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_commerceBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [DisplayName("Category Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 - 100")]
        public int DisplayOrder { get; set; }
        

    }
}
