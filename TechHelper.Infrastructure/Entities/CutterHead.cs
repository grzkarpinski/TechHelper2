using System;
using TechHelper.Shared.Enums;

namespace TechHelper.Infrastructure.Entities
{
    public class CutterHead : BaseEntity
    {
        public int NumberOfTeeth { get; set; }
        public CutterHeadType CutterHeadType { get; set; }

        // Will be connected many-to-many with MillingInsert

        // Add speeds and feeds parameters from table
    }
}
