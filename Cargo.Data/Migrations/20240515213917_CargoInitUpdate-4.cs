using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cargo.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargoInitUpdate4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoEntityTypes");

            migrationBuilder.AddColumn<int>(
                name: "CargoEntityId",
                table: "Types",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Types_CargoEntityId",
                table: "Types",
                column: "CargoEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Types_Cargo_CargoEntityId",
                table: "Types",
                column: "CargoEntityId",
                principalTable: "Cargo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Types_Cargo_CargoEntityId",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Types_CargoEntityId",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "CargoEntityId",
                table: "Types");

            migrationBuilder.CreateTable(
                name: "CargoEntityTypes",
                columns: table => new
                {
                    CargosId = table.Column<int>(type: "integer", nullable: false),
                    TypesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoEntityTypes", x => new { x.CargosId, x.TypesId });
                    table.ForeignKey(
                        name: "FK_CargoEntityTypes_Cargo_CargosId",
                        column: x => x.CargosId,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CargoEntityTypes_Types_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoEntityTypes_TypesId",
                table: "CargoEntityTypes",
                column: "TypesId");
        }
    }
}
