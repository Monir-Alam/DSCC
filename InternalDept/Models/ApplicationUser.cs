using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace InterDept.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Designation { get; set; }

    }
}
