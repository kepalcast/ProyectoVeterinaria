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
                    AñodeCaducidad = 2028,
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
                    AñodeCaducidad = 2030,
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
                    AñodeCaducidad = 2032,
                    RazaId = 1
                },
                new Cliente()
                {
                    idCliente = 4,
                    Name = "Bethoveen",
                    Pesokg = 12.2,
                    Medicamento = "Nicilan",
                    Precio = 450,
                    Empresa = "Calier",
                    AñodeCaducidad = 2032,
                    RazaId = 1
                },
                new Cliente()
                {
                    idCliente = 5,
                    Name = "Kira",
                    Pesokg = 20.9,
                    Medicamento = "Gycoflex",
                    Precio = 500,
                    Empresa = "Invet",
                    AñodeCaducidad = 2030,
                    RazaId = 1
                },
                new Cliente()
                {
                    idCliente = 6,
                    Name = "KuroNeko",
                    Pesokg = 10.8,
                    Medicamento = "Apoquel",
                    Precio = 1200,
                    Empresa = "Zoetis",
                    AñodeCaducidad = 2025,
                    RazaId = 2
                },
                new Cliente()
                {
                    idCliente = 7,
                    Name = "Gatito",
                    Pesokg = 6.6,
                    Medicamento = "Hepatoforz",
                    Precio = 3000,
                    Empresa = "Nutraforz",
                    AñodeCaducidad = 2030,
                    RazaId = 2
                });
        }
    }
}
