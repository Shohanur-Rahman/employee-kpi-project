using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KPIMS.Core
{
    public class BaseClassInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public int CreatedId { get; set; }
        public int UpdatedId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public BaseClassInfo()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
