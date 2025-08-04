using System;

namespace TechHelper.Infrastructure.Entities
{
    public class CuttingParametersRange : BaseEntity
    {
        public string grade { get; set; }
        public double CuttingSpeedMin { get; set; }
        public double CuttingSpeedMax { get; set; }
        public double? FeedPerToothMin { get; set; }
        public double? FeedPerToothMax { get; set; }
        public double? FeedPerRevisionMin { get; set; }
        public double? FeedPerRevisionMax { get; set; }

        public int? DrillId { get; set; }
        public Drill? Drill { get; set; }

        public int? MillingToolId { get; set; }
        public MillingTool? MillingTool { get; set; }

        public int? MillingInsertId { get; set; }
        public MillingInsert? MillingInsert { get; set; }
    }
}
