﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SegurosAPI.Models;

#nullable disable

namespace SegurosAPI.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230725135404_updateDecimals")]
    partial class updateDecimals
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SegurosAPI.Models.Cliente", b =>
                {
                    b.Property<int>("clienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("clienteID"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("clienteID");

                    b.HasIndex(new[] { "clienteID" }, "clienteID_UQ")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("SegurosAPI.Models.Cobertura", b =>
                {
                    b.Property<int>("coberturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("coberturaID"));

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("coberturaID");

                    b.HasIndex(new[] { "coberturaID" }, "coberturaID_UQ")
                        .IsUnique();

                    b.ToTable("Coberturas");
                });

            modelBuilder.Entity("SegurosAPI.Models.Empresa", b =>
                {
                    b.Property<int>("empresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("empresaID"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("empresaID");

                    b.HasIndex(new[] { "empresaID" }, "empresaID_UQ")
                        .IsUnique();

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("SegurosAPI.Models.MetodoPago", b =>
                {
                    b.Property<int>("metodoPagoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("metodoPagoID"));

                    b.Property<string>("metodo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("metodoPagoID");

                    b.HasIndex(new[] { "metodoPagoID" }, "metodoPagoID_UQ")
                        .IsUnique();

                    b.ToTable("MetodoPagos");
                });

            modelBuilder.Entity("SegurosAPI.Models.Pagos", b =>
                {
                    b.Property<int>("pagoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pagoID"));

                    b.Property<int>("clienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("metodoID")
                        .HasColumnType("int");

                    b.Property<int>("metodoPagoID")
                        .HasColumnType("int");

                    b.Property<decimal>("monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("polizaID")
                        .HasColumnType("int");

                    b.Property<int>("usuarioID")
                        .HasColumnType("int");

                    b.HasKey("pagoID");

                    b.HasIndex("clienteID");

                    b.HasIndex("metodoPagoID");

                    b.HasIndex("polizaID");

                    b.HasIndex("usuarioID");

                    b.HasIndex(new[] { "pagoID" }, "pagoID_UQ")
                        .IsUnique();

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("SegurosAPI.Models.Poliza", b =>
                {
                    b.Property<int>("polizaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("polizaID"));

                    b.Property<int>("coberturaID")
                        .HasColumnType("int");

                    b.Property<int>("empresaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("finVigencia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("inicioVigencia")
                        .HasColumnType("datetime2");

                    b.Property<int>("nroPoliza")
                        .HasColumnType("int");

                    b.Property<decimal>("valorAsegurado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("valorCuota")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("polizaID");

                    b.HasIndex("coberturaID");

                    b.HasIndex("empresaID");

                    b.HasIndex(new[] { "polizaID" }, "polizaID_UQ")
                        .IsUnique();

                    b.ToTable("Polizas");
                });

            modelBuilder.Entity("SegurosAPI.Models.Usuario", b =>
                {
                    b.Property<int>("usuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("usuarioID"));

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("usuarioID");

                    b.HasIndex(new[] { "usuarioID" }, "usuarioID_UQ")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SegurosAPI.Models.Vehiculo", b =>
                {
                    b.Property<int>("vehiculoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("vehiculoID"));

                    b.Property<int?>("año")
                        .HasColumnType("int");

                    b.Property<int>("clienteID")
                        .HasColumnType("int");

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("polizaID")
                        .HasColumnType("int");

                    b.HasKey("vehiculoID");

                    b.HasIndex("clienteID");

                    b.HasIndex("polizaID");

                    b.HasIndex(new[] { "vehiculoID" }, "vehiculoID_UQ")
                        .IsUnique();

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("SegurosAPI.Models.Pagos", b =>
                {
                    b.HasOne("SegurosAPI.Models.Cliente", "Cliente")
                        .WithMany("Pagos")
                        .HasForeignKey("clienteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SegurosAPI.Models.MetodoPago", "MetodoPago")
                        .WithMany("Pagos")
                        .HasForeignKey("metodoPagoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SegurosAPI.Models.Poliza", "Poliza")
                        .WithMany("Pagos")
                        .HasForeignKey("polizaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SegurosAPI.Models.Usuario", "Usuario")
                        .WithMany("Pagos")
                        .HasForeignKey("usuarioID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("MetodoPago");

                    b.Navigation("Poliza");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("SegurosAPI.Models.Poliza", b =>
                {
                    b.HasOne("SegurosAPI.Models.Cobertura", null)
                        .WithMany("Polizas")
                        .HasForeignKey("coberturaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SegurosAPI.Models.Empresa", null)
                        .WithMany("Polizas")
                        .HasForeignKey("empresaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("SegurosAPI.Models.Vehiculo", b =>
                {
                    b.HasOne("SegurosAPI.Models.Cliente", "Cliente")
                        .WithMany("Vehiculos")
                        .HasForeignKey("clienteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SegurosAPI.Models.Poliza", "Poliza")
                        .WithMany("Vehiculos")
                        .HasForeignKey("polizaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Poliza");
                });

            modelBuilder.Entity("SegurosAPI.Models.Cliente", b =>
                {
                    b.Navigation("Pagos");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("SegurosAPI.Models.Cobertura", b =>
                {
                    b.Navigation("Polizas");
                });

            modelBuilder.Entity("SegurosAPI.Models.Empresa", b =>
                {
                    b.Navigation("Polizas");
                });

            modelBuilder.Entity("SegurosAPI.Models.MetodoPago", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("SegurosAPI.Models.Poliza", b =>
                {
                    b.Navigation("Pagos");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("SegurosAPI.Models.Usuario", b =>
                {
                    b.Navigation("Pagos");
                });
#pragma warning restore 612, 618
        }
    }
}
