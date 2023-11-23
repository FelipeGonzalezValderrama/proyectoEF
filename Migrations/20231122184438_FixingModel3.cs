using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectoef.Migrations
{
    /// <inheritdoc />
    public partial class FixingModel3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Tarea",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b897"),
                column: "FechaCreacion",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b898"),
                column: "FechaCreacion",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[] { new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b899"), new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b850"), "Cotizacion proyecto web", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Tarea 3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b899"));

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaCreacion",
                table: "Tarea",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b897"),
                column: "FechaCreacion",
                value: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b898"),
                column: "FechaCreacion",
                value: new DateOnly(1, 1, 1));
        }
    }
}
