using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cargo.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargoInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LatestDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConsignataryName = table.Column<string>(type: "text", nullable: false),
                    ConsignatarySurname = table.Column<string>(type: "text", nullable: false),
                    ConsignataryAddress = table.Column<string>(type: "text", nullable: false),
                    ConsignataryPhoneNumber = table.Column<string>(type: "text", nullable: false),
                    ShipperName = table.Column<string>(type: "text", nullable: false),
                    ShipperSurname = table.Column<string>(type: "text", nullable: false),
                    ShipperAddress = table.Column<string>(type: "text", nullable: false),
                    ShipperPhoneNumber = table.Column<string>(type: "text", nullable: false),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LatestDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargo_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_TypeId",
                table: "Cargo",
                column: "TypeId");

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name", "CreatedDate", "LatestDate" },
                values: new object[] { 1, "Cam", DateTime.UtcNow, DateTime.UtcNow, });
            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name", "CreatedDate", "LatestDate" },
                values: new object[] { 2, "Metal", DateTime.UtcNow, DateTime.UtcNow, });
            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name", "CreatedDate", "LatestDate" },
                values: new object[] { 3, "Gıda", DateTime.UtcNow, DateTime.UtcNow, });
            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name", "CreatedDate", "LatestDate" },
                values: new object[] { 4, "Tekstil", DateTime.UtcNow, DateTime.UtcNow, });
            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "Name", "CreatedDate", "LatestDate" },
                values: new object[] { 5, "İlaç", DateTime.UtcNow, DateTime.UtcNow, });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
