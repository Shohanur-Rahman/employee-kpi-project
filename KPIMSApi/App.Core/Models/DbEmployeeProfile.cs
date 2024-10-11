using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace KPIMS.Core.Models
{
    [Index(nameof(EmployeeId), IsUnique = true)]
    public class DbEmployeeProfile:BaseClassInfo
    {
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public virtual DbEmployee? Employee { get; set; }
        public string? Mobile { get; set; }
        public string? PersonalEmail { get; set; }
        public string? PresentAddress { get; set; }
        public string? PermanentAddress { get; set; }
        public string? Hobby { get; set; }
        public bool MaritalStatus { get; set; }
        public string? SpouseName { get; set; }
        public string? SpouseMobile { get; set; }
        public string? ContactPersionName { get; set; }
        public string? ContactPersionEmail { get; set; }
        public string? ContactPersionMobile { get; set; }
    }
}
