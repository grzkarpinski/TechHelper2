using System;

namespace TechHelper.Infrastructure.Entities
{
    public class CuttingParametersFinal : BaseEntity
    {
        public string Material { get; set; }

        public double RPM { get; set; }

        public double Feed { get; set; }

        public double? CuttingDepth { get; set; }

        public string? Notes { get; set; }

        // Will be connected 1:1 with Drill, MillingTool, or MillingInsert (only one at a time)
    }
}
