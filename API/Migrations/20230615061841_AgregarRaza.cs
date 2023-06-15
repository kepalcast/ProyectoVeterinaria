using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AgregarRaza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Raza",
                table: "clientes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RazaID",
                table: "clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "raza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RazaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raza", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "idCliente",
                keyValue: 1,
                column: "RazaID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "idCliente",
                keyValue: 2,
                column: "RazaID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "idCliente",
                keyValue: 3,
                column: "RazaID",
                value: 0);

            migrationBuilder.InsertData(
                table: "raza",
                columns: new[] { "Id", "RazaName" },
                values: new object[,]
                {
                    { 1, "Perro" },
                    { 2, "Gato" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_RazaID",
                table: "clientes",
                column: "RazaID");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_raza_RazaID",
                table: "clientes",
                column: "RazaID",
                principalTable: "raza",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_raza_RazaID",
                table: "clientes");

            migrationBuilder.DropTable(
                name: "raza");

            migrationBuilder.DropIndex(
                name: "IX_clientes_RazaID",
                table: "clientes");

            migrationBuilder.DropColumn(
                name: "RazaID",
                table: "clientes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Raza",
                table: "clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "idCliente",
                keyValue: 1,
                column: "Raza",
                value: "Perro");

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "idCliente",
                keyValue: 2,
                column: "Raza",
                value: "Gato");

            migrationBuilder.UpdateData(
                table: "clientes",
                keyColumn: "idCliente",
                keyValue: 3,
                column: "Raza",
                value: "Vaca");
        }
    }
}
