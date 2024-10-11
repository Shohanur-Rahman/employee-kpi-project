using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KPIMS.Core.Models
{
    public class DbWorkItem: BaseClassInfo
    {
        [Required(ErrorMessage ="Enter the title")]
        public string Title { get; set; } = string.Empty;
        [ForeignKey(nameof(Employee))]
        public int? AssignedToId { get; set; }
        [Required(ErrorMessage ="State is required")]
        public int StateId { get; set; }
        [Required(ErrorMessage = "Item Type is required")]
        [ForeignKey(nameof(WorkType))]
        public int WorkTypeId { get; set; }
        [ForeignKey(nameof(ParentWork))]
        public int? ParentWorkId { get; set; }
        [ForeignKey(nameof(Project))]
        public int? ProjectId { get; set; }
        public string Description { get; set; } = string.Empty;
        public string AcceptanceCreteria { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StoryPoint { get; set; }

        public virtual DbWorkItem? ParentWork { get; set; }
        public virtual DbProject? Project { get; set; }
        public virtual DbWorkItemType? WorkType { get; set; }
        public virtual DbEmployee? Employee { get; set; }
        public virtual ICollection<DbWorkItem> SubWorks { get; set; } = new List<DbWorkItem>();
    }
}
