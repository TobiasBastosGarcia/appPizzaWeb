using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoPizzaMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Pizza",
                type: "int",
                nullable: true);
                

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_MarcaId",
                table: "Pizza",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Marca_MarcaId",
                table: "Pizza",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Marca_MarcaId",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_MarcaId",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Pizza");
        }
    }
}
