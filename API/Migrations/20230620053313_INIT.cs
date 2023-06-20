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

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pesokg = table.Column<double>(type: "float", nullable: false),
                    Medicamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AñodeCaducidad = table.Column<int>(type: "int", nullable: false),
                    RazaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.idCliente);
                    table.ForeignKey(
                        name: "FK_clientes_raza_RazaId",
                        column: x => x.RazaId,
                        principalTable: "raza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "raza",
                columns: new[] { "Id", "RazaName" },
                values: new object[,]
                {
                    { 1, "Perro" },
                    { 2, "Gato" }
                });

            migrationBuilder.InsertData(
                table: "clientes",
                columns: new[] { "idCliente", "AñodeCaducidad", "Empresa", "Medicamento", "Name", "Pesokg", "Precio", "RazaId" },
                values: new object[,]
                {
                    { 1, 2028, "Pet-Max", "Albendazol", "Pelusa", 27.5, 350.0, 2 },
                    { 2, 2030, "Kron", "Metronidazol", "Michi", 4.7999999999999998, 500.0, 2 },
                    { 3, 2032, "Boehringen", "Clenbuteroll", "Kimba", 31.199999999999999, 700.0, 1 },
                    { 4, 2032, "Calier", "Nicilan", "Bethoveen", 12.199999999999999, 450.0, 1 },
                    { 5, 2030, "Invet", "Gycoflex", "Kira", 20.899999999999999, 500.0, 1 },
                    { 6, 2025, "Zoetis", "Apoquel", "KuroNeko", 10.800000000000001, 1200.0, 2 },
                    { 7, 2030, "Nutraforz", "Hepatoforz", "Gatito", 6.5999999999999996, 3000.0, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_RazaId",
                table: "clientes",
                column: "RazaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "raza");
        }
    }
}
