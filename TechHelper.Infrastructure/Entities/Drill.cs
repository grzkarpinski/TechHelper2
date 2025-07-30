using System;
using TechHelper.Shared.Enums;

namespace TechHelper.Infrastructure.Entities
{
    public class Drill : BaseTool
    {
        public double LengthXD { get; set; }
        public int TipAngle { get; set; }
        public DrillType DrillType { get; set; }

        //Add speeds and feeds parameters from table
    }
}
