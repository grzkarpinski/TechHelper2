using System;
using System.Collections.Generic;
using TechHelper.Shared.Enums;

namespace TechHelper.Infrastructure.Entities
{
    public class Drill : BaseTool
    {
        public double LengthXD { get; set; }
        public int TipAngle { get; set; }
        public DrillType DrillType { get; set; }
        public ICollection<CuttingParametersRange> CuttingParametersRanges { get; set; } = new List<CuttingParametersRange>();
        public ICollection<CuttingParametersFinal> CuttingParametersFinals { get; set; } = new List<CuttingParametersFinal>();
    }
}
