using System;

namespace TechHelper.Infrastructure.Entities
{
    public class MillingInsert : BaseEntity
    {
        public string Designation { get; set; }
        public double Radius { get; set; }

        // Will be connected many-to-many with CutterHead

        // Add speeds and feeds parameters from table
    }
}
