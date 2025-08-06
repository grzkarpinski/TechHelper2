using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechHelper.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CutterHeads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfTeeth = table.Column<int>(type: "int", nullable: false),
                    CutterHeadType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CutterHeads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LengthXD = table.Column<double>(type: "float", nullable: false),
                    TipAngle = table.Column<int>(type: "int", nullable: false),
                    DrillType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsToolActive = table.Column<bool>(type: "bit", nullable: false),
                    Diameter = table.Column<double>(type: "float", nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MillingInserts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Radius = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillingInserts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MillingTools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Radius = table.Column<double>(type: "float", nullable: false),
                    FluteLength = table.Column<int>(type: "int", nullable: false),
                    NumberOfFlutes = table.Column<int>(type: "int", nullable: false),
                    MillingToolType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatalogNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsToolActive = table.Column<bool>(type: "bit", nullable: false),
                    Diameter = table.Column<double>(type: "float", nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MillingTools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CutterHeadMillingInsert",
                columns: table => new
                {
                    CutterHeadsId = table.Column<int>(type: "int", nullable: false),
                    MillingInsertsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CutterHeadMillingInsert", x => new { x.CutterHeadsId, x.MillingInsertsId });
                    table.ForeignKey(
                        name: "FK_CutterHeadMillingInsert_CutterHeads_CutterHeadsId",
                        column: x => x.CutterHeadsId,
                        principalTable: "CutterHeads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CutterHeadMillingInsert_MillingInserts_MillingInsertsId",
                        column: x => x.MillingInsertsId,
                        principalTable: "MillingInserts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CuttingParametersFinals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RPM = table.Column<double>(type: "float", nullable: false),
                    Feed = table.Column<double>(type: "float", nullable: false),
                    CuttingDepth = table.Column<double>(type: "float", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrillId = table.Column<int>(type: "int", nullable: true),
                    MillingToolId = table.Column<int>(type: "int", nullable: true),
                    CutterHeadId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuttingParametersFinals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuttingParametersFinals_CutterHeads_CutterHeadId",
                        column: x => x.CutterHeadId,
                        principalTable: "CutterHeads",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CuttingParametersFinals_Drills_DrillId",
                        column: x => x.DrillId,
                        principalTable: "Drills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CuttingParametersFinals_MillingTools_MillingToolId",
                        column: x => x.MillingToolId,
                        principalTable: "MillingTools",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CuttingParametersRanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuttingSpeedMin = table.Column<double>(type: "float", nullable: false),
                    CuttingSpeedMax = table.Column<double>(type: "float", nullable: false),
                    FeedPerToothMin = table.Column<double>(type: "float", nullable: true),
                    FeedPerToothMax = table.Column<double>(type: "float", nullable: true),
                    FeedPerRevisionMin = table.Column<double>(type: "float", nullable: true),
                    FeedPerRevisionMax = table.Column<double>(type: "float", nullable: true),
                    DrillId = table.Column<int>(type: "int", nullable: true),
                    MillingToolId = table.Column<int>(type: "int", nullable: true),
                    MillingInsertId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuttingParametersRanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CuttingParametersRanges_Drills_DrillId",
                        column: x => x.DrillId,
                        principalTable: "Drills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CuttingParametersRanges_MillingInserts_MillingInsertId",
                        column: x => x.MillingInsertId,
                        principalTable: "MillingInserts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CuttingParametersRanges_MillingTools_MillingToolId",
                        column: x => x.MillingToolId,
                        principalTable: "MillingTools",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CutterHeadMillingInsert_MillingInsertsId",
                table: "CutterHeadMillingInsert",
                column: "MillingInsertsId");

            migrationBuilder.CreateIndex(
                name: "IX_CuttingParametersFinals_CutterHeadId",
                table: "CuttingParametersFinals",
                column: "CutterHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_CuttingParametersFinals_DrillId",
                table: "CuttingParametersFinals",
                column: "DrillId");

            migrationBuilder.CreateIndex(
                name: "IX_CuttingParametersFinals_MillingToolId",
                table: "CuttingParametersFinals",
                column: "MillingToolId");

            migrationBuilder.CreateIndex(
                name: "IX_CuttingParametersRanges_DrillId",
                table: "CuttingParametersRanges",
                column: "DrillId");

            migrationBuilder.CreateIndex(
                name: "IX_CuttingParametersRanges_MillingInsertId",
                table: "CuttingParametersRanges",
                column: "MillingInsertId");

            migrationBuilder.CreateIndex(
                name: "IX_CuttingParametersRanges_MillingToolId",
                table: "CuttingParametersRanges",
                column: "MillingToolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CutterHeadMillingInsert");

            migrationBuilder.DropTable(
                name: "CuttingParametersFinals");

            migrationBuilder.DropTable(
                name: "CuttingParametersRanges");

            migrationBuilder.DropTable(
                name: "CutterHeads");

            migrationBuilder.DropTable(
                name: "Drills");

            migrationBuilder.DropTable(
                name: "MillingInserts");

            migrationBuilder.DropTable(
                name: "MillingTools");
        }
    }
}
