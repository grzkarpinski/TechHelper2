using System;
using TechHelper.Shared.Enums;

namespace TechHelper.Infrastructure.Entities
{
    public class MillingTool : BaseTool
    {
        public double Radius { get; set; }

        public int FluteLength { get; set; }

        public int NumberOfFlutes { get; set; }

        public MillingToolType MillingToolType { get; set; }

        // Add speeds and feeds parameters from table
    }
}
