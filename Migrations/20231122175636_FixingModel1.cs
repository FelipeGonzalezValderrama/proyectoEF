using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectoef.Migrations
{
    /// <inheritdoc />
    public partial class FixingModel1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b850"),
                column: "Descripcion",
                value: "Actividades Cotidianas");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[] { new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b860"), "requerimientos Web", "Desarrollo Web", 20 });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b897"),
                column: "Descripcion",
                value: "Tarea rapida");

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[] { new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b898"), new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b860"), "Tarea Front", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Tarea 2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b898"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b860"));

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b850"),
                column: "Descripcion",
                value: "Descripción de la categoría");

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b897"),
                column: "Descripcion",
                value: "Descripción tarea");
        }
    }
}
