using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cargo.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargoInitUpdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargo_Types_TypeId",
                table: "Cargo");

            migrationBuilder.DropIndex(
                name: "IX_Cargo_TypeId",
                table: "Cargo");

            migrationBuilder.DropColumn(
                name: "TypeName",
                table: "Cargo");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoEntityTypes");

            migrationBuilder.AddColumn<string>(
                name: "TypeName",
                table: "Cargo",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_TypeId",
                table: "Cargo",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargo_Types_TypeId",
                table: "Cargo",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
