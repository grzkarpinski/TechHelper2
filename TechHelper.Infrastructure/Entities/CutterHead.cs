using System;
using System.Collections.Generic;
using TechHelper.Shared.Enums;

namespace TechHelper.Infrastructure.Entities
{
    public class CutterHead : BaseEntity
    {
        public int NumberOfTeeth { get; set; }
        public CutterHeadType CutterHeadType { get; set; }

        public ICollection<MillingInsert> MillingInserts { get; set; } = new List<MillingInsert>();
        public ICollection<CuttingParametersFinal> CuttingParametersFinals { get; set; } = new List<CuttingParametersFinal>();
    }
}
