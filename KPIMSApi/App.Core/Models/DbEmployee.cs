using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace KPIMS.Core.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class DbEmployee:BaseClassInfo
    {
        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; } = string.Empty;
        [NotMapped]
        public string FullName { get
            {
                return $"{FirstName} {LastName}";
            } 
        }
        [ForeignKey(nameof(Designation))]
        public int DesignationId { get; set; }
        public virtual DbDesignation? Designation { get; set; }
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PasswordSalt { get; set; } = string.Empty;
        [NotMapped]
        public string OrigianlPassword { get; set; } = string.Empty;
        public string? Avatar { get; set; }
        [NotMapped]
        public IBrowserFile? Image { get; set; }

        public virtual DbEmployeeProfile? EmployeeProfile { get; set; }

    }
}
