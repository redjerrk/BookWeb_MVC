using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_commerceBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Category Name")]
        public required string Name { get; set; }
        [DisplayName("Category Order")]
        public int DisplayOrder { get; set; }
        

    }
}
