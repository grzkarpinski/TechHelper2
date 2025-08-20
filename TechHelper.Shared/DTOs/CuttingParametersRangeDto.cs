namespace TechHelper.Shared.DTOs
{
    public class CuttingParametersRangeDto
    {
        public int Id { get; set; }
        public string Grade { get; set; } = default!;
        public double CuttingSpeedMin { get; set; }
        public double CuttingSpeedMax { get; set; }
        public double? FeedPerToothMin { get; set; }
        public double? FeedPerToothMax { get; set; }
        public double? FeedPerRevisionMin { get; set; }
        public double? FeedPerRevisionMax { get; set; }
        public int? DrillId { get; set; }
        public int? MillingToolId { get; set; }
        public int? MillingInsertId { get; set; }
    }
}