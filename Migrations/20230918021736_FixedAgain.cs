using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sikho_backend.Migrations
{
    /// <inheritdoc />
    public partial class FixedAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "units", "units_source" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 21,
                column: "units",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "units", "units_source" },
                values: new object[] { 10, "https://www.tastetoronto.com/news/torontos-robo-cafe-opens-second-location-in-kensington-market" });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 21,
                column: "units",
                value: 2);
        }
    }
}
