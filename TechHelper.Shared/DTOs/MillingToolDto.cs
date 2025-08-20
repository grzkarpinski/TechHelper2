namespace TechHelper.Shared.DTOs
{
    public class MillingToolDto
    {
        public int Id { get; set; }
        public string CatalogNumber { get; set; } = default!;
        public string? Description { get; set; }
        public double Diameter { get; set; }
        public string? Producer { get; set; }
        public double Radius { get; set; }
        public int FluteLength { get; set; }
        public int NumberOfFlutes { get; set; }
        public string MillingToolType { get; set; } = default!;
    }
}