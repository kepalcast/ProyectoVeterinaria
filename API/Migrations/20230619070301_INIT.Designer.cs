﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(ClienteContext))]
    [Migration("20230619070301_INIT")]
    partial class INIT
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Models.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCliente"));

                    b.Property<int>("AñodeCaducidad")
                        .HasColumnType("int");

                    b.Property<string>("Empresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Pesokg")
                        .HasColumnType("float");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("RazaId")
                        .HasColumnType("int");

                    b.HasKey("idCliente");

                    b.HasIndex("RazaId");

                    b.ToTable("clientes");

                    b.HasData(
                        new
                        {
                            idCliente = 1,
                            AñodeCaducidad = 2028,
                            Empresa = "Pet-Max",
                            Medicamento = "Albendazol",
                            Name = "Pelusa",
                            Pesokg = 27.5,
                            Precio = 350.0,
                            RazaId = 2
                        },
                        new
                        {
                            idCliente = 2,
                            AñodeCaducidad = 2030,
                            Empresa = "Kron",
                            Medicamento = "Metronidazol",
                            Name = "Michi",
                            Pesokg = 4.7999999999999998,
                            Precio = 500.0,
                            RazaId = 2
                        },
                        new
                        {
                            idCliente = 3,
                            AñodeCaducidad = 2032,
                            Empresa = "Boehringen",
                            Medicamento = "Clenbuteroll",
                            Name = "Kimba",
                            Pesokg = 31.199999999999999,
                            Precio = 700.0,
                            RazaId = 1
                        });
                });

            modelBuilder.Entity("API.Models.Raza", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("RazaName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("raza");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RazaName = "Perro"
                        },
                        new
                        {
                            Id = 2,
                            RazaName = "Gato"
                        });
                });

            modelBuilder.Entity("API.Models.Cliente", b =>
                {
                    b.HasOne("API.Models.Raza", "Raza")
                        .WithMany()
                        .HasForeignKey("RazaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Raza");
                });
#pragma warning restore 612, 618
        }
    }
}