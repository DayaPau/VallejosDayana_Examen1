using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VallejosDayana_Examen1.Migrations
{
    /// <inheritdoc />
    public partial class migracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DVallejos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estatura = table.Column<double>(type: "float", nullable: false),
                    EsSoltero = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DVallejos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    IdCelular = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Año = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.IdCelular);
                    table.ForeignKey(
                        name: "FK_Celular_DVallejos_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "DVallejos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Celular_IdUsuario",
                table: "Celular",
                column: "IdUsuario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Celular");

            migrationBuilder.DropTable(
                name: "DVallejos");
        }
    }
}
