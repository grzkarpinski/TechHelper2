namespace TechHelper.Shared.DTOs
{
    public class MillingInsertDto
    {
        public int Id { get; set; }
        public string Designation { get; set; } = default!;
        public double Radius { get; set; }
    }
}