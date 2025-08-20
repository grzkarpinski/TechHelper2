using System;

namespace TechHelper.Infrastructure.Entities
{
    public abstract class BaseTool : BaseEntity
    {
        public required string CatalogNumber { get; set; }
        public string? Description { get; set; }
        public bool IsToolActive { get; set; }
        public double Diameter { get; set; }
        public string? Producer { get; set; }
    }
}
