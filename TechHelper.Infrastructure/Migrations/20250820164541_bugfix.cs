using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechHelper.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class bugfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CatalogNumber",
                table: "CutterHeads",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CutterHeads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Diameter",
                table: "CutterHeads",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "IsToolActive",
                table: "CutterHeads",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Producer",
                table: "CutterHeads",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatalogNumber",
                table: "CutterHeads");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CutterHeads");

            migrationBuilder.DropColumn(
                name: "Diameter",
                table: "CutterHeads");

            migrationBuilder.DropColumn(
                name: "IsToolActive",
                table: "CutterHeads");

            migrationBuilder.DropColumn(
                name: "Producer",
                table: "CutterHeads");
        }
    }
}
