using System;
using System.Collections.Generic;
using TechHelper.Shared.Enums;

namespace TechHelper.Infrastructure.Entities
{
    public class MillingTool : BaseTool
    {
        public double Radius { get; set; }

        public int FluteLength { get; set; }

        public int NumberOfFlutes { get; set; }

        public MillingToolType MillingToolType { get; set; }

        public ICollection<CuttingParametersRange> CuttingParametersRanges { get; set; } = new List<CuttingParametersRange>();
        public ICollection<CuttingParametersFinal> CuttingParametersFinals { get; set; } = new List<CuttingParametersFinal>();
    }
}
