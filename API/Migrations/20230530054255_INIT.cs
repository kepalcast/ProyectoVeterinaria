using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class INIT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Raza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fechaCaducidad = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.idCliente);
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "idCliente", "Empresa", "Medicamento", "Name", "Precio", "Raza", "fechaCaducidad" },
                values: new object[,]
                {
                    { 1, "Pet-Max", "Albendazol", "Pelusa", 350.0, "Perro", new DateTime(2030, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Kron", "Metronidazol", "Michi", 500.0, "Gato", new DateTime(2028, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Boehringen", "Clenbuteroll", "Kimba", 700.0, "Vaca", new DateTime(2032, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");
        }
    }
}
