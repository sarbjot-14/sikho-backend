using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sikho_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddIndustryRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "at_risk",
                table: "Occupations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "industry",
                table: "Occupations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Word processors and typists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Watch and clock repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Roof bolters, mining" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cutters and trimmers, hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Telephone operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Data entry keyers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Switchboard operators, including answering service" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Foundry mold and coremakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Legal secretaries and administrative assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Pressers, textile, garment, and related materials" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Patternmakers, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Refractory materials repairers, except brickmasons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Executive secretaries and executive administrative assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Manufactured building and mobile home installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Telemarketers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Grinding and polishing workers, hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Engine and other machine assemblers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Model makers, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Timing device assemblers and adjusters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Drilling and boring machine tool setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Order clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Floral designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Electronic equipment installers and repairers, motor vehicles" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Loading and moving machine operators, underground mining" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Prepress technicians and workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Coil winders, tapers, and finishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Payroll and timekeeping clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Structural metal fabricators and fitters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Print binding and finishing workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "File clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Door-to-door sales workers, news and street vendors, and related workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sewers, hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sewing machine operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Aircraft structure, surfaces, rigging, and systems assemblers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Forging machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tellers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "New accounts clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Office machine operators, except computer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Milling and planing machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cooks, fast food" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tailors, dressmakers, and custom sewers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Desktop publishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Adult basic education, adult secondary education, and english as a second language instructors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Power plant operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Photographic process workers and processing machine operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Underground mining machine operators, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Meter readers, utilities" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Terrazzo workers and finishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Gas plant operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Secretaries and administrative assistants, except legal, medical, and executive" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Broadcast announcers and radio disc jockeys" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Postal service mail sorters, processors, and processing machine operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "0", "1", "Computer programmers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Carpet installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Locksmiths and safe repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Paper goods machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Rolling machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Shoe and leather workers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cutting, punching, and press machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Helpers--brickmasons, blockmasons, stonemasons, and tile and marble setters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Shoe machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer, automated teller, and office machine repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Textile cutting machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Textile knitting and weaving machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cashiers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Layout workers, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Interviewers, except eligibility and loan" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Bill and account collectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Motion picture projectionists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Grinding, lapping, polishing, and buffing machine tool setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Textile bleaching and dyeing machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Plating machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Lathe and turning machine tool setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Musical instrument repairers and tuners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fallers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Helpers--production workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Heat treating equipment setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Pourers and casters, metal" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Brokerage clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Forest and conservation workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Textile winding, twisting, and drawing out machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Printing press operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tool and die makers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tool grinders, filers, and sharpeners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Shipping, receiving, and inventory clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Welding, soldering, and brazing machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Office and administrative support workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Chief executives" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Metal-refining furnace operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer numerically controlled tool operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Metal workers and plastic workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Drafters, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Textile, apparel, and furnishings workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Procurement clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Correctional officers and jailers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fabric and apparel patternmakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Advertising sales agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mechanical drafters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Logging workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of retail sales workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Postal service mail carriers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Postal service clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Postmasters and mail superintendents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Office clerks, general" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Audiovisual equipment installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Water and wastewater treatment plant and system operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fish and game wardens" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Bookkeeping, accounting, and auditing clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cooks, short order" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Library technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Stonemasons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Correspondence clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Library assistants, clerical" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Credit authorizers, checkers, and clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Gambling change persons and booth cashiers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Customer service representatives" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Chemical equipment operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cooks, private household" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Gambling cage workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Farmworkers, farm, ranch, and aquacultural animals" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Helpers--carpenters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of office and administrative support workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Graders and sorters, agricultural products" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Patternmakers, wood" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Power distributors and dispatchers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Human resources assistants, except payroll and timekeeping" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Food preparation workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mail clerks and mail machine operators, except postal service" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Farmers, ranchers, and other agricultural managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dental laboratory technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Pipelayers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Credit analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Home appliance repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tire builders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cutting and slicing machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cement masons and concrete finishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Editors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Boilermakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Gambling and sports book writers and runners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Inspectors, testers, sorters, samplers, and weighers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of security workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Proofreaders and copy markers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Medical transcriptionists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Excavating and loading machine and dragline operators, surface mining" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Logging equipment operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Survey researchers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Molding, coremaking, and casting machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "School bus monitors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Woodworkers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Model makers, wood" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Helpers--electricians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Crushing, grinding, and polishing machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Lighting technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "News analysts, reporters, and journalists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Nuclear power reactor operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Insurance claims and policy processing clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Chemical plant and system operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Continuous mining machine operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Waiters and waitresses" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Claims adjusters, examiners, and investigators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Education and childcare administrators, preschool and daycare" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Jewelers and precious stone and metal workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cost estimators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Weighers, measurers, checkers, and samplers, recordkeeping" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Pharmacy aides" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of correctional officers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Electrical and electronics repairers, powerhouse, substation, and relay" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "0", "1", "Electro-mechanical and mechatronics technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Hotel, motel, and resort desk clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Insurance appraisers, auto damage" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Upholsterers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Insurance underwriters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dishwashers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Petroleum pump system operators, refinery operators, and gaugers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Bailiffs" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Extruding and forming machine setters, operators, and tenders, synthetic and glass fibers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tapers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Farmworkers and laborers, crop, nursery, and greenhouse" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of non-retail sales workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Wellhead pumpers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Adhesive bonding machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Retail salespersons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Gas compressor and gas pumping station operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Childcare workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Farm and home management educators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cabinetmakers and bench carpenters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Extruding and drawing machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Extraction workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Hoist and winch operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Coin, vending, and amusement machine servicers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Statistical assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Log graders and scalers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Construction and building inspectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Parking enforcement workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Security guards" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Laundry and dry-cleaning workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Extruding, forming, pressing, and compacting machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Nuclear technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Butchers and meat cutters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sound engineering technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dispatchers, except police, fire, and ambulance" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Broadcast technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Packers and packagers, hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Loan interviewers and clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Slaughterers and meat packers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Woodworking machine setters, operators, and tenders, except sawing" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Labor relations specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Bridge and lock tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "0", "1", "Electrical and electronics repairers, commercial and industrial equipment" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fence erectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Furniture finishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Control and valve installers and repairers, except mechanical door" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Career/technical education teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fishing and hunting workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fiberglass laminators and fabricators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Directors, religious activities and education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Career/technical education teachers, secondary school" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Special education teachers, middle school" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Etchers and engravers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Plant and system operators, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sheet metal workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Career/technical education teachers, middle school" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Precision instrument and equipment repairers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Transportation security screeners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Billing and posting clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Floor sanders and finishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Painting, coating, and decorating workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Rotary drill operators, oil and gas" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sawing machine setters, operators, and tenders, wood" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Service unit operators, oil and gas" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Maids and housekeeping cleaners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Ambulance drivers and attendants, except emergency medical technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Crane and tower operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Legal support workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Automotive and watercraft service attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dredge operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mining and geological engineers, including mining safety engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of production and operating workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Hydrologic technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Furnace, kiln, oven, drier, and kettle operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Nuclear medicine technologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Receptionists and information clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Models" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Derrick operators, oil and gas" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Brickmasons and blockmasons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Kindergarten teachers, except special education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Special education teachers, secondary school" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Food service managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Hosts and hostesses, restaurant, lounge, and coffee shop" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Gambling surveillance officers and gambling investigators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Forest and conservation technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "0", "1", "Mechanical engineering technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tax examiners and collectors, and revenue agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Religious workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Architectural and civil drafters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Multiple machine tool setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Coating, painting, and spraying machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Clergy" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Marine engineers and naval architects" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Landscape architects" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sales representatives, wholesale and manufacturing, except technical and scientific products" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Elementary school teachers, except special education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Gambling service workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Helpers--extraction workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Locomotive engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Surgeons, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Hazardous materials removal workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "0", "1", "Electrical and electronic engineering technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Middle school teachers, except special and career/technical education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Embalmers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Electrical and electronics drafters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "-1", "Pediatricians, general" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Civil engineering technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Bus and truck mechanics and diesel engine specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Carpenters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "-1", "Pediatric surgeons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "-1", "Podiatrists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Gambling dealers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Parts salespersons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Secondary school teachers, except special and career/technical education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Camera and photographic equipment repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Geographers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Administrative law judges, adjudicators, and hearing officers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Explosives workers, ordnance handling experts, and blasters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Nuclear engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Ophthalmic laboratory technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Railroad conductors and yardmasters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Financial clerks, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Music directors and composers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tire repairers and changers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Education administrators, kindergarten through secondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Railroad brake, signal, and switch operators and locomotive firers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Signal and track switch repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Reinforcing iron and rebar workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Outdoor power equipment and other small engine mechanics" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "English language and literature teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Automotive body and related repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Musicians and singers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Ship engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Environmental engineering technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "History teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "School psychologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Reservation and transportation ticket agents and travel clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Janitors and cleaners, except maids and housekeeping cleaners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Rail-track laying and maintenance equipment operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Air traffic controllers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Foreign language and literature teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Riggers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Bus drivers, school" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Welders, cutters, solderers, and brazers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Helpers--painters, paperhangers, plasterers, and stucco masons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Hydrologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Elevator and escalator installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Parking attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tax preparers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Detectives and criminal investigators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mixing and blending machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Installation, maintenance, and repair workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Painters, construction and maintenance" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fast food and counter workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tank car, truck, and ship loaders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Orthopedic surgeons, except pediatric" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Food cooking machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Helpers, construction trades, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Ushers, lobby attendants, and ticket takers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Drywall and ceiling tile installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Couriers and messengers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Industrial production managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Automotive service technicians and mechanics" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Automotive glass installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Insulation workers, mechanical" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Insulation workers, floor, ceiling, and wall" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Social scientists and related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Captains, mates, and pilots of water vessels" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Title examiners, abstractors, and searchers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Agricultural workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Motorcycle mechanics" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Structural iron and steel workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Rock splitters, quarry" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Special education teachers, preschool" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Advertising and promotions managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Rehabilitation counselors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Teachers and instructors, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Machinists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Helpers--roofers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Agricultural inspectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Pesticide handlers, sprayers, and applicators, vegetation" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sailors and marine oilers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Commercial and industrial designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Healthcare diagnosing or treating practitioners, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Meat, poultry, and fish cutters and trimmers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Roofers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Animal breeders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Plasterers and stucco masons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cooks, institution and cafeteria" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mathematicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Rail transportation workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Compensation and benefits managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Earth drillers, except oil and gas" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Grounds maintenance workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Obstetricians and gynecologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Judges, magistrate judges, and magistrates" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Funeral home managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Glaziers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Eligibility interviewers, government programs" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Judicial law clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Helpers--pipelayers, plumbers, pipefitters, and steamfitters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Educational instruction and library workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Plumbers, pipefitters, and steamfitters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Rail yard engineers, dinkey operators, and hostlers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Foresters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Radiation therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Molders, shapers, and casters, except metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Merchandise displayers and window trimmers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of mechanics, installers, and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Building cleaning workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Electric motor, power tool, and related repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Medical appliance technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Petroleum engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tree trimmers and pruners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "General internal medicine physicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Helpers--installation, maintenance, and repair workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Probation officers and correctional treatment specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Instructional coordinators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Network and computer systems administrators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of construction trades and extraction workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Gambling managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Social sciences teachers, postsecondary, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Anesthesiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of landscaping, lawn service, and groundskeeping workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Pharmacists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dentists, all other specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Criminal justice and law enforcement teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Transportation inspectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Philosophy and religion teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of farming, fishing, and forestry workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Opticians, dispensing" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Information and record clerks, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Counter and rental clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Operating engineers and other construction equipment operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Court reporters and simultaneous captioners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Emergency medicine physicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Funeral attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Camera operators, television, video, and film" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Stationary engineers and boiler operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Security and fire alarm systems installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Electrical power-line installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Motorboat operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Roustabouts, oil and gas" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Special education teachers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Loan officers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Law teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Zoologists and wildlife biologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Food and tobacco roasting, baking, and drying machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Millwrights" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Physical therapist aides" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Protective service workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Librarians and media collections specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Court, municipal, and license clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of housekeeping and janitorial workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Physicians, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Historians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Geological technicians, except hydrologic technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dermatologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cardiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Designers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Engineering technologists and technicians, except drafters, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Pest control workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of police and detectives" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Food servers, nonrestaurant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Pile driver operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Transit and railroad police" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Neurologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cooks, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of gambling services workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mathematical science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Chemical technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Industrial engineering technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Actors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Art, drama, and music teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Refuse and recyclable material collectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Self-enrichment teachers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Real estate sales agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Emergency management directors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Recreation and fitness studies teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fashion designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Budget analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Surveying and mapping technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "0", "1", "Engineers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tutors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Graphic designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Bartenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Police and sheriff's patrol officers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Managers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Medical dosimetrists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Artists and related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Radio, cellular, and tower equipment installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Media and communication equipment workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of protective service workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Communications teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Legislators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Separating, filtering, clarifying, precipitating, and still machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Public safety telecommunicators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Preschool teachers, except special education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Subway and streetcar operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Traffic technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dietetic technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Chemistry teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Material moving workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Travel agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Real estate brokers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer network architects" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Education administrators, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Landscaping and groundskeeping workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Pump operators, except wellhead pumpers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Atmospheric, earth, marine, and space sciences teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Ophthalmologists, except pediatric" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Recreational therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Rail car repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Radiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of firefighting and prevention workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Postsecondary teachers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Firefighters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Maintenance and repair workers, general" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Paperhangers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fire inspectors and investigators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sociology teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Political science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Health and safety engineers, except mining safety engineers and inspectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Morticians, undertakers, and funeral arrangers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Paving, surfacing, and tamping equipment operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Urban and regional planners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cardiovascular technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Education teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Family medicine physicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Writers and authors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sales representatives, wholesale and manufacturing, technical and scientific products" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cleaners of vehicles and equipment" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Industrial truck and tractor operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Architecture teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Bicycle repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cleaning, washing, and metal pickling equipment operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Economics teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Physics teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Life, physical, and social science technicians, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Crematory operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Family and consumer sciences teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Craft artists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Area, ethnic, and cultural studies teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Transportation workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Food processing workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Biological scientists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Airline pilots, copilots, and flight engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Interior designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Anthropology and archeology teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Animal control workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Social work teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Demonstrators and product promoters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Commercial pilots" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sales managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Library science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Passenger attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Conservation scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Crossing guards and flaggers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Photographers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Architectural and engineering managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Substitute teachers, short-term" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sales representatives of services, except advertising, insurance, financial services, and travel" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Business operations specialists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Nursing assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Heavy and tractor-trailer truck drivers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Anthropologists and archeologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Environmental science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Disc jockeys, except radio" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Orderlies" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Teaching assistants, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Electrical engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Amusement and recreation attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Paralegals and legal assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Production, planning, and expediting clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dining room and cafeteria attendants and bartender helpers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "General and operations managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Avionics technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Personal service managers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Media and communication workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Interpreters and translators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Food preparation and serving related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Aircraft mechanics and service technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Geography teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Atmospheric and space scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Calibration technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Purchasing managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dentists, general" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Construction laborers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Accountants and auditors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sociologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Orthodontists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Agricultural technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sales and related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Construction managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Astronomers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Physicians, pathologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Surveyors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer hardware engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Facilities managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Recreation workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Compliance officers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Packaging and filling machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Soil and plant scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Aircraft service attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Physicists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Sales engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Audio and video technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Biological technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Electrical and electronics installers and repairers, transportation equipment" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Agricultural sciences teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Social science research assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Natural sciences managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Architects, except landscape and naval" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Occupational therapy aides" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Airfield operations specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Psychiatric aides" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Bakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of food preparation and serving workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Oral and maxillofacial surgeons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Choreographers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Costume attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Arbitrators, mediators, and conciliators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cartographers and photogrammetrists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Civil engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer user support specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cooling and freezing equipment operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Materials scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Bioengineers and biomedical engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Materials engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Geoscientists, except hydrologists and geographers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fundraising managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Psychologists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mobile heavy equipment mechanics, except engines" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Forestry and conservation science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Life scientists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Surgical assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Food science technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Microbiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fine artists, including painters, sculptors, and illustrators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Healthcare practitioners and technical workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Psychology teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Fundraisers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Human resources managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dancers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Acupuncturists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Chefs and head cooks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Child, family, and school social workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Licensed practical and licensed vocational nurses" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Laborers and freight, stock, and material movers, hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Entertainment attendants and related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Credit counselors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Medical equipment preparers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Paramedics" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Surgical technologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Bus drivers, transit and intercity" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Emergency medical technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Educational, guidance, and career counselors and advisors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Property, real estate, and community association managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Machine feeders and offbearers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Maintenance workers, machinery" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Radiologic technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Heating, air conditioning, and refrigeration mechanics and installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Concierges" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Administrative services managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Pharmacy technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Registered nurses" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Prosthodontists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Animal scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Motorboat mechanics and service technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Healthcare support workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Conveyor operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Environmental science and protection technicians, including health" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Communications equipment operators, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Industrial-organizational psychologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Public relations managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Human resources specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Commercial divers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Residential advisors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Private detectives and investigators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Environmental engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Aerospace engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Environmental scientists and specialists, including health" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Art directors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Financial specialists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Public relations specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mathematical science occupations, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Chemists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Lifeguards, ski patrol, and other recreational protective service workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "0", "1", "Project management specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Agricultural engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Economists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Baggage porters and bellhops" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Telecommunications equipment installers and repairers, except line installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Training and development specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Stockers and order fillers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Nurse midwives" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Electricians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Training and development managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Community and social service specialists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Political scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Social workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dietitians and nutritionists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Health technologists and technicians, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Marketing managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Psychiatrists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Biochemists and biophysicists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Lodging managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Telecommunications line installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Producers and directors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Medical secretaries and administrative assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Technical writers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Tile and stone setters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Business teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dental assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Locker room, coatroom, and dressing room attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Barbers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Database administrators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Compensation, benefits, and job analysis specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer network support specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Health education specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Electronics engineers, except computer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Set and exhibit designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Floor layers, except carpet, wood, and hard tiles" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Farm labor contractors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Septic tank servicers and sewer pipe cleaners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Dental hygienists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Securities, commodities, and financial services sales agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Food scientists and technologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Meeting, convention, and event planners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Lawyers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Financial and investment analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Magnetic resonance imaging technologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of entertainment and recreation workers, except gambling services" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Phlebotomists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Driver/sales workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Hairdressers, hairstylists, and cosmetologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Food batchmakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Motor vehicle operators, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Highway maintenance workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Insurance sales agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Semiconductor processing technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Shuttle drivers and chauffeurs" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Chemical engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Farm equipment mechanics and service technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Archivists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Agents and business managers of artists, performers, and athletes" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Entertainers and performers, sports and related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Financial risk specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Special effects artists and animators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Transportation, storage, and distribution managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Aerospace engineering and operations technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Entertainment and recreation managers, except gambling" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "First-line supervisors of personal service workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Medical records specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Makeup artists, theatrical and performance" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Aircraft cargo handling supervisors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Biological science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Agricultural equipment operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Social and human service assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Manicurists and pedicurists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Optometrists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Chiropractors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Nurse anesthetists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Athletes and sports competitors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Skincare specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Social and community service managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Coaches and scouts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Engineering teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Film and video editors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mechanical door repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Healthcare social workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer systems analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Umpires, referees, and other sports officials" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cargo and freight agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Psychiatric technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer occupations, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Management analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Recreational vehicle service technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Medical scientists, except epidemiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Museum technicians and conservators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Database architects" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mechanical engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Occupational health and safety technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Exercise physiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Audiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Mental health and substance abuse social workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Curators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Shampooers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Clinical and counseling psychologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Flight attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Occupational therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "1", "1", "Light truck drivers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Industrial engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Therapists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Respiratory therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Forensic science technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Ophthalmic medical technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Personal financial advisors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Medical equipment repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Occupational health and safety specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Market research analysts and marketing specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Exercise trainers and group fitness instructors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Medical assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Athletic trainers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Community health workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Diagnostic medical sonographers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Hearing aid specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Forest fire inspectors and prevention specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Marriage and family therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Industrial machinery mechanics" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Physical therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Web and digital interface designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Orthotists and prosthetists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer and information systems managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Animal caretakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer numerically controlled tool programmers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Animal trainers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Financial managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Genetic counselors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Health information technologists and medical registrars" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Web developers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Counselors, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Nursing instructors and teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Massage therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Logisticians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Health specialties teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Speech-language pathologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Financial examiners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Veterinarians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "0", "1", "Software quality assurance analysts and testers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Cooks, restaurant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Personal care and service workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Veterinary assistants and laboratory animal caretakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Veterinary technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "1", "Taxi drivers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "at_risk", "industry" },
                values: new object[] { "-1", "-1" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Solar photovoltaic installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Operations research analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Computer and information research scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Actuaries" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Occupational therapy assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "0", "1", "Software developers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Physical therapist assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Physician assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Epidemiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Medical and health services managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Information security analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Statisticians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "0", "1", "Data scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Nurse practitioners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "at_risk", "industry", "title" },
                values: new object[] { "-1", "-1", "Wind turbine service technicians" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "at_risk",
                table: "Occupations");

            migrationBuilder.DropColumn(
                name: "industry",
                table: "Occupations");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 1,
                column: "title",
                value: "Word processors and typists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 2,
                column: "title",
                value: "Watch and clock repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 3,
                column: "title",
                value: "Roof bolters, mining    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 4,
                column: "title",
                value: "Cutters and trimmers, hand    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 5,
                column: "title",
                value: "Telephone operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 6,
                column: "title",
                value: "Data entry keyers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 7,
                column: "title",
                value: "Switchboard operators, including answering service    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 8,
                column: "title",
                value: "Foundry mold and coremakers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 9,
                column: "title",
                value: "Legal secretaries and administrative assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 10,
                column: "title",
                value: "Pressers, textile, garment, and related materials    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 11,
                column: "title",
                value: "Patternmakers, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 12,
                column: "title",
                value: "Refractory materials repairers, except brickmasons    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 13,
                column: "title",
                value: "Executive secretaries and executive administrative assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 14,
                column: "title",
                value: "Manufactured building and mobile home installers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 15,
                column: "title",
                value: "Telemarketers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 16,
                column: "title",
                value: "Grinding and polishing workers, hand    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 17,
                column: "title",
                value: "Engine and other machine assemblers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 18,
                column: "title",
                value: "Model makers, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 19,
                column: "title",
                value: "Timing device assemblers and adjusters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 20,
                column: "title",
                value: "Drilling and boring machine tool setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 21,
                column: "title",
                value: "Order clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 22,
                column: "title",
                value: "Floral designers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 23,
                column: "title",
                value: "Electronic equipment installers and repairers, motor vehicles    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 24,
                column: "title",
                value: "Loading and moving machine operators, underground mining    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 25,
                column: "title",
                value: "Prepress technicians and workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 26,
                column: "title",
                value: "Coil winders, tapers, and finishers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 27,
                column: "title",
                value: "Payroll and timekeeping clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 28,
                column: "title",
                value: "Structural metal fabricators and fitters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 29,
                column: "title",
                value: "Print binding and finishing workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 30,
                column: "title",
                value: "File clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 31,
                column: "title",
                value: "Door-to-door sales workers, news and street vendors, and related workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 32,
                column: "title",
                value: "Sewers, hand    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 33,
                column: "title",
                value: "Sewing machine operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 34,
                column: "title",
                value: "Aircraft structure, surfaces, rigging, and systems assemblers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 35,
                column: "title",
                value: "Forging machine setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 36,
                column: "title",
                value: "Tellers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 37,
                column: "title",
                value: "New accounts clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 38,
                column: "title",
                value: "Office machine operators, except computer    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 39,
                column: "title",
                value: "Milling and planing machine setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 40,
                column: "title",
                value: "Cooks, fast food    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 41,
                column: "title",
                value: "Tailors, dressmakers, and custom sewers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 42,
                column: "title",
                value: "Desktop publishers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 43,
                column: "title",
                value: "Adult basic education, adult secondary education, and english as a second language instructors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 44,
                column: "title",
                value: "Power plant operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 45,
                column: "title",
                value: "Photographic process workers and processing machine operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 46,
                column: "title",
                value: "Underground mining machine operators, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 47,
                column: "title",
                value: "Meter readers, utilities    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 48,
                column: "title",
                value: "Terrazzo workers and finishers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 49,
                column: "title",
                value: "Gas plant operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 50,
                column: "title",
                value: "Secretaries and administrative assistants, except legal, medical, and executive    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 51,
                column: "title",
                value: "Broadcast announcers and radio disc jockeys    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 52,
                column: "title",
                value: "Postal service mail sorters, processors, and processing machine operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 53,
                column: "title",
                value: "Computer programmers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 54,
                column: "title",
                value: "Carpet installers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 55,
                column: "title",
                value: "Locksmiths and safe repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 56,
                column: "title",
                value: "Paper goods machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 57,
                column: "title",
                value: "Rolling machine setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 58,
                column: "title",
                value: "Shoe and leather workers and repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 59,
                column: "title",
                value: "Cutting, punching, and press machine setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 60,
                column: "title",
                value: "Helpers--brickmasons, blockmasons, stonemasons, and tile and marble setters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 61,
                column: "title",
                value: "Shoe machine operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 62,
                column: "title",
                value: "Computer, automated teller, and office machine repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 63,
                column: "title",
                value: "Textile cutting machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 64,
                column: "title",
                value: "Textile knitting and weaving machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 65,
                column: "title",
                value: "Cashiers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 66,
                column: "title",
                value: "Layout workers, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 67,
                column: "title",
                value: "Interviewers, except eligibility and loan    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 68,
                column: "title",
                value: "Bill and account collectors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 69,
                column: "title",
                value: "Motion picture projectionists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 70,
                column: "title",
                value: "Grinding, lapping, polishing, and buffing machine tool setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 71,
                column: "title",
                value: "Textile bleaching and dyeing machine operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 72,
                column: "title",
                value: "Plating machine setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 73,
                column: "title",
                value: "Lathe and turning machine tool setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 74,
                column: "title",
                value: "Musical instrument repairers and tuners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 75,
                column: "title",
                value: "Fallers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 76,
                column: "title",
                value: "Helpers--production workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 77,
                column: "title",
                value: "Heat treating equipment setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 78,
                column: "title",
                value: "Pourers and casters, metal    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 79,
                column: "title",
                value: "Brokerage clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 80,
                column: "title",
                value: "Forest and conservation workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 81,
                column: "title",
                value: "Textile winding, twisting, and drawing out machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 82,
                column: "title",
                value: "Printing press operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 83,
                column: "title",
                value: "Tool and die makers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 84,
                column: "title",
                value: "Tool grinders, filers, and sharpeners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 85,
                column: "title",
                value: "Shipping, receiving, and inventory clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 86,
                column: "title",
                value: "Welding, soldering, and brazing machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 87,
                column: "title",
                value: "Office and administrative support workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 88,
                column: "title",
                value: "Chief executives    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 89,
                column: "title",
                value: "Metal-refining furnace operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 90,
                column: "title",
                value: "Computer numerically controlled tool operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 91,
                column: "title",
                value: "Metal workers and plastic workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 92,
                column: "title",
                value: "Drafters, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 93,
                column: "title",
                value: "Textile, apparel, and furnishings workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 95,
                column: "title",
                value: "Procurement clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 97,
                column: "title",
                value: "Correctional officers and jailers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 98,
                column: "title",
                value: "Fabric and apparel patternmakers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 99,
                column: "title",
                value: "Advertising sales agents    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 100,
                column: "title",
                value: "Mechanical drafters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 101,
                column: "title",
                value: "Logging workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 102,
                column: "title",
                value: "First-line supervisors of retail sales workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 103,
                column: "title",
                value: "Postal service mail carriers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 104,
                column: "title",
                value: "Postal service clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 105,
                column: "title",
                value: "Postmasters and mail superintendents    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 106,
                column: "title",
                value: "Office clerks, general    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 107,
                column: "title",
                value: "Audiovisual equipment installers and repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 108,
                column: "title",
                value: "Water and wastewater treatment plant and system operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 109,
                column: "title",
                value: "Fish and game wardens    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 110,
                column: "title",
                value: "Bookkeeping, accounting, and auditing clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 111,
                column: "title",
                value: "Cooks, short order    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 112,
                column: "title",
                value: "Library technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 113,
                column: "title",
                value: "Stonemasons    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 114,
                column: "title",
                value: "Correspondence clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 115,
                column: "title",
                value: "Library assistants, clerical    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 116,
                column: "title",
                value: "Credit authorizers, checkers, and clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 117,
                column: "title",
                value: "Gambling change persons and booth cashiers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 118,
                column: "title",
                value: "Customer service representatives    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 119,
                column: "title",
                value: "Chemical equipment operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 120,
                column: "title",
                value: "Cooks, private household    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 121,
                column: "title",
                value: "Gambling cage workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 122,
                column: "title",
                value: "Farmworkers, farm, ranch, and aquacultural animals    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 123,
                column: "title",
                value: "Helpers--carpenters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 124,
                column: "title",
                value: "First-line supervisors of office and administrative support workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 125,
                column: "title",
                value: "Graders and sorters, agricultural products    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 126,
                column: "title",
                value: "Patternmakers, wood    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 127,
                column: "title",
                value: "Power distributors and dispatchers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 128,
                column: "title",
                value: "Human resources assistants, except payroll and timekeeping    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 129,
                column: "title",
                value: "Food preparation workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 130,
                column: "title",
                value: "Mail clerks and mail machine operators, except postal service    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 131,
                column: "title",
                value: "Farmers, ranchers, and other agricultural managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 132,
                column: "title",
                value: "Dental laboratory technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 133,
                column: "title",
                value: "Pipelayers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 134,
                column: "title",
                value: "Credit analysts    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 135,
                column: "title",
                value: "Home appliance repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 136,
                column: "title",
                value: "Tire builders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 137,
                column: "title",
                value: "Cutting and slicing machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 138,
                column: "title",
                value: "Cement masons and concrete finishers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 139,
                column: "title",
                value: "Editors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 140,
                column: "title",
                value: "Boilermakers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 141,
                column: "title",
                value: "Gambling and sports book writers and runners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 142,
                column: "title",
                value: "Inspectors, testers, sorters, samplers, and weighers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 143,
                column: "title",
                value: "First-line supervisors of security workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 144,
                column: "title",
                value: "Proofreaders and copy markers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 145,
                column: "title",
                value: "Medical transcriptionists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 146,
                column: "title",
                value: "Excavating and loading machine and dragline operators, surface mining    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 147,
                column: "title",
                value: "Logging equipment operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 148,
                column: "title",
                value: "Survey researchers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 149,
                column: "title",
                value: "Molding, coremaking, and casting machine setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 150,
                column: "title",
                value: "School bus monitors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 151,
                column: "title",
                value: "Woodworkers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 152,
                column: "title",
                value: "Model makers, wood    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 153,
                column: "title",
                value: "Helpers--electricians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 154,
                column: "title",
                value: "Crushing, grinding, and polishing machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 155,
                column: "title",
                value: "Lighting technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 156,
                column: "title",
                value: "News analysts, reporters, and journalists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 157,
                column: "title",
                value: "Nuclear power reactor operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 158,
                column: "title",
                value: "Insurance claims and policy processing clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 159,
                column: "title",
                value: "Chemical plant and system operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 160,
                column: "title",
                value: "Continuous mining machine operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 161,
                column: "title",
                value: "Waiters and waitresses    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 162,
                column: "title",
                value: "Claims adjusters, examiners, and investigators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 163,
                column: "title",
                value: "Education and childcare administrators, preschool and daycare    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 164,
                column: "title",
                value: "Jewelers and precious stone and metal workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 165,
                column: "title",
                value: "Cost estimators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 166,
                column: "title",
                value: "Weighers, measurers, checkers, and samplers, recordkeeping    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 167,
                column: "title",
                value: "Pharmacy aides    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 168,
                column: "title",
                value: "First-line supervisors of correctional officers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 169,
                column: "title",
                value: "Electrical and electronics repairers, powerhouse, substation, and relay    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 170,
                column: "title",
                value: "Electro-mechanical and mechatronics technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 171,
                column: "title",
                value: "Hotel, motel, and resort desk clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 172,
                column: "title",
                value: "Insurance appraisers, auto damage    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 173,
                column: "title",
                value: "Upholsterers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 174,
                column: "title",
                value: "Insurance underwriters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 175,
                column: "title",
                value: "Dishwashers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 176,
                column: "title",
                value: "Petroleum pump system operators, refinery operators, and gaugers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 177,
                column: "title",
                value: "Bailiffs    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 178,
                column: "title",
                value: "Extruding and forming machine setters, operators, and tenders, synthetic and glass fibers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 179,
                column: "title",
                value: "Tapers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 180,
                column: "title",
                value: "Farmworkers and laborers, crop, nursery, and greenhouse    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 181,
                column: "title",
                value: "First-line supervisors of non-retail sales workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 182,
                column: "title",
                value: "Wellhead pumpers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 183,
                column: "title",
                value: "Adhesive bonding machine operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 184,
                column: "title",
                value: "Retail salespersons    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 185,
                column: "title",
                value: "Gas compressor and gas pumping station operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 186,
                column: "title",
                value: "Childcare workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 187,
                column: "title",
                value: "Farm and home management educators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 188,
                column: "title",
                value: "Cabinetmakers and bench carpenters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 189,
                column: "title",
                value: "Extruding and drawing machine setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 190,
                column: "title",
                value: "Extraction workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 191,
                column: "title",
                value: "Hoist and winch operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 192,
                column: "title",
                value: "Coin, vending, and amusement machine servicers and repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 193,
                column: "title",
                value: "Statistical assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 194,
                column: "title",
                value: "Log graders and scalers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 195,
                column: "title",
                value: "Construction and building inspectors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 196,
                column: "title",
                value: "Parking enforcement workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 197,
                column: "title",
                value: "Security guards    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 198,
                column: "title",
                value: "Laundry and dry-cleaning workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 199,
                column: "title",
                value: "Extruding, forming, pressing, and compacting machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 200,
                column: "title",
                value: "Nuclear technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 201,
                column: "title",
                value: "Butchers and meat cutters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 202,
                column: "title",
                value: "Sound engineering technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 203,
                column: "title",
                value: "Dispatchers, except police, fire, and ambulance    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 204,
                column: "title",
                value: "Broadcast technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 205,
                column: "title",
                value: "Packers and packagers, hand    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 206,
                column: "title",
                value: "Loan interviewers and clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 207,
                column: "title",
                value: "Slaughterers and meat packers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 208,
                column: "title",
                value: "Woodworking machine setters, operators, and tenders, except sawing    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 209,
                column: "title",
                value: "Labor relations specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 210,
                column: "title",
                value: "Bridge and lock tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 211,
                column: "title",
                value: "Electrical and electronics repairers, commercial and industrial equipment    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 212,
                column: "title",
                value: "Fence erectors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 213,
                column: "title",
                value: "Furniture finishers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 214,
                column: "title",
                value: "Control and valve installers and repairers, except mechanical door    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 215,
                column: "title",
                value: "Career/technical education teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 216,
                column: "title",
                value: "Fishing and hunting workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 217,
                column: "title",
                value: "Fiberglass laminators and fabricators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 218,
                column: "title",
                value: "Directors, religious activities and education    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 219,
                column: "title",
                value: "Career/technical education teachers, secondary school    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 220,
                column: "title",
                value: "Special education teachers, middle school    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 221,
                column: "title",
                value: "Etchers and engravers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 222,
                column: "title",
                value: "Plant and system operators, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 223,
                column: "title",
                value: "Sheet metal workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 225,
                column: "title",
                value: "Career/technical education teachers, middle school    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 226,
                column: "title",
                value: "Precision instrument and equipment repairers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 227,
                column: "title",
                value: "Transportation security screeners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 228,
                column: "title",
                value: "Billing and posting clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 229,
                column: "title",
                value: "Floor sanders and finishers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 230,
                column: "title",
                value: "Painting, coating, and decorating workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 231,
                column: "title",
                value: "Rotary drill operators, oil and gas    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 232,
                column: "title",
                value: "Sawing machine setters, operators, and tenders, wood    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 233,
                column: "title",
                value: "Service unit operators, oil and gas    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 235,
                column: "title",
                value: "Maids and housekeeping cleaners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 236,
                column: "title",
                value: "Ambulance drivers and attendants, except emergency medical technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 237,
                column: "title",
                value: "Crane and tower operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 238,
                column: "title",
                value: "Legal support workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 239,
                column: "title",
                value: "Automotive and watercraft service attendants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 240,
                column: "title",
                value: "Dredge operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 241,
                column: "title",
                value: "Mining and geological engineers, including mining safety engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 242,
                column: "title",
                value: "First-line supervisors of production and operating workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 243,
                column: "title",
                value: "Hydrologic technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 244,
                column: "title",
                value: "Furnace, kiln, oven, drier, and kettle operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 245,
                column: "title",
                value: "Nuclear medicine technologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 246,
                column: "title",
                value: "Receptionists and information clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 247,
                column: "title",
                value: "Models    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 248,
                column: "title",
                value: "Derrick operators, oil and gas    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 249,
                column: "title",
                value: "Brickmasons and blockmasons    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 250,
                column: "title",
                value: "Kindergarten teachers, except special education    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 251,
                column: "title",
                value: "Special education teachers, secondary school    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 252,
                column: "title",
                value: "Food service managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 253,
                column: "title",
                value: "Hosts and hostesses, restaurant, lounge, and coffee shop    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 254,
                column: "title",
                value: "Gambling surveillance officers and gambling investigators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 255,
                column: "title",
                value: "Forest and conservation technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 256,
                column: "title",
                value: "Mechanical engineering technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 257,
                column: "title",
                value: "Tax examiners and collectors, and revenue agents    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 258,
                column: "title",
                value: "Religious workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 259,
                column: "title",
                value: "Architectural and civil drafters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 260,
                column: "title",
                value: "Multiple machine tool setters, operators, and tenders, metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 261,
                column: "title",
                value: "Coating, painting, and spraying machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 262,
                column: "title",
                value: "Clergy    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 263,
                column: "title",
                value: "Marine engineers and naval architects    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 264,
                column: "title",
                value: "Landscape architects    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 265,
                column: "title",
                value: "Sales representatives, wholesale and manufacturing, except technical and scientific products    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 266,
                column: "title",
                value: "Elementary school teachers, except special education    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 267,
                column: "title",
                value: "Gambling service workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 268,
                column: "title",
                value: "Helpers--extraction workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 269,
                column: "title",
                value: "Locomotive engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 270,
                column: "title",
                value: "Surgeons, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 271,
                column: "title",
                value: "Hazardous materials removal workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 272,
                column: "title",
                value: "Electrical and electronic engineering technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 273,
                column: "title",
                value: "Middle school teachers, except special and career/technical education    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 274,
                column: "title",
                value: "Embalmers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 275,
                column: "title",
                value: "Electrical and electronics drafters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 276,
                column: "title",
                value: "Pediatricians, general    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 277,
                column: "title",
                value: "Civil engineering technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 278,
                column: "title",
                value: "Bus and truck mechanics and diesel engine specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 279,
                column: "title",
                value: "Carpenters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 280,
                column: "title",
                value: "Pediatric surgeons    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 281,
                column: "title",
                value: "Podiatrists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 282,
                column: "title",
                value: "Gambling dealers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 283,
                column: "title",
                value: "Parts salespersons    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 284,
                column: "title",
                value: "Secondary school teachers, except special and career/technical education    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 285,
                column: "title",
                value: "Camera and photographic equipment repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 286,
                column: "title",
                value: "Geographers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 287,
                column: "title",
                value: "Administrative law judges, adjudicators, and hearing officers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 288,
                column: "title",
                value: "Explosives workers, ordnance handling experts, and blasters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 289,
                column: "title",
                value: "Nuclear engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 290,
                column: "title",
                value: "Ophthalmic laboratory technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 291,
                column: "title",
                value: "Railroad conductors and yardmasters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 292,
                column: "title",
                value: "Financial clerks, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 293,
                column: "title",
                value: "Music directors and composers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 294,
                column: "title",
                value: "Tire repairers and changers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 295,
                column: "title",
                value: "Education administrators, kindergarten through secondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 296,
                column: "title",
                value: "Railroad brake, signal, and switch operators and locomotive firers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 297,
                column: "title",
                value: "Signal and track switch repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 298,
                column: "title",
                value: "Reinforcing iron and rebar workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 299,
                column: "title",
                value: "Outdoor power equipment and other small engine mechanics    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 300,
                column: "title",
                value: "English language and literature teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 301,
                column: "title",
                value: "Automotive body and related repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 302,
                column: "title",
                value: "Musicians and singers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 303,
                column: "title",
                value: "Ship engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 304,
                column: "title",
                value: "Environmental engineering technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 305,
                column: "title",
                value: "History teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 306,
                column: "title",
                value: "School psychologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 307,
                column: "title",
                value: "Reservation and transportation ticket agents and travel clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 308,
                column: "title",
                value: "Janitors and cleaners, except maids and housekeeping cleaners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 309,
                column: "title",
                value: "Rail-track laying and maintenance equipment operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 310,
                column: "title",
                value: "Air traffic controllers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 311,
                column: "title",
                value: "Foreign language and literature teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 312,
                column: "title",
                value: "Riggers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 314,
                column: "title",
                value: "Bus drivers, school    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 315,
                column: "title",
                value: "Welders, cutters, solderers, and brazers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 316,
                column: "title",
                value: "Helpers--painters, paperhangers, plasterers, and stucco masons    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 317,
                column: "title",
                value: "Hydrologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 318,
                column: "title",
                value: "Elevator and escalator installers and repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 319,
                column: "title",
                value: "Parking attendants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 320,
                column: "title",
                value: "Tax preparers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 321,
                column: "title",
                value: "Detectives and criminal investigators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 322,
                column: "title",
                value: "Mixing and blending machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 323,
                column: "title",
                value: "Installation, maintenance, and repair workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 324,
                column: "title",
                value: "Painters, construction and maintenance    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 325,
                column: "title",
                value: "Fast food and counter workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 326,
                column: "title",
                value: "Tank car, truck, and ship loaders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 327,
                column: "title",
                value: "Orthopedic surgeons, except pediatric    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 328,
                column: "title",
                value: "Food cooking machine operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 329,
                column: "title",
                value: "Helpers, construction trades, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 330,
                column: "title",
                value: "Ushers, lobby attendants, and ticket takers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 331,
                column: "title",
                value: "Drywall and ceiling tile installers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 332,
                column: "title",
                value: "Couriers and messengers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 333,
                column: "title",
                value: "Industrial production managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 334,
                column: "title",
                value: "Automotive service technicians and mechanics    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 335,
                column: "title",
                value: "Automotive glass installers and repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 336,
                column: "title",
                value: "Insulation workers, mechanical    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 337,
                column: "title",
                value: "Insulation workers, floor, ceiling, and wall    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 338,
                column: "title",
                value: "Social scientists and related workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 339,
                column: "title",
                value: "Captains, mates, and pilots of water vessels    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 340,
                column: "title",
                value: "Title examiners, abstractors, and searchers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 341,
                column: "title",
                value: "Agricultural workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 342,
                column: "title",
                value: "Motorcycle mechanics    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 343,
                column: "title",
                value: "Structural iron and steel workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 344,
                column: "title",
                value: "Rock splitters, quarry    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 345,
                column: "title",
                value: "Special education teachers, preschool    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 346,
                column: "title",
                value: "Advertising and promotions managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 347,
                column: "title",
                value: "Rehabilitation counselors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 348,
                column: "title",
                value: "Teachers and instructors, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 349,
                column: "title",
                value: "Machinists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 350,
                column: "title",
                value: "Helpers--roofers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 351,
                column: "title",
                value: "Agricultural inspectors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 352,
                column: "title",
                value: "Pesticide handlers, sprayers, and applicators, vegetation    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 354,
                column: "title",
                value: "Sailors and marine oilers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 355,
                column: "title",
                value: "Commercial and industrial designers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 356,
                column: "title",
                value: "Healthcare diagnosing or treating practitioners, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 357,
                column: "title",
                value: "Meat, poultry, and fish cutters and trimmers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 358,
                column: "title",
                value: "Roofers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 359,
                column: "title",
                value: "Animal breeders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 361,
                column: "title",
                value: "Plasterers and stucco masons    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 362,
                column: "title",
                value: "Cooks, institution and cafeteria    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 363,
                column: "title",
                value: "Mathematicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 364,
                column: "title",
                value: "Rail transportation workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 365,
                column: "title",
                value: "Compensation and benefits managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 366,
                column: "title",
                value: "Earth drillers, except oil and gas    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 367,
                column: "title",
                value: "Grounds maintenance workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 368,
                column: "title",
                value: "Obstetricians and gynecologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 369,
                column: "title",
                value: "Judges, magistrate judges, and magistrates    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 370,
                column: "title",
                value: "Funeral home managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 371,
                column: "title",
                value: "Glaziers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 372,
                column: "title",
                value: "Eligibility interviewers, government programs    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 373,
                column: "title",
                value: "Judicial law clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 374,
                column: "title",
                value: "Helpers--pipelayers, plumbers, pipefitters, and steamfitters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 375,
                column: "title",
                value: "Educational instruction and library workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 376,
                column: "title",
                value: "Plumbers, pipefitters, and steamfitters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 377,
                column: "title",
                value: "Rail yard engineers, dinkey operators, and hostlers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 378,
                column: "title",
                value: "Foresters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 379,
                column: "title",
                value: "Radiation therapists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 380,
                column: "title",
                value: "Molders, shapers, and casters, except metal and plastic    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 381,
                column: "title",
                value: "Merchandise displayers and window trimmers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 382,
                column: "title",
                value: "First-line supervisors of mechanics, installers, and repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 383,
                column: "title",
                value: "Building cleaning workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 384,
                column: "title",
                value: "Electric motor, power tool, and related repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 385,
                column: "title",
                value: "Medical appliance technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 386,
                column: "title",
                value: "Petroleum engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 387,
                column: "title",
                value: "Tree trimmers and pruners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 388,
                column: "title",
                value: "General internal medicine physicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 389,
                column: "title",
                value: "Helpers--installation, maintenance, and repair workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 390,
                column: "title",
                value: "Probation officers and correctional treatment specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 391,
                column: "title",
                value: "Instructional coordinators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 392,
                column: "title",
                value: "Network and computer systems administrators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 393,
                column: "title",
                value: "First-line supervisors of construction trades and extraction workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 394,
                column: "title",
                value: "Gambling managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 395,
                column: "title",
                value: "Social sciences teachers, postsecondary, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 396,
                column: "title",
                value: "Anesthesiologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 397,
                column: "title",
                value: "First-line supervisors of landscaping, lawn service, and groundskeeping workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 398,
                column: "title",
                value: "Pharmacists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 399,
                column: "title",
                value: "Dentists, all other specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 400,
                column: "title",
                value: "Criminal justice and law enforcement teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 401,
                column: "title",
                value: "Transportation inspectors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 402,
                column: "title",
                value: "Philosophy and religion teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 403,
                column: "title",
                value: "First-line supervisors of farming, fishing, and forestry workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 404,
                column: "title",
                value: "Opticians, dispensing    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 405,
                column: "title",
                value: "Information and record clerks, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 406,
                column: "title",
                value: "Counter and rental clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 407,
                column: "title",
                value: "Operating engineers and other construction equipment operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 408,
                column: "title",
                value: "Court reporters and simultaneous captioners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 409,
                column: "title",
                value: "Emergency medicine physicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 410,
                column: "title",
                value: "Funeral attendants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 411,
                column: "title",
                value: "Camera operators, television, video, and film    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 412,
                column: "title",
                value: "Stationary engineers and boiler operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 414,
                column: "title",
                value: "Security and fire alarm systems installers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 415,
                column: "title",
                value: "Electrical power-line installers and repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 416,
                column: "title",
                value: "Motorboat operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 417,
                column: "title",
                value: "Roustabouts, oil and gas    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 418,
                column: "title",
                value: "Special education teachers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 419,
                column: "title",
                value: "Loan officers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 420,
                column: "title",
                value: "Law teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 421,
                column: "title",
                value: "Zoologists and wildlife biologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 422,
                column: "title",
                value: "Food and tobacco roasting, baking, and drying machine operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 423,
                column: "title",
                value: "Millwrights    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 424,
                column: "title",
                value: "Physical therapist aides    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 425,
                column: "title",
                value: "Protective service workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 426,
                column: "title",
                value: "Librarians and media collections specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 427,
                column: "title",
                value: "Court, municipal, and license clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 428,
                column: "title",
                value: "First-line supervisors of housekeeping and janitorial workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 429,
                column: "title",
                value: "Physicians, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 430,
                column: "title",
                value: "Historians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 431,
                column: "title",
                value: "Geological technicians, except hydrologic technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 432,
                column: "title",
                value: "Dermatologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 433,
                column: "title",
                value: "Cardiologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 434,
                column: "title",
                value: "Designers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 435,
                column: "title",
                value: "Engineering technologists and technicians, except drafters, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 436,
                column: "title",
                value: "Pest control workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 437,
                column: "title",
                value: "First-line supervisors of police and detectives    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 438,
                column: "title",
                value: "Food servers, nonrestaurant    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 439,
                column: "title",
                value: "Pile driver operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 440,
                column: "title",
                value: "Transit and railroad police    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 441,
                column: "title",
                value: "Neurologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 442,
                column: "title",
                value: "Cooks, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 443,
                column: "title",
                value: "First-line supervisors of gambling services workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 444,
                column: "title",
                value: "Mathematical science teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 445,
                column: "title",
                value: "Chemical technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 446,
                column: "title",
                value: "Industrial engineering technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 447,
                column: "title",
                value: "Actors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 448,
                column: "title",
                value: "Art, drama, and music teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 449,
                column: "title",
                value: "Refuse and recyclable material collectors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 450,
                column: "title",
                value: "Self-enrichment teachers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 451,
                column: "title",
                value: "Real estate sales agents    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 452,
                column: "title",
                value: "Emergency management directors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 453,
                column: "title",
                value: "Recreation and fitness studies teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 454,
                column: "title",
                value: "Fashion designers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 455,
                column: "title",
                value: "Budget analysts    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 456,
                column: "title",
                value: "Surveying and mapping technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 457,
                column: "title",
                value: "Engineers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 458,
                column: "title",
                value: "Tutors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 459,
                column: "title",
                value: "Graphic designers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 460,
                column: "title",
                value: "Bartenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 461,
                column: "title",
                value: "Police and sheriff's patrol officers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 462,
                column: "title",
                value: "Managers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 463,
                column: "title",
                value: "Medical dosimetrists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 464,
                column: "title",
                value: "Artists and related workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 465,
                column: "title",
                value: "Radio, cellular, and tower equipment installers and repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 466,
                column: "title",
                value: "Media and communication equipment workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 467,
                column: "title",
                value: "First-line supervisors of protective service workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 468,
                column: "title",
                value: "Communications teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 469,
                column: "title",
                value: "Legislators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 470,
                column: "title",
                value: "Separating, filtering, clarifying, precipitating, and still machine setters, operators, and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 471,
                column: "title",
                value: "Public safety telecommunicators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 472,
                column: "title",
                value: "Preschool teachers, except special education    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 473,
                column: "title",
                value: "Subway and streetcar operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 474,
                column: "title",
                value: "Traffic technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 475,
                column: "title",
                value: "Dietetic technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 476,
                column: "title",
                value: "Chemistry teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 477,
                column: "title",
                value: "Material moving workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 478,
                column: "title",
                value: "Travel agents    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 479,
                column: "title",
                value: "Real estate brokers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 480,
                column: "title",
                value: "Computer network architects    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 481,
                column: "title",
                value: "Education administrators, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 482,
                column: "title",
                value: "Landscaping and groundskeeping workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 483,
                column: "title",
                value: "Pump operators, except wellhead pumpers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 484,
                column: "title",
                value: "Atmospheric, earth, marine, and space sciences teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 485,
                column: "title",
                value: "Ophthalmologists, except pediatric    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 486,
                column: "title",
                value: "Recreational therapists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 487,
                column: "title",
                value: "Rail car repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 488,
                column: "title",
                value: "Radiologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 489,
                column: "title",
                value: "First-line supervisors of firefighting and prevention workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 490,
                column: "title",
                value: "Postsecondary teachers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 491,
                column: "title",
                value: "Firefighters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 492,
                column: "title",
                value: "Maintenance and repair workers, general    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 493,
                column: "title",
                value: "Paperhangers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 494,
                column: "title",
                value: "Fire inspectors and investigators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 495,
                column: "title",
                value: "Sociology teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 496,
                column: "title",
                value: "Political science teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 497,
                column: "title",
                value: "Health and safety engineers, except mining safety engineers and inspectors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 498,
                column: "title",
                value: "Morticians, undertakers, and funeral arrangers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 499,
                column: "title",
                value: "Paving, surfacing, and tamping equipment operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 500,
                column: "title",
                value: "Urban and regional planners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 501,
                column: "title",
                value: "Cardiovascular technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 502,
                column: "title",
                value: "Education teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 503,
                column: "title",
                value: "Family medicine physicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 504,
                column: "title",
                value: "Writers and authors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 505,
                column: "title",
                value: "Sales representatives, wholesale and manufacturing, technical and scientific products    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 506,
                column: "title",
                value: "Cleaners of vehicles and equipment    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 507,
                column: "title",
                value: "Industrial truck and tractor operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 508,
                column: "title",
                value: "Architecture teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 509,
                column: "title",
                value: "Bicycle repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 510,
                column: "title",
                value: "Cleaning, washing, and metal pickling equipment operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 511,
                column: "title",
                value: "Economics teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 512,
                column: "title",
                value: "Physics teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 513,
                column: "title",
                value: "Life, physical, and social science technicians, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 514,
                column: "title",
                value: "Crematory operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 515,
                column: "title",
                value: "Family and consumer sciences teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 516,
                column: "title",
                value: "Craft artists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 517,
                column: "title",
                value: "Area, ethnic, and cultural studies teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 518,
                column: "title",
                value: "Transportation workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 519,
                column: "title",
                value: "Food processing workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 520,
                column: "title",
                value: "Biological scientists, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 521,
                column: "title",
                value: "Airline pilots, copilots, and flight engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 522,
                column: "title",
                value: "Interior designers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 523,
                column: "title",
                value: "Anthropology and archeology teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 524,
                column: "title",
                value: "Animal control workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 525,
                column: "title",
                value: "Social work teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 526,
                column: "title",
                value: "Demonstrators and product promoters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 527,
                column: "title",
                value: "Commercial pilots    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 528,
                column: "title",
                value: "Sales managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 529,
                column: "title",
                value: "Library science teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 530,
                column: "title",
                value: "Passenger attendants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 531,
                column: "title",
                value: "Conservation scientists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 532,
                column: "title",
                value: "Crossing guards and flaggers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 533,
                column: "title",
                value: "Photographers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 534,
                column: "title",
                value: "Architectural and engineering managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 535,
                column: "title",
                value: "Substitute teachers, short-term    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 536,
                column: "title",
                value: "Sales representatives of services, except advertising, insurance, financial services, and travel    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 537,
                column: "title",
                value: "Business operations specialists, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 538,
                column: "title",
                value: "Nursing assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 539,
                column: "title",
                value: "Heavy and tractor-trailer truck drivers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 540,
                column: "title",
                value: "Anthropologists and archeologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 541,
                column: "title",
                value: "Environmental science teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 542,
                column: "title",
                value: "Disc jockeys, except radio    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 543,
                column: "title",
                value: "Orderlies    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 544,
                column: "title",
                value: "Teaching assistants, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 545,
                column: "title",
                value: "Electrical engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 546,
                column: "title",
                value: "Amusement and recreation attendants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 547,
                column: "title",
                value: "Paralegals and legal assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 548,
                column: "title",
                value: "Production, planning, and expediting clerks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 549,
                column: "title",
                value: "Dining room and cafeteria attendants and bartender helpers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 550,
                column: "title",
                value: "General and operations managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 551,
                column: "title",
                value: "Avionics technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 552,
                column: "title",
                value: "Personal service managers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 553,
                column: "title",
                value: "Media and communication workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 554,
                column: "title",
                value: "Interpreters and translators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 555,
                column: "title",
                value: "Food preparation and serving related workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 556,
                column: "title",
                value: "Aircraft mechanics and service technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 557,
                column: "title",
                value: "Geography teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 558,
                column: "title",
                value: "Atmospheric and space scientists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 559,
                column: "title",
                value: "Calibration technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 560,
                column: "title",
                value: "Purchasing managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 561,
                column: "title",
                value: "Dentists, general    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 562,
                column: "title",
                value: "Construction laborers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 563,
                column: "title",
                value: "Accountants and auditors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 564,
                column: "title",
                value: "Sociologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 565,
                column: "title",
                value: "Orthodontists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 566,
                column: "title",
                value: "Agricultural technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 567,
                column: "title",
                value: "Sales and related workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 569,
                column: "title",
                value: "Construction managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 570,
                column: "title",
                value: "Astronomers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 571,
                column: "title",
                value: "Physicians, pathologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 572,
                column: "title",
                value: "Surveyors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 573,
                column: "title",
                value: "Computer hardware engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 575,
                column: "title",
                value: "Facilities managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 576,
                column: "title",
                value: "Recreation workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 577,
                column: "title",
                value: "Compliance officers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 578,
                column: "title",
                value: "Packaging and filling machine operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 579,
                column: "title",
                value: "Soil and plant scientists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 580,
                column: "title",
                value: "Aircraft service attendants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 581,
                column: "title",
                value: "Physicists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 582,
                column: "title",
                value: "Sales engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 583,
                column: "title",
                value: "Audio and video technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 584,
                column: "title",
                value: "Biological technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 586,
                column: "title",
                value: "Electrical and electronics installers and repairers, transportation equipment    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 587,
                column: "title",
                value: "Agricultural sciences teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 588,
                column: "title",
                value: "Social science research assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 589,
                column: "title",
                value: "Natural sciences managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 590,
                column: "title",
                value: "Architects, except landscape and naval    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 591,
                column: "title",
                value: "Occupational therapy aides    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 592,
                column: "title",
                value: "Airfield operations specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 593,
                column: "title",
                value: "Psychiatric aides    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 594,
                column: "title",
                value: "Bakers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 596,
                column: "title",
                value: "First-line supervisors of food preparation and serving workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 597,
                column: "title",
                value: "Oral and maxillofacial surgeons    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 598,
                column: "title",
                value: "Choreographers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 599,
                column: "title",
                value: "Costume attendants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 600,
                column: "title",
                value: "Arbitrators, mediators, and conciliators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 601,
                column: "title",
                value: "Cartographers and photogrammetrists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 602,
                column: "title",
                value: "Civil engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 603,
                column: "title",
                value: "Computer user support specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 604,
                column: "title",
                value: "Cooling and freezing equipment operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 605,
                column: "title",
                value: "Materials scientists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 606,
                column: "title",
                value: "Bioengineers and biomedical engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 607,
                column: "title",
                value: "Materials engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 608,
                column: "title",
                value: "Geoscientists, except hydrologists and geographers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 609,
                column: "title",
                value: "Fundraising managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 610,
                column: "title",
                value: "Psychologists, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 611,
                column: "title",
                value: "Mobile heavy equipment mechanics, except engines    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 612,
                column: "title",
                value: "Forestry and conservation science teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 613,
                column: "title",
                value: "Life scientists, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 614,
                column: "title",
                value: "Surgical assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 615,
                column: "title",
                value: "Food science technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 616,
                column: "title",
                value: "Microbiologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 617,
                column: "title",
                value: "Fine artists, including painters, sculptors, and illustrators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 618,
                column: "title",
                value: "Healthcare practitioners and technical workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 619,
                column: "title",
                value: "Psychology teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 620,
                column: "title",
                value: "Fundraisers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 621,
                column: "title",
                value: "Human resources managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 622,
                column: "title",
                value: "Dancers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 623,
                column: "title",
                value: "Acupuncturists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 624,
                column: "title",
                value: "Computer science teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 625,
                column: "title",
                value: "Chefs and head cooks    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 626,
                column: "title",
                value: "Child, family, and school social workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 627,
                column: "title",
                value: "Licensed practical and licensed vocational nurses    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 628,
                column: "title",
                value: "Laborers and freight, stock, and material movers, hand    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 629,
                column: "title",
                value: "Entertainment attendants and related workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 630,
                column: "title",
                value: "Credit counselors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 631,
                column: "title",
                value: "Medical equipment preparers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 632,
                column: "title",
                value: "Paramedics    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 633,
                column: "title",
                value: "Surgical technologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 634,
                column: "title",
                value: "Bus drivers, transit and intercity    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 635,
                column: "title",
                value: "Emergency medical technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 636,
                column: "title",
                value: "Educational, guidance, and career counselors and advisors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 637,
                column: "title",
                value: "Property, real estate, and community association managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 638,
                column: "title",
                value: "Machine feeders and offbearers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 639,
                column: "title",
                value: "Maintenance workers, machinery    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 640,
                column: "title",
                value: "Radiologic technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 641,
                column: "title",
                value: "Heating, air conditioning, and refrigeration mechanics and installers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 642,
                column: "title",
                value: "Concierges    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 643,
                column: "title",
                value: "Administrative services managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 644,
                column: "title",
                value: "Pharmacy technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 645,
                column: "title",
                value: "Registered nurses    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 646,
                column: "title",
                value: "Prosthodontists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 647,
                column: "title",
                value: "Animal scientists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 648,
                column: "title",
                value: "Motorboat mechanics and service technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 649,
                column: "title",
                value: "Healthcare support workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 650,
                column: "title",
                value: "Conveyor operators and tenders    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 651,
                column: "title",
                value: "Environmental science and protection technicians, including health    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 652,
                column: "title",
                value: "Communications equipment operators, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 653,
                column: "title",
                value: "Industrial-organizational psychologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 654,
                column: "title",
                value: "Public relations managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 655,
                column: "title",
                value: "Human resources specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 656,
                column: "title",
                value: "Commercial divers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 657,
                column: "title",
                value: "Residential advisors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 658,
                column: "title",
                value: "Private detectives and investigators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 659,
                column: "title",
                value: "Environmental engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 660,
                column: "title",
                value: "Aerospace engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 661,
                column: "title",
                value: "Environmental scientists and specialists, including health    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 662,
                column: "title",
                value: "Art directors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 663,
                column: "title",
                value: "Financial specialists, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 664,
                column: "title",
                value: "Public relations specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 665,
                column: "title",
                value: "Mathematical science occupations, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 666,
                column: "title",
                value: "Chemists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 667,
                column: "title",
                value: "Lifeguards, ski patrol, and other recreational protective service workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 668,
                column: "title",
                value: "Project management specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 669,
                column: "title",
                value: "Agricultural engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 670,
                column: "title",
                value: "Economists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 671,
                column: "title",
                value: "Baggage porters and bellhops    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 672,
                column: "title",
                value: "Telecommunications equipment installers and repairers, except line installers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 673,
                column: "title",
                value: "Training and development specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 674,
                column: "title",
                value: "Stockers and order fillers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 675,
                column: "title",
                value: "Nurse midwives    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 676,
                column: "title",
                value: "Electricians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 677,
                column: "title",
                value: "Training and development managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 678,
                column: "title",
                value: "Community and social service specialists, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 679,
                column: "title",
                value: "Political scientists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 680,
                column: "title",
                value: "Social workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 681,
                column: "title",
                value: "Dietitians and nutritionists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 682,
                column: "title",
                value: "Health technologists and technicians, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 683,
                column: "title",
                value: "Marketing managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 684,
                column: "title",
                value: "Psychiatrists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 685,
                column: "title",
                value: "Biochemists and biophysicists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 686,
                column: "title",
                value: "Lodging managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 687,
                column: "title",
                value: "Telecommunications line installers and repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 688,
                column: "title",
                value: "Producers and directors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 689,
                column: "title",
                value: "Medical secretaries and administrative assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 690,
                column: "title",
                value: "Technical writers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 691,
                column: "title",
                value: "Tile and stone setters    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 692,
                column: "title",
                value: "Business teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 693,
                column: "title",
                value: "Dental assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 694,
                column: "title",
                value: "Locker room, coatroom, and dressing room attendants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 695,
                column: "title",
                value: "Barbers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 696,
                column: "title",
                value: "Database administrators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 697,
                column: "title",
                value: "Compensation, benefits, and job analysis specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 698,
                column: "title",
                value: "Computer network support specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 699,
                column: "title",
                value: "Health education specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 700,
                column: "title",
                value: "Electronics engineers, except computer    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 701,
                column: "title",
                value: "Set and exhibit designers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 702,
                column: "title",
                value: "Floor layers, except carpet, wood, and hard tiles    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 703,
                column: "title",
                value: "Farm labor contractors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 704,
                column: "title",
                value: "Septic tank servicers and sewer pipe cleaners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 705,
                column: "title",
                value: "Dental hygienists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 706,
                column: "title",
                value: "Securities, commodities, and financial services sales agents    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 707,
                column: "title",
                value: "Food scientists and technologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 708,
                column: "title",
                value: "Meeting, convention, and event planners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 709,
                column: "title",
                value: "Lawyers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 710,
                column: "title",
                value: "Financial and investment analysts    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 711,
                column: "title",
                value: "Magnetic resonance imaging technologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 712,
                column: "title",
                value: "First-line supervisors of entertainment and recreation workers, except gambling services    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 713,
                column: "title",
                value: "Phlebotomists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 714,
                column: "title",
                value: "Driver/sales workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 715,
                column: "title",
                value: "Hairdressers, hairstylists, and cosmetologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 716,
                column: "title",
                value: "Food batchmakers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 717,
                column: "title",
                value: "Motor vehicle operators, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 718,
                column: "title",
                value: "Highway maintenance workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 719,
                column: "title",
                value: "Insurance sales agents    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 720,
                column: "title",
                value: "Semiconductor processing technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 721,
                column: "title",
                value: "Shuttle drivers and chauffeurs    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 722,
                column: "title",
                value: "Chemical engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 723,
                column: "title",
                value: "Farm equipment mechanics and service technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 725,
                column: "title",
                value: "Archivists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 726,
                column: "title",
                value: "Agents and business managers of artists, performers, and athletes    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 727,
                column: "title",
                value: "Entertainers and performers, sports and related workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 728,
                column: "title",
                value: "Financial risk specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 729,
                column: "title",
                value: "Special effects artists and animators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 730,
                column: "title",
                value: "Transportation, storage, and distribution managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 731,
                column: "title",
                value: "Aerospace engineering and operations technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 732,
                column: "title",
                value: "Entertainment and recreation managers, except gambling    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 733,
                column: "title",
                value: "First-line supervisors of personal service workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 734,
                column: "title",
                value: "Medical records specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 735,
                column: "title",
                value: "Makeup artists, theatrical and performance    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 736,
                column: "title",
                value: "Aircraft cargo handling supervisors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 737,
                column: "title",
                value: "Biological science teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 738,
                column: "title",
                value: "Agricultural equipment operators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 739,
                column: "title",
                value: "Social and human service assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 740,
                column: "title",
                value: "Manicurists and pedicurists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 741,
                column: "title",
                value: "Optometrists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 742,
                column: "title",
                value: "Chiropractors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 743,
                column: "title",
                value: "Nurse anesthetists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 744,
                column: "title",
                value: "Athletes and sports competitors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 745,
                column: "title",
                value: "Skincare specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 746,
                column: "title",
                value: "Social and community service managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 747,
                column: "title",
                value: "Coaches and scouts    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 748,
                column: "title",
                value: "Engineering teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 749,
                column: "title",
                value: "Film and video editors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 750,
                column: "title",
                value: "Mechanical door repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 751,
                column: "title",
                value: "Healthcare social workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 752,
                column: "title",
                value: "Computer systems analysts    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 753,
                column: "title",
                value: "Umpires, referees, and other sports officials    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 754,
                column: "title",
                value: "Cargo and freight agents    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 755,
                column: "title",
                value: "Psychiatric technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 756,
                column: "title",
                value: "Computer occupations, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 757,
                column: "title",
                value: "Management analysts    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 758,
                column: "title",
                value: "Recreational vehicle service technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 759,
                column: "title",
                value: "Medical scientists, except epidemiologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 760,
                column: "title",
                value: "Museum technicians and conservators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 761,
                column: "title",
                value: "Database architects    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 762,
                column: "title",
                value: "Mechanical engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 763,
                column: "title",
                value: "Occupational health and safety technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 764,
                column: "title",
                value: "Exercise physiologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 765,
                column: "title",
                value: "Audiologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 766,
                column: "title",
                value: "Mental health and substance abuse social workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 767,
                column: "title",
                value: "Curators    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 768,
                column: "title",
                value: "Shampooers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 769,
                column: "title",
                value: "Clinical and counseling psychologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 770,
                column: "title",
                value: "Flight attendants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 771,
                column: "title",
                value: "Occupational therapists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 772,
                column: "title",
                value: "Light truck drivers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 773,
                column: "title",
                value: "Industrial engineers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 774,
                column: "title",
                value: "Therapists, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 775,
                column: "title",
                value: "Respiratory therapists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 776,
                column: "title",
                value: "Forensic science technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 777,
                column: "title",
                value: "Ophthalmic medical technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 778,
                column: "title",
                value: "Personal financial advisors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 779,
                column: "title",
                value: "Medical equipment repairers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 780,
                column: "title",
                value: "Occupational health and safety specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 781,
                column: "title",
                value: "Market research analysts and marketing specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 782,
                column: "title",
                value: "Exercise trainers and group fitness instructors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 783,
                column: "title",
                value: "Medical assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 784,
                column: "title",
                value: "Athletic trainers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 785,
                column: "title",
                value: "Community health workers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 786,
                column: "title",
                value: "Diagnostic medical sonographers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 787,
                column: "title",
                value: "Hearing aid specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 788,
                column: "title",
                value: "Forest fire inspectors and prevention specialists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 789,
                column: "title",
                value: "Marriage and family therapists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 790,
                column: "title",
                value: "Industrial machinery mechanics    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 791,
                column: "title",
                value: "Physical therapists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 792,
                column: "title",
                value: "Web and digital interface designers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 793,
                column: "title",
                value: "Orthotists and prosthetists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 794,
                column: "title",
                value: "Computer and information systems managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 795,
                column: "title",
                value: "Animal caretakers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 796,
                column: "title",
                value: "Computer numerically controlled tool programmers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 797,
                column: "title",
                value: "Animal trainers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 798,
                column: "title",
                value: "Financial managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 799,
                column: "title",
                value: "Genetic counselors    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 800,
                column: "title",
                value: "Health information technologists and medical registrars    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 801,
                column: "title",
                value: "Web developers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 802,
                column: "title",
                value: "Counselors, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 803,
                column: "title",
                value: "Nursing instructors and teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 804,
                column: "title",
                value: "Massage therapists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 805,
                column: "title",
                value: "Logisticians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 807,
                column: "title",
                value: "Health specialties teachers, postsecondary    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 808,
                column: "title",
                value: "Speech-language pathologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 809,
                column: "title",
                value: "Financial examiners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 810,
                column: "title",
                value: "Veterinarians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 811,
                column: "title",
                value: "Software quality assurance analysts and testers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 812,
                column: "title",
                value: "Cooks, restaurant    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 813,
                column: "title",
                value: "Personal care and service workers, all other    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 814,
                column: "title",
                value: "Veterinary assistants and laboratory animal caretakers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 815,
                column: "title",
                value: "Veterinary technologists and technicians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 816,
                column: "title",
                value: "Taxi drivers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 818,
                column: "title",
                value: "Solar photovoltaic installers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 819,
                column: "title",
                value: "Operations research analysts    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 820,
                column: "title",
                value: "Computer and information research scientists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 821,
                column: "title",
                value: "Actuaries    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 822,
                column: "title",
                value: "Occupational therapy assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 823,
                column: "title",
                value: "Software developers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 824,
                column: "title",
                value: "Physical therapist assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 825,
                column: "title",
                value: "Physician assistants    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 826,
                column: "title",
                value: "Epidemiologists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 827,
                column: "title",
                value: "Medical and health services managers    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 828,
                column: "title",
                value: "Information security analysts    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 829,
                column: "title",
                value: "Statisticians    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 830,
                column: "title",
                value: "Data scientists    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 831,
                column: "title",
                value: "Nurse practitioners    ");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 832,
                column: "title",
                value: "Wind turbine service technicians    ");
        }
    }
}
