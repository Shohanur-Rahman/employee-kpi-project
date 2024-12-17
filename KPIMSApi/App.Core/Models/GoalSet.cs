namespace KPIMS.Core.Models
{
    public class GoalSet : BaseClassInfo
    {
        public string GoalOverview { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string KeyPoints { get; set; } = string.Empty;
        public int ApproverId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
