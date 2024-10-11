namespace KPIMS.Core.Models
{
    class DbKpiIndicator
    {
        public int Id { get; set; }
        public string KPILabel { get; set; } = string.Empty;
        public decimal BaseIncrement { get; set; }
        public decimal MaxIncrement { get; set; }
    }
}
