using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrisonApplication.EFCoreMigrations.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrisonGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrisonGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prisons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrisonGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prisons_PrisonGroups_PrisonGroupId",
                        column: x => x.PrisonGroupId,
                        principalTable: "PrisonGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cells",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CellCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPersons = table.Column<int>(type: "int", nullable: false),
                    MaxNumberOfPersons = table.Column<int>(type: "int", nullable: false),
                    TypeOfCell = table.Column<int>(type: "int", nullable: false),
                    PrisonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cells_Prisons_PrisonId",
                        column: x => x.PrisonId,
                        principalTable: "Prisons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Prisoners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    ReasonInJail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalTermInMonths = table.Column<int>(type: "int", nullable: false),
                    CanComeOutEarly = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisoners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prisoners_Cells_CellId",
                        column: x => x.CellId,
                        principalTable: "Cells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cells_PrisonId",
                table: "Cells",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Prisoners_CellId",
                table: "Prisoners",
                column: "CellId");

            migrationBuilder.CreateIndex(
                name: "IX_Prisons_PrisonGroupId",
                table: "Prisons",
                column: "PrisonGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prisoners");

            migrationBuilder.DropTable(
                name: "Cells");

            migrationBuilder.DropTable(
                name: "Prisons");

            migrationBuilder.DropTable(
                name: "PrisonGroups");
        }
    }
}
