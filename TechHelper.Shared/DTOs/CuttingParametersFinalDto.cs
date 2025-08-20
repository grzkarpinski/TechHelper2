namespace TechHelper.Shared.DTOs
{
    public class CuttingParametersFinalDto
    {
        public int Id { get; set; }
        public string Material { get; set; } = default!;
        public double RPM { get; set; }
        public double Feed { get; set; }
        public double? CuttingDepth { get; set; }
        public string? Notes { get; set; }
        public int? DrillId { get; set; }
        public int? MillingToolId { get; set; }
        public int? CutterHeadId { get; set; }
    }
}