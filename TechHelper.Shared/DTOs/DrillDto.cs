namespace TechHelper.Shared.DTOs
{
    public class DrillDto
    {
        public int Id { get; set; }
        public string CatalogNumber { get; set; } = default!;
        public string? Description { get; set; }
        public double Diameter { get; set; }
        public string? Producer { get; set; }
        public double LengthXD { get; set; }
        public int TipAngle { get; set; }
        public string DrillType { get; set; } = default!;
    }
}