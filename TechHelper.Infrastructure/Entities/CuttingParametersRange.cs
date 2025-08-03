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

        // Will be connected 1:1 with Drill, MillingTool, or MillingInsert (only one at a time)
    }
}
