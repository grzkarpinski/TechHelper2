namespace TechHelper.Shared.DTOs
{
    public class CutterHeadDto
    {
        public int Id { get; set; }
        public string CatalogNumber { get; set; } = default!;
        public string? Description { get; set; }
        public double Diameter { get; set; }
        public string? Producer { get; set; }
        public int NumberOfTeeth { get; set; }
        public string CutterHeadType { get; set; } = default!;
    }
}