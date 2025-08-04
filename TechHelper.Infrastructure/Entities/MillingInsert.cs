using System;
using System.Collections.Generic;

namespace TechHelper.Infrastructure.Entities
{
    public class MillingInsert : BaseEntity
    {
        public string Designation { get; set; }
        public double Radius { get; set; }

        public ICollection<CutterHead> CutterHeads { get; set; } = new List<CutterHead>();
        public ICollection<CuttingParametersRange> CuttingParametersRanges { get; set; } = new List<CuttingParametersRange>();
    }
}
