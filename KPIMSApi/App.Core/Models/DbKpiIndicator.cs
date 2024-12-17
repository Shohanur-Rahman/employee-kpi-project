using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KPIMS.Core.Models
{
    public class DbKpiIndicator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string KPILabel { get; set; } = string.Empty;
        public int MinPoint { get; set; }
        public int MaxPoint { get; set; }
        public string PerofrmanceBenefit { get; set; }=string.Empty;
    }
}
