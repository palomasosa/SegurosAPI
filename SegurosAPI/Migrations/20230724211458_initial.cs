using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SegurosAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    clienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.clienteID);
                });

            migrationBuilder.CreateTable(
                name: "Coberturas",
                columns: table => new
                {
                    coberturaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coberturas", x => x.coberturaID);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    empresaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.empresaID);
                });

            migrationBuilder.CreateTable(
                name: "MetodoPagos",
                columns: table => new
                {
                    metodoPagoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    metodo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoPagos", x => x.metodoPagoID);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    usuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.usuarioID);
                });

            migrationBuilder.CreateTable(
                name: "Polizas",
                columns: table => new
                {
                    polizaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nroPoliza = table.Column<int>(type: "int", nullable: false),
                    valorAsegurado = table.Column<int>(type: "int", nullable: false),
                    inicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    finVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    valorCuota = table.Column<int>(type: "int", nullable: false),
                    empresaID = table.Column<int>(type: "int", nullable: false),
                    coberturaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polizas", x => x.polizaID);
                    table.ForeignKey(
                        name: "FK_Polizas_Coberturas_coberturaID",
                        column: x => x.coberturaID,
                        principalTable: "Coberturas",
                        principalColumn: "coberturaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Polizas_Empresas_empresaID",
                        column: x => x.empresaID,
                        principalTable: "Empresas",
                        principalColumn: "empresaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    pagoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    monto = table.Column<int>(type: "int", nullable: false),
                    polizaID = table.Column<int>(type: "int", nullable: false),
                    clienteID = table.Column<int>(type: "int", nullable: false),
                    usuarioID = table.Column<int>(type: "int", nullable: false),
                    metodoPagoID = table.Column<int>(type: "int", nullable: false),
                    metodoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.pagoID);
                    table.ForeignKey(
                        name: "FK_Pagos_Clientes_clienteID",
                        column: x => x.clienteID,
                        principalTable: "Clientes",
                        principalColumn: "clienteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_MetodoPagos_metodoPagoID",
                        column: x => x.metodoPagoID,
                        principalTable: "MetodoPagos",
                        principalColumn: "metodoPagoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_Polizas_polizaID",
                        column: x => x.polizaID,
                        principalTable: "Polizas",
                        principalColumn: "polizaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagos_Usuarios_usuarioID",
                        column: x => x.usuarioID,
                        principalTable: "Usuarios",
                        principalColumn: "usuarioID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    vehiculoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    año = table.Column<int>(type: "int", nullable: true),
                    patente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clienteID = table.Column<int>(type: "int", nullable: false),
                    polizaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.vehiculoID);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Clientes_clienteID",
                        column: x => x.clienteID,
                        principalTable: "Clientes",
                        principalColumn: "clienteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Polizas_polizaID",
                        column: x => x.polizaID,
                        principalTable: "Polizas",
                        principalColumn: "polizaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "clienteID_UQ",
                table: "Clientes",
                column: "clienteID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "coberturaID_UQ",
                table: "Coberturas",
                column: "coberturaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "empresaID_UQ",
                table: "Empresas",
                column: "empresaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "metodoPagoID_UQ",
                table: "MetodoPagos",
                column: "metodoPagoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_clienteID",
                table: "Pagos",
                column: "clienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_metodoPagoID",
                table: "Pagos",
                column: "metodoPagoID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_polizaID",
                table: "Pagos",
                column: "polizaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_usuarioID",
                table: "Pagos",
                column: "usuarioID");

            migrationBuilder.CreateIndex(
                name: "pagoID_UQ",
                table: "Pagos",
                column: "pagoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_coberturaID",
                table: "Polizas",
                column: "coberturaID");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_empresaID",
                table: "Polizas",
                column: "empresaID");

            migrationBuilder.CreateIndex(
                name: "polizaID_UQ",
                table: "Polizas",
                column: "polizaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "usuarioID_UQ",
                table: "Usuarios",
                column: "usuarioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_clienteID",
                table: "Vehiculos",
                column: "clienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_polizaID",
                table: "Vehiculos",
                column: "polizaID");

            migrationBuilder.CreateIndex(
                name: "vehiculoID_UQ",
                table: "Vehiculos",
                column: "vehiculoID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "MetodoPagos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Polizas");

            migrationBuilder.DropTable(
                name: "Coberturas");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
