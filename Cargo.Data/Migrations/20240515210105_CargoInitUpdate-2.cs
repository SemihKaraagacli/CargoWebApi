using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cargo.Data.Migrations
{
    /// <inheritdoc />
    public partial class CargoInitUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargo_Types_TypeId",
                table: "Cargo");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Cargo",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeName",
                table: "Cargo",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargo_Types_TypeId",
                table: "Cargo",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargo_Types_TypeId",
                table: "Cargo");

            migrationBuilder.DropColumn(
                name: "TypeName",
                table: "Cargo");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Cargo",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargo_Types_TypeId",
                table: "Cargo",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id");
        }
    }
}
