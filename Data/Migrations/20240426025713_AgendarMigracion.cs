using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NebulaCars.Data.Migrations
{
    /// <inheritdoc />
    public partial class AgendarMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.CreateTable(
                name: "t_Citas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Telefono = table.Column<string>(type: "text", nullable: true),
                    Ciudad = table.Column<string>(type: "text", nullable: true),
                    TipoDocumento = table.Column<string>(type: "text", nullable: true),
                    NumeroDocumento = table.Column<string>(type: "text", nullable: true),
                    Marca = table.Column<string>(type: "text", nullable: true),
                    Modelo = table.Column<string>(type: "text", nullable: true),
                    Kilometraje = table.Column<int>(type: "integer", nullable: false),
                    Placa = table.Column<string>(type: "text", nullable: true),
                    Mensaje = table.Column<string>(type: "text", nullable: true),
                    FechaCita = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Hora = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_Citas", x => x.Id);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_Citas");
        }
    }
}
