using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KPIMS.Core.Models
{
    public class DbProject : BaseClassInfo
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "Summary is required")]
        public string? Summary { get; set; } = string.Empty;
        public string? Details { get; set; }
        public string? Logo { get; set; }
        [NotMapped]
        public IBrowserFile? Image { get; set; }
    }
}
