using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {

        }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Raza> raza { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Raza>().HasData(
                new Raza()
                {
                    Id = 1,
                    RazaName = "Perro"
                },
                new Raza()
                {
                    Id = 2,
                    RazaName = "Gato"
                });
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente()
                {
                    idCliente = 1,
                    Name = "Pelusa",
                    Pesokg = 27.5,
                    Medicamento = "Albendazol",
                    Precio = 350,
                    Empresa = "Pet-Max",
                    fechaCaducidad = new DateTime(2030, 05, 29),
                    RazaId = 2

                },
                new Cliente()
                {
                    idCliente = 2,
                    Name = "Michi",
                    Pesokg = 4.8,
                    Medicamento = "Metronidazol",
                    Precio = 500,
                    Empresa = "Kron",
                    fechaCaducidad = new DateTime(2028, 10, 30),
                    RazaId = 2
                },
                new Cliente()
                {
                    idCliente = 3,
                    Name = "Kimba",
                    Pesokg = 31.2,
                    Medicamento = "Clenbuteroll",
                    Precio = 700,
                    Empresa = "Boehringen",
                    fechaCaducidad = new DateTime(2032, 02, 21),
                    RazaId = 1
                });
        }
    }
}
