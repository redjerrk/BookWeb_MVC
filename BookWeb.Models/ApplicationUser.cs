
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string? City { get; set; }

        public string? Zip { get; set; }

    }
}
