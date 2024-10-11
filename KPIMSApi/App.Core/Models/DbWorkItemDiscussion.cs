using System.ComponentModel.DataAnnotations.Schema;

namespace KPIMS.Core.Models
{
    public class DbWorkItemDiscussion:BaseClassInfo
    {
        public string ArticleDetails { get; set; } = string.Empty;
        public int WorkItemId { get; set; }
        [ForeignKey(nameof(Employee))]
        public int EmployeeId { get; set; }
        public virtual DbEmployee? Employee{ get; set; }
    }
}
