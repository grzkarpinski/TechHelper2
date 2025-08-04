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

        public int? DrillId { get; set; }
        public Drill? Drill { get; set; }

        public int? MillingToolId { get; set; }
        public MillingTool? MillingTool { get; set; }

        public int? CutterHeadId { get; set; }
        public CutterHead? CutterHead { get; set; }
    }
}
