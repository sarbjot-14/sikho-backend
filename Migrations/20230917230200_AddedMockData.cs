using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sikho_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedMockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "cost", "units", "year" },
                values: new object[] { null, null, 2020 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompanyId", "cost_source", "units", "units_source", "year" },
                values: new object[] { 2, "https://www.theverge.com/2022/6/23/23180156/cruise-driverless-vehicle-charge-riders-san-francisco", null, "https://www.theverge.com/2023/1/31/23579426/cruise-waymo-cpuc-trips-growth-robotaxi-sf ", 2021 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompanyId", "cost", "cost_source", "units", "units_source", "year" },
                values: new object[] { 2, 20.0, "https://www.theverge.com/2022/6/23/23180156/cruise-driverless-vehicle-charge-riders-san-francisco", 2783, "https://www.theverge.com/2023/1/31/23579426/cruise-waymo-cpuc-trips-growth-robotaxi-sf ", 2022 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "units", "units_source", "year" },
                values: new object[] { 3, "https://www.sec.gov/Archives/edgar/data/1830909/000147793223001263/sixdbytes_1k.html", 2020 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompanyId", "units", "units_source" },
                values: new object[] { 3, 3, "https://www.sec.gov/Archives/edgar/data/1830909/000164460023000042/BlendidARandFinancials2.pdf" });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompanyId", "units", "units_source" },
                values: new object[] { 3, 9, "https://www.startengine.com/offering/blendid " });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CompanyId", "cost", "cost_source", "units", "units_source", "year" },
                values: new object[] { 4, null, null, 2, "https://cafexapp.com/ ", 2021 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CompanyId", "cost", "cost_source", "units_source", "year" },
                values: new object[] { 4, null, null, "https://cafexapp.com/ ", 2022 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "cost", "cost_source", "units", "units_source", "year" },
                values: new object[] { 0.0, "https://www.startengine.com/offering/artly", 0, "https://www.businesswire.com/news/home/20220926005763/en/Artly-the-Friendly-Barista-Bot-is-Coming-to-a-Neighborhood-Near-You-Having-Closed-Its-Series-Pre-A-Investment", 2020 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CompanyId", "cost", "cost_source", "units", "units_source" },
                values: new object[] { 5, 10000.0, "https://www.startengine.com/offering/artly", 3, "https://www.businesswire.com/news/home/20220926005763/en/Artly-the-Friendly-Barista-Bot-is-Coming-to-a-Neighborhood-Near-You-Having-Closed-Its-Series-Pre-A-Investment " });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CompanyId", "cost", "cost_source", "units", "units_source" },
                values: new object[] { 5, 101000.0, "https://www.startengine.com/offering/artly ", 9, "https://www.startengine.com/offering/artly" });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CompanyId", "cost_source", "units", "units_source", "year" },
                values: new object[] { 6, "https://www.startengine.com/offering/artly ", null, "https://www.makrshakr.com/locations ", 2020 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CompanyId", "cost", "cost_source", "units", "units_source", "year" },
                values: new object[] { 6, 101000.0, "https://www.startengine.com/offering/artly ", 12, "https://www.makrshakr.com/locations ", 2021 });

            migrationBuilder.InsertData(
                table: "DataPoints",
                columns: new[] { "Id", "CompanyId", "cost", "cost_source", "units", "units_source", "year" },
                values: new object[,]
                {
                    { 17, 6, null, null, 14, "https://www.makrshakr.com/locations ", 2022 },
                    { 18, 7, null, null, 1, "https://www.tastetoronto.com/news/torontos-robo-cafe-opens-second-location-in-kensington-market", 2021 },
                    { 19, 7, null, null, 10, "https://www.tastetoronto.com/news/torontos-robo-cafe-opens-second-location-in-kensington-market", 2022 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "cost", "units", "year" },
                values: new object[] { 20.0, 2783, 2022 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CompanyId", "cost_source", "units", "units_source", "year" },
                values: new object[] { 3, null, 3, "https://www.sec.gov/Archives/edgar/data/1830909/000147793223001263/sixdbytes_1k.html", 2020 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CompanyId", "cost", "cost_source", "units", "units_source", "year" },
                values: new object[] { 3, null, null, 3, "https://www.sec.gov/Archives/edgar/data/1830909/000164460023000042/BlendidARandFinancials2.pdf", 2021 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "units", "units_source", "year" },
                values: new object[] { 9, "https://www.startengine.com/offering/blendid ", 2022 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CompanyId", "units", "units_source" },
                values: new object[] { 4, 2, "https://cafexapp.com/ " });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CompanyId", "units", "units_source" },
                values: new object[] { 4, 3, "https://cafexapp.com/ " });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CompanyId", "cost", "cost_source", "units", "units_source", "year" },
                values: new object[] { 5, 0.0, "https://www.startengine.com/offering/artly", 0, "https://www.businesswire.com/news/home/20220926005763/en/Artly-the-Friendly-Barista-Bot-is-Coming-to-a-Neighborhood-Near-You-Having-Closed-Its-Series-Pre-A-Investment", 2020 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CompanyId", "cost", "cost_source", "units_source", "year" },
                values: new object[] { 5, 10000.0, "https://www.startengine.com/offering/artly", "https://www.businesswire.com/news/home/20220926005763/en/Artly-the-Friendly-Barista-Bot-is-Coming-to-a-Neighborhood-Near-You-Having-Closed-Its-Series-Pre-A-Investment ", 2021 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "cost", "cost_source", "units", "units_source", "year" },
                values: new object[] { 101000.0, "https://www.startengine.com/offering/artly ", 9, "https://www.startengine.com/offering/artly", 2022 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CompanyId", "cost", "cost_source", "units", "units_source" },
                values: new object[] { 6, 101000.0, "https://www.startengine.com/offering/artly ", 12, "https://www.makrshakr.com/locations " });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CompanyId", "cost", "cost_source", "units", "units_source" },
                values: new object[] { 6, null, null, 14, "https://www.makrshakr.com/locations " });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CompanyId", "cost_source", "units", "units_source", "year" },
                values: new object[] { 7, null, 1, "https://www.tastetoronto.com/news/torontos-robo-cafe-opens-second-location-in-kensington-market", 2021 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CompanyId", "cost", "cost_source", "units", "units_source", "year" },
                values: new object[] { 7, null, null, 10, "https://www.tastetoronto.com/news/torontos-robo-cafe-opens-second-location-in-kensington-market", 2022 });
        }
    }
}
