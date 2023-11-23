using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectoef.Migrations
{
    /// <inheritdoc />
    public partial class FixingModel4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b897"),
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 22, 20, 48, 18, 280, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b898"),
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 22, 20, 48, 18, 280, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b899"),
                column: "FechaCreacion",
                value: new DateTime(2023, 11, 22, 20, 48, 18, 280, DateTimeKind.Utc).AddTicks(9258));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("6e2aae0d-c8ea-4ebb-a435-a3a6f037b899"),
                column: "FechaCreacion",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
