using System.ComponentModel.DataAnnotations;

namespace KPIMS.Core.Models
{
    public class DbDesignation : BaseClassInfo
    {
        [Required(ErrorMessage = "Designation name is required")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage =  "Order is required")]
        public int OrderId { get; set; }
    }
}
