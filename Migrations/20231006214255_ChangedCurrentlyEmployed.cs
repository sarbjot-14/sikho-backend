using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sikho_backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCurrentlyEmployed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "median_annual_wage",
                table: "Occupations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,3)");

            migrationBuilder.AlterColumn<float>(
                name: "decade_change_percentage",
                table: "Occupations",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,3)");

            migrationBuilder.AlterColumn<string>(
                name: "currently_employed",
                table: "Occupations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,3)");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "44.0", -17f, "44,330", "Word processors and typists    * Clerk Typist* Dictaphone Typist* Statistical Typist* Transcription Typist* Typist* Word Processor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.1", -0.6f, "48,370", "Watch and clock repairers    * Antique Clock Repairer* Chronometer Repairer* Clock Repair Technician* Clockmaker* Clocksmith* Horologist* Time Piece Repairer* Watchmaker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1.8", -0.5f, "60,210", "Roof bolters, mining    * Roof Bolter Operator* Roof Bolting Coal Miner* Underground Bolting Machine Operator* Underground Roof Bolter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.3", -2.3f, "36,130", "Cutters and trimmers, hand    * Fur Trimmer* Hand Cloth Cutter* Hand Fabric Cutter* Portable Machine Cutter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.1", -1.1f, "38,330", "Telephone operators    * 411 Directory Assistance Operator* Directory Assistance Operator* Information Operator* Local Telephone Operator* Long Distance Operator* Telephone Exchange Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "165.6", -43.1f, "36,190", "Data entry keyers    * Customs Entry Clerk* Data Entry Clerk* Data Input Clerk* Data Keyer* Data Processing Clerk* Data Typist* Key Punch Operator* Keypunch Operator* Keypuncher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "48.4", -12.1f, "34,670", "Switchboard operators, including answering service    * PBX Operator* Private Branch Exchange Operator* Telephone Answering Service Operator* Telephone Switchboard Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.5", -2.7f, "40,120", "Foundry mold and coremakers    * Airset Caster* Airset Molder* Core Stripper* Foundry Molder* Green Sand Molder* No Bake Molder* Sand Molder* Wax Pattern Coater" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "161.4", -35.3f, "48,780", "Legal secretaries and administrative assistants    * Accredited Legal Secretary* Certified Legal Secretary Specialist* Law Secretary* Legal Administrative Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "29.8", -6.5f, "29,690", "Pressers, textile, garment, and related materials    * Clothes Ironer* Clothes Presser* Clothing Presser* Garment Presser* Pants Presser* Shirt Presser* Silk Presser* Wool Presser" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.3", -0.5f, "54,970", "Patternmakers, metal and plastic    * Metal Patternmaker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "0.6", -0.1f, "50,550", "Refractory materials repairers, except brickmasons    * Bondactor Machine Operator* Cupola Repairer* Kiln Door Builder* Ladle Repairer* Refractory Repairer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "511.1", -108.1f, "65,980", "Executive secretaries and executive administrative assistants    * Executive Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.1", -0.9f, "36,820", "Manufactured building and mobile home installers    * Housetrailer Servicer* Mobile Home Mechanic* Mobile Home Servicer* Mobile Home Technician* Modular Home Crew Member" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "97.7", -20.1f, "31,030", "Telemarketers    * Inbound Telemarketer* Outbound Telemarketer* Telemarketing Sales Representative* Telephone Solicitor* Telesales Representative* Telesales Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.5", -2.8f, "36,960", "Grinding and polishing workers, hand    * Hand Buffer* Hand Sander* Jewelry Grinder* Jewelry Polisher* Knife Grinder* Ring Polisher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "50.9", -9.6f, "50,850", "Engine and other machine assemblers    * Aircraft Engine Assembler* Assembling Motor Builder* Clutch Housing Assembler* Engine Builder* Gas Turbine Assembler* Generator Assembler* Jet Engine Assembler* Machine Builder* Sewing Machine Assembler* Steam Turbine Assembler* Truck Transmission Assembler* Truck Transmission Builder" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.4", -0.6f, "57,620", "Model makers, metal and plastic    * Metal Mockup Maker* Plastic Jig and Fixture Builder" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "0.4", -0.1f, "42,290", "Timing device assemblers and adjusters    * Digital Watch Assembler* Electrical Timing Device Adjuster* Marine Chronometer Assembler* Time Stamp Assembler" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.6", -1.2f, "42,450", "Drilling and boring machine tool setters, operators, and tenders, metal and plastic    * Bore Mill Operator for Plastic* Boring Mill Operator for Metal* Drill Press Operator for Metal* Horizontal Boring Mill Operator for Metal* Radial Drill Operator for Plastic* Radial Drill Press Operator for Plastic* Reaming Machine Operator for Plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "132.8", -24.2f, "38,060", "Order clerks    * Catalogue Clerk* Classified Ad Clerk* Mail Order Clerk* Order Desk Clerk* Service Order Clerk* Subscription Clerk* Want Ad Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "54.5", -9.8f, "33,160", "Floral designers    * Corsage Maker* Floral Arranger* Floral Artist* Floral Decorator* Florist* Florist Designer* Flower Arranger" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.7", -1.7f, "41,600", "Electronic equipment installers and repairers, motor vehicles    * Auto Electrician* Auto Phone Installer* Auto Radio Mechanic* Automotive Electrician* Car Alarm Installer* Car Stereo Installer* GPS Car Navigation Installer* Mobile Electronics Installation Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "5.4", -1f, "63,920", "Loading and moving machine operators, underground mining    * Coal Hauler Operator* Coke Loader* Joy Loader* Load Haul Dump Operator* Mine Shuttle Car Operator* Mobile Bridge Conveyor Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "25.7", -4.4f, "43,560", "Prepress technicians and workers    * Digital Proofing and Platemaker* Electronic Pre-Press Technician* Photoengraver* Plate Mounter* Pre-Press Proofer* Prepress Stripper* Type Setter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.1", -1.8f, "43,160", "Coil winders, tapers, and finishers    * Coil Builder* Coil Former* Coil Winder* Motor Rewinder* Motor Winder* Multiple Coil Winder* Rotor Coil Taper* Wire Coiler* Wire Winder* Wire Winding Machine Tender" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "165.4", -27.2f, "49,630", "Payroll and timekeeping clerks    * Flight Crew Time Clerk* Payroll Bookkeeper* Personnel Scheduler* Time Clerk* Time and Attendance Clerk* Timekeeper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "59.6", -9.8f, "47,200", "Structural metal fabricators and fitters    * Mill Beam Fitter* Protector Plate Attacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "41.4", -6.8f, "36,970", "Print binding and finishing workers    * Bindery Cutter Operator* Bindery Folder Operator* Bindery Machine Operator* Bindery Worker* Book Repairer* Bookbinder* Bookbinding Machine Operator* Case Binder Operator* Foil Stamp Operator* Perfect Binder Operator* Saddle Stitch Operator* Saddle Stitcher Operator* Spiral Binder Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "91.1", -14.6f, "37,290", "File clerks    * Cut File Clerk* Document Clerk* File Keeper* Index Clerk* Records Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "36.4", -5.8f, "31,100", "Door-to-door sales workers, news and street vendors, and related workers    * Newspaper Carrier* Newstand Vendor* Peddler* Souvenir Street Vendor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.9", -1.1f, "31,530", "Sewers, hand    * Hand Quilter* Hand Sewer* Hand Stitcher* Hand Weaver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "141.9", -21.6f, "31,740", "Sewing machine operators    * Blind Stitch Machine Operator* Button Sewing Machine Operator* Carpet Sewing Machine Operator* Custom T-Shirt Embroidery Machine Operator* Embroidery Machine Operator* Hemming and Tacking Machine Operator* Ultrasonic Seaming Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "33.9", -5.1f, "58,430", "Aircraft structure, surfaces, rigging, and systems assemblers    * Aircraft De-Icer Installer* Aircraft Fuselage Framer* Aircraft Layout Worker* Aircraft Line Assembler* Aircraft Part Assembler* Aircraft Riveter* Aircraft Sheet Metal Mechanic* Helicopter Airframe Mechanic* Propeller Layout Worker* Wing Coverer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.9", -1.6f, "46,540", "Forging machine setters, operators, and tenders, metal and plastic    * Cold Header Operator* Forging Roll Operator* Header Setup Operator* Spike Machine Operator* Swager Operator* Swaging Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "364.1", -52.9f, "36,380", "Tellers    * Bank Teller* Commercial Teller* Exchange Teller* Foreign Banknote Teller* Foreign Exchange Clerk* Loan Teller* Money Order Clerk* Receiving Teller* Savings Teller* Securities Teller" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "46.6", -6.7f, "40,820", "New accounts clerks    * Banking Services Clerk* New Accounts Banking Representative* New Client Banking Services Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "31.6", -4.5f, "36,710", "Office machine operators, except computer    * Business Machine Operator* Coin Machine Operator* Coin Rolling Machine Operator* Coin Wrapping Machine Operator* Collator Operator* Copy Center Operator* Copy Machine Operator* Duplicating Machine Operator* Scanning Equipment Operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "15.7", -2.2f, "46,870", "Milling and planing machine setters, operators, and tenders, metal and plastic    * Metal Milling Machine Operator* Metal Rotary Head Milling Machine Setup Operator* Plastic Thread Milling Machine Setup Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "742.0", -101.6f, "27,640", "Cooks, fast food    * Fast Food Cook* Fast Food Fry Cook* Fryline Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "33.9", -4.6f, "34,280", "Tailors, dressmakers, and custom sewers    * Alterations Sewer* Alterations Tailor* Bridal Gown Fitter* Coat Cutter* Coat Maker* Couture Dressmaker* Dress Fitter* Fur Tailor* Garment Fitter* Suit Maker* Vest Maker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.5", -1.1f, "47,910", "Desktop publishers    * DTP Operator* Desktop Publishing Specialist* Electronic Console Display Operator* Electronic Imager* Electronic Pagination System Operator* Electronic Publisher* Electronic Publishing Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "42.2", -5.3f, "58,590", "Adult basic education, adult secondary education, and english as a second language instructors    * Adult Basic Studies Teacher* Adult Education Teacher* Adult English as a Second Language (ESL) Teacher* Adult Literacy Instructor* Adult Literacy Teacher* Adult Remedial Education Instructor* GED¿ Instructor* General Educational Development (GED¿) Teacher* General Educational Development Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "32.2", -4f, "93,060", "Power plant operators    * Hydroelectric Plant Operator* Power Plant Control Room Operator* Powerhouse Operator* Turbine Room Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.4", -0.8f, "36,280", "Photographic process workers and processing machine operators    * Digital Imaging Technician* Digital Photo Printer* Digital Photo Technician* Digital Retoucher* Film Developing Machine Operator* Film Printer* Film Process Operator* Film Processor* Photo Lab Specialist* Photo Lab Technician* Photo Machine Operator* Photo Print Specialist* Photo Retoucher* Print Retoucher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.3", -0.3f, "64,180", "Underground mining machine operators, all other    * Clay Mine Cutting Machine Operator* Long Wall Mining Machine Tender* Long Wall Operator* Long Wall Plow Operator* Long Wall Shear Operator* Long Wall Shearer* Mine Cutting and Channeling Machine Operator* Rock Dust Sprayer* Rock Duster* Shale Planer Operator* Shearer Operator* Underground Jumbo Driller" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "21.1", -2.6f, "44,760", "Meter readers, utilities    * Electric Meter Reader* Gas Meter Reader* Water Meter Reader" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1.6", -0.2f, "52,330", "Terrazzo workers and finishers    * Granite-Chip Terrazzo Finisher* Marble-Chip Terrazzo Worker* Onyx-Chip Terrazzo Worker* Rustic Terrazzo Setter* Terrazzo Finisher* Terrazzo Grinder* Terrazzo Installer* Terrazzo Layer* Terrazzo Setter* Terrazzo Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.8", -1.7f, "79,460", "Gas plant operators    * Gas Controller* Gas Plant Dispatcher* Gas Plant Technician* Natural Gas Plant Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2,030.2", -235.9f, "41,000", "Secretaries and administrative assistants, except legal, medical, and executive    * Alumni Secretary* Office Secretary* Personal Secretary* Real Estate Administrative Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "28.0", -3.2f, "41,750", "Broadcast announcers and radio disc jockeys    * Commercial Announcer* Game Show Host* Radio Artist* Radio Disc Jockey* Radio Host* Talk Show Host* Television Host" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "115.0", -13f, "49,130", "Postal service mail sorters, processors, and processing machine operators    * Flat Sorter Operator* Flat Sorting Machine Clerk* Mail Forwarding System Markup Clerk* Parcel Post Distribution Machine Operator* Post Office Markup Clerk* Postal Service Mail Processor* Small Package and Bundle Sorter Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "147.4", -16.6f, "97,800", "Computer programmers    * Applications Programmer* Computer Language Coder* Computer Programmer* IT Programmer* Junior Software Developer* Mainframe Programmer* Systems Programmer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "25.1", -2.8f, "45,240", "Carpet installers    * Carpet Layer* Commercial Carpet Installer* Residential Carpet Installer* Wall-to-Wall Carpet Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "18.2", -2f, "47,400", "Locksmiths and safe repairers    * Key Maker* Keysmith* Lock Expert* Lock Fitter* Lock Setter* Lock Technician* Locksmith* Safe and Vault Installer* Safe and Vault Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "92.7", -10.2f, "45,710", "Paper goods machine setters, operators, and tenders    * Box Fabricator* Carton Making Machine Operator* Corrugated Box Machine Operator* Corrugator Machine Operator* Corrugator Operator* Envelope Machine Operator* Napkin Machine Operator* Paper Bag Machine Operator* Paper Cone Machine Tender* Paper Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "28.2", -3.1f, "46,310", "Rolling machine setters, operators, and tenders, metal and plastic    * Brass Roller* Forming Roll Operator* Metal Sheet Roller Operator* Pipe Straightener* Plastic Straightening Roll Operator* Steel Roller" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.8", -1.1f, "32,460", "Shoe and leather workers and repairers    * Cobbler* Leather Lacer* Leather Worker* Luggage Repairer* Saddle Maker* Saddle and Harness Maker* Shoe Maker* Shoe Repairer* Shoemaker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "184.8", -20.1f, "39,340", "Cutting, punching, and press machine setters, operators, and tenders, metal and plastic    * Crimping Machine Operator for Metal* Four Slide Machine Setter* Metal Punch Press Operator* Metal Slitter* Metal Stamper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.9", -2f, "39,430", "Helpers--brickmasons, blockmasons, stonemasons, and tile and marble setters    * Adobe Layer Helper* Brick Carrier* Brick Washer* Bricklayer Helper* Ceramic Tile Installation Helper* Chimney Builder Helper* Firebrick Layer Helper* Marble Installation Helper* Mortar Mixer* Parquet Floor Layer's Helper* Refractory Tile Helper* Wood Tile Installation Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.3", -0.4f, "33,060", "Shoe machine operators and tenders    * Arch Cushion Press Operator* Insole Beveler* Lacing Operator* Lasting Machine Operator* Pump Stitcher* Rasper Machine Operator* Shoe Cementer* Shoe Sewing Machine Operator and Tender* Sole Trimmer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "96.4", -10.4f, "44,910", "Computer, automated teller, and office machine repairers    * ATM Servicer* Cash Register Servicer* Computer Repair Technician* Computer Repairer* Computer Service Technician* Copier Technician* Copying Machine Repairer* Data Processing Equipment Repairer* Photocopying Equipment Repairer* Printer Repair Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.1", -1.2f, "34,420", "Textile cutting machine setters, operators, and tenders    * Bedspread Cutter* Canvas Cutter* Cloth Cutter* Industrial Fabric Cutter* Textile Slitting Machine Operator* Twill Cutter* Upholstery Cutter* Welt Trimming Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.8", -1.9f, "35,750", "Textile knitting and weaving machine setters, operators, and tenders    * Crochet Machine Operator* Jacquard Loom Weaver* Knitter Operator* Knitting Machine Operator* Loom Operator* Looping Machine Operator* Warp Knitting Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3,345.8", -348.1f, "28,240", "Cashiers    * Cash Register Operator* Check Out Cashier* Fare Collector* Grocery Checker* Hotel Dining Room Cashier* Snack Bar Cashier* Toll Booth Operator* Toll Collector" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.1", -0.7f, "58,260", "Layout workers, metal and plastic    * Shipfitter* Shipfitter Apprentice" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "175.4", -17.7f, "38,700", "Interviewers, except eligibility and loan    * Admitting Interviewer* Census Clerk* Census Taker* Field Enumerator* Market Research Interviewer* Outpatient Interviewing Clerk* Survey Interviewer* Telephone Interviewer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "209.7", -20.1f, "39,470", "Bill and account collectors    * Accounts Collector* Bill Collector* Billing Representative* Collection Agent* Collections Clerk* Collections Representative* Debt Collector* Installment Agent* Installment Loan Collector* Insurance Collector* Payment Collector* Repossessor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.1", -0.2f, "33,360", "Motion picture projectionists    * Chief Projectionist* Film Projector Operator* Motion Picture Operator* Motion Picture Projectionist* Movie Projectionist* Projector Booth Operator* Stereoptician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "75.0", -7.1f, "38,910", "Grinding, lapping, polishing, and buffing machine tool setters, operators, and tenders, metal and plastic    * Aluminum Polisher* Deburring Machine Operator* Jewel Bearing Facer* Metal Grinder* Tool Polishing Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.0", -0.7f, "32,680", "Textile bleaching and dyeing machine operators and tenders    * Cloth Dyer* Dye Range Operator* Rug Dyer* Skein Yarn Dyer* Yarn Dyer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "32.9", -3.1f, "37,900", "Plating machine setters, operators, and tenders, metal and plastic    * Anodizer* Chrome Plater* Chromium Plater* Copper Plater* Electro Plater* Electrogalvanizing Machine Operator* Electroplater* Galvanizer* Hard Chrome Plater* Metal Plater* Metal Spraying Machine Operator* Metalizing Machine Operator* Nickel Plater* Plating Machine Operator* Tin Plater" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.7", -1.9f, "47,020", "Lathe and turning machine tool setters, operators, and tenders, metal and plastic    * Engine Lathe Operator* Gear Cutter* Screw Machine Operator* Screw Machine Tool Setter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.0", -0.7f, "38,150", "Musical instrument repairers and tuners    * Accordion Repairer* Band Instrument Repair Technician* Banjo Repairer* Bow Rehairer* Brass and Wind Instrument Repairer* Chip Tuner* Fretted String Instrument Repairer* Guitar Builder* Guitar Repairer* Keyboard Instrument Repairer* Luthier* Mandolin Repairer* Organ Installer* Organ Tuner* Percussion Instrument Repairer* Piano Regulator* Piano Technician* Piano Tuner* Pipe Organ Technician* Stringed Instrument Repairer* Tone Regulator* Violin Repairer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.5", -0.6f, "49,160", "Fallers    * Lumberjack* Pulpwood Cutter* Timber Cutter* Timber Faller* Timber Feller" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "193.0", -17.9f, "34,670", "Helpers--production workers    * Blending Tank Helper* Commercial Baker Helper* Machinist Helper* Slitter Helper* Tailor Helper* Welder Helper* Woodworker Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.0", -1.5f, "40,900", "Heat treating equipment setters, operators, and tenders, metal and plastic    * Annealing Furnace Operator* Carburizing Furnace Operator* Flame Hardening Machine Setter* Heat Treater Apprentice* Heat Treating Furnace Tender* Induction Machine Setter* Wire Annealer* Wire Temperer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.2", -0.6f, "45,070", "Pourers and casters, metal    * Aluminum Pourer* Ingot Caster* Iron Pourer* Molten Iron Pourer* Steel Pourer* Tin Pourer* White Metal Caster" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "43.7", -3.9f, "54,680", "Brokerage clerks    * Brokerage Purchase-and-Sale Clerk* Commodities Clerk* Dividend Clerk* Securities Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.3", -1f, "32,270", "Forest and conservation workers    * Forest Nursery Worker* Forester Aide* Forestry Laborer* Pine Straw Gatherer* Rangelands Conservation Laborer* Reforestation Worker* Seedling Puller* Wetlands Conservation Laborer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "25.0", -2.2f, "33,720", "Textile winding, twisting, and drawing out machine setters, operators, and tenders    * Rope Machine Setter* Roving Winder* Silk Winding Machine Operator* Twister Operator* Winder Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "155.5", -13.2f, "39,350", "Printing press operators    * Digital Press Operator* Flexographic Press Operator* Gravure Press Operator* Lithograph Press Operator* Lithographing Machine Operator* Offset Lithographic Press Setter and Set-Up Operator* Offset Press Operator* Printing Machine Operator* Screen Printing Machine Operator* Screen Printing Press Operator* Silk Screen Operator* Silk Screen Printer* Web Offset Press Feeder* Web Press Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "62.7", -5.3f, "59,800", "Tool and die makers    * Jig Bore Tool Maker* Metal Die Finisher* Metal Gauge Maker* Plastic Die Maker Apprentice* Tool Maker* Toolmaker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "5.5", -0.5f, "41,940", "Tool grinders, filers, and sharpeners    * Tool Grinder* Tool Grinding Machine Operator* Tool Sharpener* Tool Straightener" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "862.9", -72.2f, "37,760", "Shipping, receiving, and inventory clerks    * Freight Clerk* Incoming Freight Clerk* Inventory Control Clerk* Inventory Taker* Receiving Clerk* Reconsignment Clerk* Route Delivery Clerk* Shipping Order Clerk* Shipping and Receiving Clerk* Stockroom Attendant* Stockroom Clerk* Store Receiving Clerk* Supply Clerk* Supply Room Clerk* Tool Crib Attendant* Warehouse Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "32.9", -2.8f, "44,920", "Welding, soldering, and brazing machine setters, operators, and tenders    * Brazing Machine Operator* Brazing Machine Setter and Setup Operator* Brazing Machine Tender* Electron Beam Welder Setter* Machine Welder* Reserve Tube Welder* Soldering Machine Operator* Soldering Machine Setter and Setup Operator* Soldering Machine Tender* Ultrasonic Welding Machine Operator* Welding Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "215.1", -17.8f, "38,660", "Office and administrative support workers, all other    * Braille Transcriber* Envelope Stuffer* Fingerprint Clerk* Investigation Clerk* Newspaper Inserter* Notary Public" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "280.0", -23f, "189,520", "Chief executives    * Admiral* CEO* COO* Chief Executive Officer* Chief Financial Officer* Chief Operating Officer* Chief Sustainability Officer* Commissioner of Internal Revenue* County Commissioner* Government Service Executive* Governor* Mayor* School Superintendent* University President" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.7", -1.6f, "50,280", "Metal-refining furnace operators and tenders    * Electric Arc Furnace Operator* Melt Room Operator* Smelter Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "181.8", -14.6f, "46,760", " " });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "21.4", -1.7f, "38,340", "Metal workers and plastic workers, all other    * Electrical Discharge Machine Setup Operator* Metal Rivet Machine Operator* Tin Recovery Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "18.7", -1.5f, "57,640", "Drafters, all other    * Blueprint Tracer* Drafting Layout Worker* Draughtsman* Geological Drafter* Marine Drafter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.3", -1.1f, "32,640", "Textile, apparel, and furnishings workers, all other    * Apparel Embroidery Digitizer* Feltmaker* Hat Blocking Machine Operator* Swatch Maker* Tassel Making Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "494.4", -38f, "67,620" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "65.3", -4.9f, "45,240", "Procurement clerks    * Procurement Assistant* Purchasing Assistant* Purchasing Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "1,500.4", -111.8f, "37,280" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "378.5", -28.6f, "49,610", "Correctional officers and jailers    * Certified Detention Deputy* Convict Guard* Correction Officer* Correctional Guard* Correctional Sergeant* Detention Deputy* Detention Officer* Jail Guard* Juvenile Corrections Officer* Penal Officer* Prison Guard* Prison Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.4", -0.2f, "60,320", "Fabric and apparel patternmakers    * Clothing Patternmaker* Embroidery Patternmaker* Fabric Pattern Grader" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "111.4", -8f, "58,450", "Advertising sales agents    * Advertising Account Executive* Advertising Agent* Advertising Solicitor* Display Advertising Sales Representative* Inside Sales Advertising Executive* Outside Sales Advertising Executive* Radio Time Salesperson* Signs and Displays Salesperson* Yellow Pages Space Salesperson" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "49.6", -3.6f, "61,310", "Mechanical drafters    * Aeronautical Drafter* Automotive Design Drafter* Die Designer* Gage Designer* Mechanical Design Drafter* Tool Designer* Tool and Die Designer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.9", -0.3f, "47,110", "Logging workers, all other    * Log Cutter* Log Peeler* Log Roper* Logging Laborer* Logging Swamper* Rigging Slinger* Timber Hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,405.8", -94f, "45,250", "First-line supervisors of retail sales workers    * Assistant Store Manager* Cashier Manager* Cashier Supervisor* Delicatessen Department Manager* Produce Department Supervisor* Sales Clerk Supervisor* Used Car Sales Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "314.5", -21f, "54,250", "Postal service mail carriers    * City Letter Carrier* Letter Carrier* Mail Deliverer* Parcel Post Carrier* Postal Mail Carrier* Rural Mail Carrier* Rural Route Carrier* USPS Letter Carrier" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "74.8", -5f, "56,200", "Postal service clerks    * Bulk Mail Clerk* Bulk Mail Technician* Parcel Post Clerk* Postal Clerk* Postal Service Clerk* Postal Service Window Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.0", -0.9f, "82,760", "Postmasters and mail superintendents    * Postal Supervisor* Postmaster" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2,668.2", -175.4f, "38,040", "Office clerks, general    * Administrative Clerk* Office Assistant* Office Clerk* Real Estate Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "26.9", -1.8f, "44,960", "Audiovisual equipment installers and repairers    * Cable Installation Technician* Electric Organ Checker* Electronic Musical Instrument Repairer* Home Stereo Equipment Installer* Home Theater Installer* Satellite Dish Installer* Stereo Equipment Installer* Television Installer* Television Repairer* Wireless Internet Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "124.8", -7.9f, "51,600", "Water and wastewater treatment plant and system operators    * Industrial Waste Treatment Technician* Lead Sewage Plant Operator* Liquid Waste Treatment Plant Operator* Sewage Plant Operator* Waste Treatment Operator* Wastewater Operator* Water Plant Operator* Water Treatment Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.9", -0.4f, "59,500", "Fish and game wardens    * Conservation Enforcement Officer* Fish Warden* Fish and Wildlife Warden* Game Warden* Wildlife Control Agent* Wildlife Officer* Wildlife and Game Protector" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,735.8", -108.3f, "45,860", "Bookkeeping, accounting, and auditing clerks    * Accounts Receivable Assistant* Accounts Receivable Clerk* Auditing Clerk* Bookkeeper* Fixed Capital Clerk* Foreign Exchange Position Clerk* Mortgage Accounting Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "137.4", -8.4f, "30,360", "Cooks, short order    * Griddle Attendant* Griddle Cook* Grill Cook* Short Order Fry Cook* Snack Bar Cook" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "78.6", -4.8f, "37,600", "Library technicians    * Cataloging Library Technical Assistant* Library Acquisitions Technician* Library Cataloging Technician* Library Circulation Technician* Library Technical Assistant* Serials or Bindery Library Technical Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.5", -0.8f, "50,210", "Stonemasons    * Banker Mason* Curbstone Setter* Granite Setter* Memorial Mason* Monument Mason* Rock Mason* Stone Chimney Mason* Stone Layer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.0", -0.4f, "38,700", "Correspondence clerks    * Claims Correspondence Clerk* Correspondence Representative* Correspondence Transcriber* Customer Service Correspondence Clerk* Fan Mail Editor* Medicare Correspondence Representative* Student Loan Correspondent" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "82.9", -4.8f, "31,150", "Library assistants, clerical    * Book Sorter* Braille and Talking Books Clerk* Circulation Clerk* Film Library Clerk* Library Aide* Library Assistant* Library Circulation Clerk* Library Clerk* Medical Library Assistant* Microfilm Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.4", -1f, "44,830", "Credit authorizers, checkers, and clerks    * Charge Authorizer* Commercial Credit Reviewer* Credit Authorizer* Credit Charge Authorizer* Credit Checker* Credit Investigator* Credit Processor* Credit Rating Checker* Credit Reference Clerk* Credit Report Checker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.4", -1.1f, "30,010", "Gambling change persons and booth cashiers    * Mutuel Teller* Slot Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2,982.9", -162.7f, "37,780", "Customer service representatives    * Complaint Clerk* Contact Center Specialist* Customer Complaint Clerk* Customer Contact Specialist* Customer Relations Representative* Customer Support Representative* Gas Distribution and Emergency Clerk* Passenger Relations Representative* Policyholder Information Clerk* Warranty Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "120.2", -6.6f, "49,330", "Chemical equipment operators and tenders    * Acid Purification Equipment Operator* Chemical Machine Tender* Chemical Process Equipment Operator* Chemical Processor* Chemical Treatment Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "34.0", -1.9f, "38,570", "Cooks, private household    * Certified Personal Chef* Personal Chef* Private Chef" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "12.2", -0.7f, "31,720", "Gambling cage workers    * Cage Cashier* Casino Cage Cashier* Casino Cashier* Gambling Cage Cashier* Gambling Cashier" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "199.4", -10.5f, "34,150", "Farmworkers, farm, ranch, and aquacultural animals    * Aquaculture Worker* Barn Hand* Barn Worker* Cattle Brander* Cattle Driver* Chicken Handler* Chicken Vaccinator* Cow Tender* Egg Gatherer* Farrowing Worker* Goat Herder* Groom* Hatchery Worker* Livestock Handler* Poultry Debeaker* Ranch Hand* Sheep Shearer* Shrimp Pond Laborer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "25.1", -1.3f, "37,490", "Helpers--carpenters    * Beam Builder Helper* Building Carpenter Helper* Carpenter Assistant* Carpenter Helper* Construction Carpenters Helper* Hardwood Floor Installation Helper* House Carpenter Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,567.2", -80.7f, "61,370", "First-line supervisors of office and administrative support workers    * Accounts Payable Supervisor* Billing Department Supervisor* Billing Supervisor* Clerical Supervisor* Data Entry Supervisor* Medical Billing Supervisor* Office Services Supervisor* Payroll Supervisor* Records Supervisor* Teller Supervisor* Timekeeping Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "30.1", -1.5f, "32,550", "Graders and sorters, agricultural products    * Apple Sorter* Cherry Sorter* Cotton Grader* Egg Grader* Fruit Sorter* Meat Grader* Oyster Sorter* Peanut Grader* Potato Sorter* Seed Sorter* Strawberry Sorter* Vegetable Sorter* Wool Grader" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "0.5", 0f, "44,290", "Patternmakers, wood    * Wood Die Maker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.6", -0.5f, "101,650", "Power distributors and dispatchers    * Power System Dispatcher* Steam Plant Control Room Operator* Steam and Power Panel Operator* Substation Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "107.6", -5.2f, "45,930", "Human resources assistants, except payroll and timekeeping    * Employment Clerk* HR Clerk* Personnel Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "931.8", -44.8f, "29,790", "Food preparation workers    * Deli Clerk* Deli Slicer* Food Preparer* Fruit and Vegetable Parer* Salad Maker* Sandwich Maker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "72.8", -3.4f, "35,070", "Mail clerks and mail machine operators, except postal service    * Direct Mail Clerk* Mailroom Clerk* Packaging Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "922.9", -42.3f, "75,760", "Farmers, ranchers, and other agricultural managers    * Agricultural Crop Farm Manager* Animal Husbandry Manager* Aquaculture Farm Manager* Beef Farm Operator* Christmas Tree Farm Manager* Dairy Farm Manager* Fish Hatchery Manager* Greenhouse Manager* Hatchery Manager* Orchard Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "35.4", -1.6f, "46,050", "Dental laboratory technicians    * Crown Ceramist* Crown and Bridge Dental Lab Technician* Crown and Bridge Technician* Dental Ceramist* Dental Laboratory Worker* Dental Mold Maker* Dental Technician* Orthodontic Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "38.0", -1.7f, "45,990", "Pipelayers    * Cast-Iron Drain Pipe Layer* Pipe Layer* Sewer Pipe Layer* Trench Pipe Layer* Water Main Pipe Layer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "73.0", -3.2f, "78,850", "Credit analysts    * Chief Credit Analyst* Credit Analyst* Credit Assessment Analyst* Credit Risk Analyst* Factorer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "36.6", -1.6f, "46,000", "Home appliance repairers    * Certified Appliance Service Technician* Electric Stove Installer* Gas Appliance Repairer* Gas Appliance Servicer* Home Appliance Installer* Stove Installer* Vacuum Cleaner Repair Person* Vacuum Cleaner Repairer* Washing Machine Installer* Washing Machine Repairer* Window Air Conditioner Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "18.9", -0.8f, "51,650", "Tire builders    * Auto Tire Recapper* Retreader* Tire Finisher* Tire Molder* Tire Retreader" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "55.8", -2.3f, "39,880", "Cutting and slicing machine setters, operators, and tenders    * Dog Food Shredder Operator* Glass Cutting Machine Operator* Insulation Cutter* Paper Cutter* Paper Slitter* Rubber Trimmer* Shearing Machine Tender* Trimming Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "206.2", -8.3f, "48,300", "Cement masons and concrete finishers    * Cement Mason* Cement Patcher* Concrete Finisher* Concrete Floor Installer* Concrete Mason* Concrete Smoother* Concrete Swimming Pool Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "122.1", -4.9f, "73,080", "Editors    * Advertising Editor* Art Editor* Book Editor* Copy Desk Chief* Copy Editor* Index Editor* Manuscript Editor* Newspaper Photo Editor* Publications Editor* Rewrite Editor* Scientific Publications Editor* Sports Editor* Technical Editor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.7", -0.5f, "66,920", "Boilermakers    * Boiler Fitter* Boiler Installer* Boiler Mechanic* Boiler Setter* Boiler Tester* Boilermaker Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.4", -0.3f, "28,940", "Gambling and sports book writers and runners    * Betting Clerk* Bingo Worker* Bookie* Casino Floor Runner* Keno Runner* Keno Writer* Race Book Writer* Race and Sports Book Writer* Sports Book Board Attendant* Sportsbook Ticket Writer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "595.4", -23f, "43,900", "Inspectors, testers, sorters, samplers, and weighers    * Ampoule Examiner* Bag Grader* Cigarette Examiner* Compressed Gas Tester* Machined Parts Quality Inspector* Petroleum Sampler* Quality Assurance Inspector* Quality Control Inspector* Quality Inspector* Spark Plug Tester" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "62.2", -2.4f, "48,810", "First-line supervisors of security workers    * Loss Prevention Supervisor* Security Guard Supervisor* TSA Screener Supervisor* Transportation Security Administration (TSA) Screener Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.2", -0.3f, "45,410", "Proofreaders and copy markers    * Braille Proofreader* Clerical Proofreader* Copy Reader* Editorial Assistant* Format Proofreader* Proofreader" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "49.0", -1.8f, "34,730", "Medical transcriptionists    * Certified Medical Transcriptionist* Medical Record Transcriber* Medical Stenographer* Medical Transcriber* Pathology Transcriptionist* Radiology Transcriptionist* Registered Medical Transcriptionist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "36.4", -1.4f, "48,350", "Excavating and loading machine and dragline operators, surface mining    * Dragline Oiler* Mining Back Hoe Operator* Mining Backhoe Operator* Mining Bulldozer Operator* Mining Earth Moving Equipment Operator* Mining End Loader Operator* Mining Excavator* Mining Excavator Backhoe Operator* Mining Payloader Operator* Mining Shovel Operator* Mining Yard Loader Operator* Trenching Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "35.3", -1.3f, "46,400", "Logging equipment operators    * Combination Slasher-Loader Operator* Delimber Operator* Feller Buncher Operator* Feller Operator* Grapple Operator* Grapple Skidder Operator* Loader Operator* Log Chipper Operator* Log Hauler* Log Loader Operator* Log Processor Operator* Log Stacker Operator* Logging Cable Skidder Operator* Logging Clam Bunk Operator* Logging Crane Operator* Logging Excavator Operator* Logging Forwarder Operator* Logging Operating Engineer* Logging Shovel Operator* Logging Slasher Operator* Logging Tractor Operator* Lumber Stacker Operator* Timber Harvester Operator* Tree Crusher Operator* Tree-Shear Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.8", -0.3f, "60,410", "Survey researchers    * Pollster* Survey Methodologist* Survey Questionnaire Designer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "167.9", -6.2f, "37,050", "Molding, coremaking, and casting machine setters, operators, and tenders, metal and plastic    * Aluminum Molding Machine Operator* Blow Mold Operator* Compression Molding Machine Operator* Plastic Cup Fabricating Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "62.4", -2.2f, "29,880", "School bus monitors    * Bus Monitor* School Bus Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.5", -0.5f, "35,370", "Woodworkers, all other    * Pole Framer* Timber Framer* Wood Carver* Wood Casket Assembler* Wood Veneer Taper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1.1", 0f, "46,940", "Model makers, wood    * Architectural Wood Model Maker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "72.5", -2.5f, "37,070", "Helpers--electricians    * Electrical Sign Wirer Helper* Electrician's Assistant* House Wirer Helper* Marine Electrician Helper* Stage Electrician Helper* Utilities Ground Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "28.8", -1f, "43,290", "Crushing, grinding, and polishing machine setters, operators, and tenders    * Beveling and Edging Machine Operator* Beveller Operator* Blanchard Grinder Operator* Crusher Plant Operator* Cullet Crusher and Washer* Industrial Coffee Grinder* Marble and Granite Polisher* Mix Crusher Operator* Pulverizer Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.5", -0.4f, "61,650", "Lighting technicians    * Dimmer Board Operator* Gaffer* Lamp Operator* Spotlight Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "58.5", -1.9f, "55,960", "News analysts, reporters, and journalists    * Book Critic* Book Reviewer* Columnist* Correspondent* Desk Reporter* Film Critic* Foreign Correspondent* Investigative Reporter* Journalist* Market News Reporter* Movie Critic* News Anchor* News Commentator* News Reporter* Newscaster* Newspaper Columnist* Newspaper Correspondent* Political Reporter* Press Writer* Society Reporter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "5.5", -0.2f, "115,870", "Nuclear power reactor operators    * Nuclear Control Room Operator* Nuclear Reactor Operator* Nuclear Station Operator* Reactor Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "259.0", -8.2f, "46,080", "Insurance claims and policy processing clerks    * Insurance Claims Clerk* Insurance Clerk* Insurance Examining Clerk* Insurance Policy Issue Clerk* Underwriting Assistant* Underwriting Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.3", -0.6f, "82,670", "Chemical plant and system operators    * Chemical Plant Operator* Chemical Treatment Plant Technician* Nitric Acid Plant Operator* Nitrogen Operator* Pharmaceutical Manufacturing Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.9", -0.4f, "57,360", "Continuous mining machine operators    * Bore Miner Operator* Continuous Mining Machine Coal Miner* Continuous Mining Machine Lode Miner* Continuous Mining Machine Miner* Self-Propelled Mining Machine Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2,194.1", -68.6f, "29,120", "Waiters and waitresses    * Cocktail Server* Cocktail Waitress* Dining Car Server* Restaurant Server* Wine Steward" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "329.0", -10.3f, "72,230", "Claims adjusters, examiners, and investigators    * Claims Analyst* Fire Claims Adjuster* Health Claims Examiner* Health Insurance Adjuster* Independent Insurance Adjuster* Medical Claims Analyst* Medical Claims Examiner* Property Damage Claims Adjustor* Property and Casualty Insurance Claims Examiner* Reinsurance Claims Analyst* Workers Compensation Claims Adjuster* Workers Compensation Claims Examiner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "74.8", -2.2f, "49,690", "Education and childcare administrators, preschool and daycare    * Childcare Center Administrator* Childcare Center Director* Early Head Start Director* Head Start Director* Prekindergarten Program Coordinator* Preschool Director" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "47.2", -1.4f, "47,140", "Jewelers and precious stone and metal workers    * Diamond Grader* Diamond Polisher* Diamond Setter* Facetor* Gem Cutter* Gemologist* Goldsmith* Jewelry Repairer* Jewelsmith* Lapidarist* Pewterer* Silversmith" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "231.4", -6.5f, "71,200", "Cost estimators    * Construction Estimator* Construction Job Cost Estimator* Crating and Moving Estimator* Electrical Estimator* Job Estimator* Production Cost Estimator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "55.6", -1.6f, "39,950", "Weighers, measurers, checkers, and samplers, recordkeeping    * Bean Weigher* Cheese Weigher* Freight Checker* Sample Checker* Scale Attendant* Scale Clerk* Scale Operator* Warehouse Checker* Weighing Station Operator* Wool Sampler" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "43.7", -1.2f, "33,270", "Pharmacy aides    * Certified Pharmacist Assistant* Pharmacist Aide* Pharmacist Assistant* Pharmacy Assistant* Pharmacy Clerk* Prescription Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "58.5", -1.6f, "63,310", "First-line supervisors of correctional officers    * Chief Jailer* Correctional Officer Sergeant* Correctional Supervisor* Corrections Sergeant* Prison Guard Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "26.1", -0.7f, "93,720", "Electrical and electronics repairers, powerhouse, substation, and relay    * Generating Station Mechanic* Power Transformer Repairer* Powerhouse Electrician* Protective Relay Technician* Relay Technician* Substation Electrician* Substation Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "15.2", -0.4f, "60,570", "Electro-mechanical and mechatronics technologists and technicians    * Electo-Mechanical and Mechatronics Technologist* Mechatronics Technician* Remotely Piloted Vehicle Engineering Technician* Robotics Testing Technician* Unmanned Aerial Vehicle Operator* Unmanned Air Systems Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "257.7", -6.6f, "28,910", "Hotel, motel, and resort desk clerks    * Assistant Innkeeper* Hotel Desk Clerk* Hotel Front Desk Clerk* Hotel Registration Clerk* Motel Clerk* Motel Front Desk Attendant* Resort Desk Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.6", -0.4f, "69,380", "Insurance appraisers, auto damage    * Auto Damage Appraiser* Auto Damage Insurance Appraiser* Automobile Damage Appraiser* Vehicle Damage Appraiser" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "31.5", -0.8f, "39,600", "Upholsterers    * Aircraft Seat Upholsterer* Auto Upholsterer* Chair Upholsterer* Dining Chair Seat Cushion Trimmer* Furniture Upholsterer* Seating Upholsterer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "125.5", -3f, "76,230", "Insurance underwriters    * Automobile and Property Underwriter* Bond Underwriter* Insurance Analyst* Insurance Underwriter* Insurance Writer* Underwriting Account Representative* Underwriting Service Representative" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "447.1", -10.2f, "29,080", "Dishwashers    * Dish Room Worker* Dishwasher* Silverware Cleaner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "32.2", -0.7f, "85,090", "Petroleum pump system operators, refinery operators, and gaugers    * Hydrotreater Operator* Oil Gauger* Oil Pipeline Dispatcher* Oil Pipeline Operator* Oil Refiner* Petroleum Plant Operator* Petroleum Refinery Control Panel Operator* Petroleum Refinery Operator* Petroleum Refining Equipment Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.1", -0.4f, "49,100", "Bailiffs    * City Bailiff* County Bailiff* Court Bailiff* Court Officer* Court Security Officer* Deputy Bailiff" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.3", -0.4f, "39,860", "Extruding and forming machine setters, operators, and tenders, synthetic and glass fibers    * Drawbench Operator* Fiber Machine Tender* Synthetic Filament Extruder" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "18.1", -0.4f, "62,360", "Tapers    * Drywall Taper* Sheet Rock Taper* Wall Taper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "523.5", -11.3f, "33,000", "Farmworkers and laborers, crop, nursery, and greenhouse    * Cane Cutter* Carrot Harvester* Citrus Picker* Corn Picker* Cotton Picker* Crop Picker* Flower Picker* Greenhouse Transplanter* Harvest Worker* Harvester* Orchard Hand* Orchard Worker* Pecan Gatherer* Pepper Picker* Vineyard Tender" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "364.4", -8f, "82,850", "First-line supervisors of non-retail sales workers    * Blood Donor Recruiter Supervisor* Insurance Sales Supervisor* Radio Time Sales Supervisor* Real Estate Sales Supervisor* Stock Broker Supervisor* Telemarketer Supervisor* Telemarketing Manager* Telesales Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.2", -0.4f, "63,280", "Wellhead pumpers    * Oil Field Pumper* Oil Well Pumper* Oilfield Plant and Field Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.4", -0.3f, "38,780", "Adhesive bonding machine operators and tenders    * Glue Line Operator* Glue Machine Operator* Glue Reel Operator* Paper Gluing Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3,765.6", -79.1f, "30,600", "Retail salespersons    * Automotive Salesperson* Department Store Salesperson* Menswear Salesperson* New Car Salesperson* Pet Supplies Salesperson* Pets Salesperson* Shoe Salesperson* Used Car Salesperson* Women's Apparel Salesperson" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.9", -0.1f, "59,990", "Gas compressor and gas pumping station operators    * Acetylene Gas Compressor* Butane Compressor Operator* Compressor Station Operator* Gas Compressor Operator* Gas Cylinder Processor* Gas Storage Operator* High Pressure Compressed Gas Filler* LNG Plant Operator* Liquid Natural Gas Plant Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "945.9", -18.5f, "28,520", "Childcare workers    * Au Pair* Baby Sitter* Before and After School Daycare Worker* Childcare Aide* Childcare Attendant* Day Care Attendant* Day Care Worker* Daycare Aide* Daycare Provider* Governess* Nanny* Nursery Day Care Worker* Playground Aide" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.7", -0.2f, "53,450", "Farm and home management educators    * 4-H Youth Development Specialist* Agricultural Agent* Agricultural Extension Educator* Extension Service Advisor* Family Resource Management Specialist* Family and Consumer Sciences Extension Agent* Farm Business Management Agent* Farm Management Specialist* Feed Management Advisor* Home Economics Expert" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "105.7", -2f, "38,810", "Cabinetmakers and bench carpenters    * Cabinet Builder* Cabinetmaker* Marquetry Worker* Wood Furniture Assembler* Wood Working Assembler" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "64.3", -1.2f, "39,970", "Extruding and drawing machine setters, operators, and tenders, metal and plastic    * Wire Drawing Machine Tender* Wire Mill Rover" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.6", -0.1f, "51,600", "Extraction workers, all other    * Mine Milling Worker* Mine Tailings Worker* Muck Hauler, Extraction* Sand Filler, Extraction" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.8", 0f, "58,950", "Hoist and winch operators    * Hoist Operator* Winch Derrick Operator* Winch Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "39.2", -0.7f, "39,690", "Coin, vending, and amusement machine servicers and repairers    * Arcade Games Mechanic* Coin Box Collector* Juke Box Mechanic* Parking Meter Collector* Slot Machine Mechanic* Slot Technician* Stamp Machine Servicer* Vending Machine Filler" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.4", -0.1f, "48,880", "Statistical assistants    * Actuarial Assistant* Actuary Clerk* Data Analysis Assistant* Statistical Clerk* Tariff Compiling Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "5.6", -0.1f, "42,370", "Log graders and scalers    * Log Check Scaler* Log Grader* Log Scaler* Log Sorter* Timber Estimator* Veneer Grader" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "142.4", -2.2f, "64,480", "Construction and building inspectors    * Architectural Inspector* Bridge Inspector* Building Code Inspector* Building Inspector* Construction Inspector* Electrical Inspector* Elevator Inspector* Highway Inspector* Home Inspector* Plumbing Inspector* Public Works Inspector* Residential Building Inspector" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.0", -0.1f, "41,570", "Parking enforcement workers    * Meter Maid* Parking Enforcement Officer* Parking Meter Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,155.9", -14.9f, "34,750", "Security guards    * Armed Guard* Bank Guard* Bodyguard* Bouncer* Private Watchman* Security Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "184.4", -2.3f, "29,060", "Laundry and dry-cleaning workers    * Drycleaner* Launderer* Laundress* Laundry Attendant* Laundry Equipment Operator* Laundry Operator* Laundry Sorter* Laundry Worker* Precision Dyer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "60.0", -0.8f, "39,480", "Extruding, forming, pressing, and compacting machine setters, operators, and tenders    * Bowling Ball Molder* Brick Maker* Cigarette Stamper* Extrusion Press Operator* Paper Baling Machine Operator* Rubber Extrusion Operator* Sugar Presser* Tuber Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "5.9", -0.1f, "100,420", "Nuclear technicians    * Nuclear Monitoring Technician* Radiation Protection Technician* Radiochemical Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "131.6", -1.6f, "36,930", "Butchers and meat cutters    * Butcher* Butcher Apprentice* Halal Butcher* Kosher Butcher* Meat Carver* Meat Clerk* Meat Counter Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.6", -0.2f, "60,670", "Sound engineering technicians    * Audio Recording Engineer* Disc Recordist* Dub Room Engineer* Film Sound Engineer* Play Back Operator* Recording Engineer* Sound Assistant* Sound Cutter* Sound Designer* Sound Editor* Sound Effects Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "214.8", -2.3f, "44,830", "Dispatchers, except police, fire, and ambulance    * Airplane Dispatch Clerk* Auto Service Dispatcher* Bus Dispatcher* Crew Dispatcher* Maintenance Dispatcher* School Bus Dispatcher* Taxicab Dispatcher* Tow Truck Dispatcher* Train Dispatcher* Truck Dispatcher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "39.9", -0.4f, "60,700", "Broadcast technicians    * Broadcast Engineer* Broadcast Maintenance Engineer* Broadcast Operations Engineer* Radio Station Audio Engineer* Radio/Television Technician* Remote Broadcast Engineer* Telecasting Engineer* Television Audio Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "659.6", -6.6f, "32,920", "Packers and packagers, hand    * Bagger* Carton Wrapper* Egg Packer* Gift Wrapper* Grocery Store Bagger* Meat Packager* Meat Wrapper* Utility Bagger" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "247.1", -2.5f, "46,490", "Loan interviewers and clerks    * Loan Interviewer* Loan Processor* Mortgage Closing Clerk* Mortgage Loan Closer* Mortgage Loan Processing Clerk* Mortgage Loan Processor* Mortgage Processor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "81.1", -0.8f, "35,240", "Slaughterers and meat packers    * Beef Splitter* Cattle Killer* Halal Meat Packer* Hog Slaughterer* Meat Packer* Meat Processor* Poultry Slaughterer* Shochet* Slaughterer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "64.6", -0.6f, "36,830", "Woodworking machine setters, operators, and tenders, except sawing    * Computer Numerically Controlled (CNC) Wood Lathe Operator* Roof Truss Builder* Speed Belt Sander* Tenon Operator* Wood Boring Machine Operator* Wood Dowel Machine Operator* Wood Lathe Operator* Wood Planer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "64.6", -0.5f, "82,010", "Labor relations specialists    * Employee Relations Specialist* Industrial Relations Analyst* Industrial Relations Specialist* Labor Relations Consultant* Labor Relations Representative* Union Representative" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.8", 0f, "47,280", "Bridge and lock tenders    * Bridge Operator* Bridge Tender* Dam Tender* Lighthouse Keeper* Lock and Dam Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "53.6", -0.4f, "64,030", "Electrical and electronics repairers, commercial and industrial equipment    * Industrial Aerial Installer* Industrial Robotics Mechanic* Missile Pad Mechanic* Public Address System Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "35.2", -0.3f, "39,840", "Fence erectors    * Chain Link Fence Installer* Fence Builder* Wire Fence Builder* Wood Fence Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.2", -0.1f, "37,960", "Furniture finishers    * Cabinet Finisher* Furniture Refinisher* Furniture Sander* Piano Refinisher* Wood Cabinet Finisher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "47.9", -0.3f, "64,810", "Control and valve installers and repairers, except mechanical door    * Air Valve Mechanic* Electric Meter Installer* Gas Meter Installer* Gas Meter Mechanic* Thermostat Repairer* Valve Mechanic* Water Meter Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "113.0", -0.6f, "59,840", "Career/technical education teachers, postsecondary    * Architectural Drafting Instructor* Automotive Technology Instructor* Aviation Maintenance Instructor* Barbering Instructor* Building Trades Instructor* Carpentry Instructor* Computer-Aided Drafting and Design Instructor* Cosmetology Instructor* Electrical Technology Instructor* Electronics Technology Instructor* HVAC Instructor* Industrial Electrical Technology Instructor* Industrial Maintenance Instructor* Machine Tool Technician Instructor* Masonry Instructor* Mechanical Maintenance Instructor* Paralegal Instructor* Residential Construction Instructor* Skin Care Instructor* Upholstery Instructor* Vocational Horticulture Instructor* Welding Instructor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "27.3", -0.1f, "0", "Fishing and hunting workers    * Alligator Hunter* Bird Trapper* Commercial Crabber* Commercial Fisher* Crab Fisher* Crabber* Deer Hunter* Fishing Boat Captain* Fur Trapper* Lobster Catcher* Oyster Boat Laborer* Predator Control Trapper* Predatory Animal Exterminator* Predatory Animal Hunter* Predatory Animal Trapper* Seaweed Harvester* Shellfish Dredge Operator* Wild Oyster Harvester" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "22.6", -0.1f, "38,110", "Fiberglass laminators and fabricators    * Fiberglass Boat Builder* Fiberglass Fabricator* Fiberglass Grinder* Fiberglass Laminator* Fiberglass Luggage Molder* Fiberglass Machine Operator* Fiberglass Roller* Fiberglass Ski Maker* Fiberglasser" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "171.0", -0.4f, "49,380", "Directors, religious activities and education    * Campus Ministry Director* Christian Education Minister* Education Minister* Parish Religious Education Director* Religious Activities Director* Religious Education Coordinator* Religious Education Director* Student Ministries Director* Youth Ministry Director" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "88.0", -0.2f, "62,500", "Career/technical education teachers, secondary school    * High School Auto Repair Teacher* High School Cosmetology Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "82.8", -0.1f, "62,990", "Special education teachers, middle school    * Junior High School Special Education Teacher* Middle School Special Education Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.5", 0f, "37,980", "Etchers and engravers    * Engraver* Glass Etcher* Laser Engraver* Machine Engraver* Metal Engraver* Pantograph Engraver* Rotary Engraver* Rubber Engraver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "15.9", 0f, "57,470", "Plant and system operators, all other    * Asphalt Plant Operator* Concrete Batch Plant Operator* Lime Filter Operator* Sand Plant Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "126.2", -0.2f, "55,350", "Sheet metal workers    * Air Conditioning Sheet Metal Installer* Heating, Ventilation, and Air Conditioning (HVAC) Sheet Metal Installer* Sheet Metal Duct Installer* Sheet Metal Fabricator* Sheet Metal Former* Sheet Metal Installer* Sheet Metal Layout Mechanic* Sheet Metal Layout Worker* Tinsmith" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "194.7", -0.1f, "62,390" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.1", 0f, "62,630", "Career/technical education teachers, middle school    * Junior High School Business Teacher* Middle School Technology Education Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "12.1", 0f, "61,690", "Precision instrument and equipment repairers, all other    * Gyroscope Repairer* Scale Adjuster* Telescope Repairer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "51.3", 0f, "47,710", "Transportation security screeners    * Airport Baggage Screener* Airport Security Screener* Flight Security Specialist* Transportation Security Administration (TSA) Screener* Transportation Security Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "456.3", 0.1f, "42,810", "Billing and posting clerks    * Billing Clerk* Invoice Clerk* Invoice Control Clerk* Posting Clerk* Statement Clerk* Statement Distribution Clerk* Statement Processor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.2", 0f, "46,060", "Floor sanders and finishers    * Floor Finisher* Floor Refinisher* Floor Sander* Floor Sanding Machine Operator* Floor Scraper* Hardwood Finisher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.5", 0f, "38,270", "Painting, coating, and decorating workers    * Ceramic Painter* China Decorator* Glass Decorator* Lacquerer* Sign Painter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.2", 0f, "55,260", "Rotary drill operators, oil and gas    * Drilling Rig Operator* Fracturing Rotary Drill Operator* Natural Gas Shothole Driller* Oil Driller* Oil Rig Driller* Oil Well Cable Tool Driller* Oil Well Cable Tool Operator* Oil Well Driller* Prospecting Driller" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "49.4", 0.1f, "36,270", "Sawing machine setters, operators, and tenders, wood    * Backup Sawyer* Band Scroll Saw Operator* Bandmill Operator* Buzzsaw Operator* Chop Saw Operator* Circle Saw Operator* Curve Saw Operator* Cut Off Saw Operator* Hardwood Sawyer* Headrig Sawyer* Panel Saw Operator* Rip Saw Operator* Stave Saw Operator* Trim Saw Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "39.5", 0.1f, "50,140", "Service unit operators, oil and gas    * Oil Well Fishing-Tool Technician* Well Service Pump Equipment Operator* Well Service Rig Operator* Well Services Operator* Well Servicing Rig Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "1,298.9", 0.9f, "30,920" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,238.8", 1.6f, "29,960", "Maids and housekeeping cleaners    * Chambermaid* Cleaning Maid* Cottage Attendant* Domestic Maid* House Cleaner* Housekeeping Aide* Housekeeping Staff* Motel Maid* Ward Maid" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.1", 0f, "30,380", "Ambulance drivers and attendants, except emergency medical technicians    * Ambulance Attendant* Emergency Medical Services (EMS) Driver* Emergency Medical Services Driver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "48.4", 0.1f, "61,340", "Crane and tower operators    * Boom Crane Operator* Bridge Crane Operator* Cherry Picker Operator* Coal Tower Operator* Electric Crane Operator* Erecting Crane Operator* Monorail Crane Operator* Overhead Crane Operator* Port Crane Operator* Radio Control Crane Operator* Scrap Crane Operator* Tower Loader Operator* Woodyard Crane Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "51.4", 0.1f, "62,340", "Legal support workers, all other    * Legal Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "100.7", 0.2f, "30,850", "Automotive and watercraft service attendants    * Auto Service Station Attendant* Gas Pump Attendant* Gas Station Attendant* Gas and Oil Servicer* Oil Changer* Pump Jockey* Service Station Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1.0", 0f, "47,090", "Dredge operators    * Dredge Deckhand* Dredge Engineer* Dredge Mate* Dredger" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.5", 0f, "97,490", "Mining and geological engineers, including mining safety engineers    * Geophysical Engineer* Mineral Engineer* Mining Engineer* Seismic Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "681.7", 1.9f, "63,510", "First-line supervisors of production and operating workers    * Assembly Line Supervisor* Assembly Supervisor* Die Cast Supervisor* Machine Assembler Supervisor* Machinist Supervisor* Molding Supervisor* Paper Machine Supervisor* Printing Supervisor* Printing Worker Supervisor* Tool Room Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.1", 0f, "58,360", "Hydrologic technicians    * Groundwater Monitoring Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.2", 0.1f, "44,530", "Furnace, kiln, oven, drier, and kettle operators and tenders    * Calciner Operator* Dry Kiln Operator* Induction Furnace Operator* Lime Kiln Operator* Lumber Kiln Operator* Rubber Curer* Soap Drier Tender* Tunnel Kiln Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "18.1", 0.1f, "85,300", "Nuclear medicine technologists    * Certified Nuclear Medicine Technologist* Isotope Technologist* Nuclear Cardiology Technologist* Nuclear Medical Technologist* Radioisotope Technologist* Registered Nuclear Medicine Technologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,068.8", 3.9f, "33,960", "Receptionists and information clerks    * Appointment Clerk* Dental Receptionist* Front Desk Receptionist* Land Leasing Information Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.2", 0f, "43,130", "Models    * Artist's Model* Clothes Model* Fashion Model* Figure Model* Hand Model* Hat Model* Photographer's Model* Studio Model" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.9", 0.1f, "51,220", "Derrick operators, oil and gas    * Derrick Operator* Fracturing Derrick Operator* Gas Derrick Operator* Oil Derrick Operator* Rotary Derrick Operator* Well Service Derrick Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "73.0", 0.3f, "59,000", "Brickmasons and blockmasons    * Adobe Layer* Block Layer* Blockmason* Brick Chimney Builder* Brick Setter* Bricklayer* Brickmason* Brickmason Apprentice* Firebrick Layer* Furnace Mason* Pottery Kiln Builder* Refractory Bricklayer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "123.4", 0.7f, "60,490", "Kindergarten teachers, except special education    * Bilingual Education Kindergarten Teacher* Kindergarten Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "153.2", 0.7f, "63,560", "Special education teachers, secondary school    * High School Special Education Resource Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "357.5", 1.6f, "61,310", "Food service managers    * Banquet Director* Banquet Manager* Cafeteria Director* Food Service Director* Food and Beverage Manager* Restaurant General Manager* Tavern Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "412.8", 2f, "27,720", "Hosts and hostesses, restaurant, lounge, and coffee shop    * Bar Host/Hostess* Bar Hostess* Dining Room Host* Dining Room Host/Hostess* Maitre D'* Tearoom Host/Hostess* Tearoom Hostess" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.8", 0.1f, "35,970", "Gambling surveillance officers and gambling investigators    * Casino Investigator* Casino Surveillance Officer* Gambling Monitor* Gambling Surveillance Observer* Gambling Surveillance Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "31.5", 0.2f, "41,520", "Forest and conservation technicians    * Forest Technician* Forestry Aide* Forestry Technician* Natural Resources Technician* Soil Conservation Technician* Timber Management Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "41.1", 0.3f, "61,990", "Mechanical engineering technologists and technicians    * Gyroscopic Engineering Technician* Heat Transfer Technician* Hydraulic Technician* Mechanical Engineering Technician* Mechanical Engineering Technologist* Optomechanical Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "55.0", 0.3f, "57,950", "Tax examiners and collectors, and revenue agents    * City Collector* Customs Appraiser* Income Tax Adjuster* Internal Revenue Agent* Internal Revenue Service Agent* Revenue Collector* Revenue Enforcement Agent* Tax Compliance Officer* Tax Compliance Representative* Tax Examiner* Tax Investigator* Tax Revenue Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "75.8", 0.4f, "39,370", "Religious workers, all other    * Buddhist Monk* Christian Science Nurse* Missionary* Mohel* Nun* Pastoral Worker* Prior* Sacristan* Sunday School Missionary* Traveling Missionary* Verger" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "107.1", 0.6f, "59,820", "Architectural and civil drafters    * Architectural Drafter* Building Drafter* Civil Computer-Aided Design and Drafting Technician* Civil Drafter* Structural Drafter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "139.9", 0.8f, "39,210", "Multiple machine tool setters, operators, and tenders, metal and plastic    * Combination Machine Tool Operator* Multi-operation Forming Machine Setter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "172.4", 1f, "43,960", "Coating, painting, and spraying machine setters, operators, and tenders    * Aircraft Painter* Auto Body Painter* Auto Painter* Automobile Body Painter* Automobile Refinisher* Automotive Paint Technician* Automotive Refinish Technician* Automotive Spray Painter* Boat Painter* Electrostatic Paint Operator* Lacquer Spray Booth Operator* Paint Line Operator* Railroad Car Painter* Spraying Machine Operator* Tactical Vehicle Painter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "266.7", 1.5f, "55,550", "Clergy    * Cantor* Children's Pastor* College Chaplain* Hebrew Cantor* Hospital Chaplain* Imam* Minister* Parish Priest* Pastor* Priest* Rabbi* Reverend* Vicar* Youth Pastor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.0", 0.1f, "96,910", "Marine engineers and naval architects    * Marine Architect* Marine Equipment Engineer* Marine Structural Designer* Naval Engineer* Ships Equipment Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "23.6", 0.2f, "73,210", "Landscape architects    * Golf Course Architect* Golf Course Designer* Landscape Architect* Landscape Designer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,344.3", 9.1f, "63,230", "Sales representatives, wholesale and manufacturing, except technical and scientific products    * Bottling Equipment Sales Representative* Freight Broker* Hotel Supplies Salesperson* Mortician Supplies Sales Representative* Pulpwood Dealer* Wholesale Diamond Broker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,425.0", 10f, "61,690", "Elementary school teachers, except special education    * 3rd Grade Reading Teacher* 4th Grade Math Teacher* Elementary School Music Teacher* Elementary School Teacher* Grades 1 Through 5 Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.1", 0.1f, "30,350", "Gambling service workers, all other    * Card Table Attendant* Pit Clerk* Poker Prop Player* Proposition Player* Shill" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.2", 0.1f, "43,110", "Helpers--extraction workers    * Blaster Helper* Blasting Helper* Boring Machine Operator Helper* Continuous Miner Operator Helper* Driller Helper* Loading Machine Operator Helper* Longwall Machine Operator Helper* Mining Helper* Roof Bolter Helper* Rotary Drill Operator Helper* Shale Planer Operator Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "29.7", 0.2f, "74,570", "Locomotive engineers    * Freight Engineer* Railroad Engineer* Railway Engineer* Train Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "26.5", 0.2f, "239,200", "Surgeons, all other    * Aviation Medicine Specialist* Brain Surgeon* Cardiac Surgeon* Cardiovascular Surgeon* Colorectal Surgeon* Neurological Surgeon* Neurosurgeon* Otolaryngologist* Plastic Surgeon* Reconstructive Surgeon* Surgical Oncologist* Thoracic Surgeon* Urologist* Vascular Surgeon" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "48.7", 0.4f, "46,690", "Hazardous materials removal workers    * Asbestos Abatement Worker* Asbestos Remover* Decontamination Worker* Hazard Waste Handler* Hazmat Technician* Irradiated Fuel Handler* Lead Abatement Worker* Radiological Control and Safety Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "102.5", 0.8f, "66,390", "Electrical and electronic engineering technologists and technicians    * Electrical Design Technician* Electrical Engineering Technician* Electrical Power Station Technician* Electrical and Electronic Engineering Technologist* Electronic Instrument Testing Technician* Lighting Engineering Technician* Programmable Logic Controller Programmer* Semiconductor Development Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "625.5", 5.1f, "61,810", "Middle school teachers, except special and career/technical education    * Intermediate School Social Studies Teacher* Junior High School Teacher* Middle School PE Teacher* Middle School Science Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.0", 0f, "49,910", "Embalmers    * Anatomical Embalmer* Arterial Embalmer* Embalmer Apprentice* Licensed Embalmer* Restorative Art Embalmer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "21.8", 0.2f, "64,240", "Electrical and electronics drafters    * Circuit Board Drafter* Electrical Computer Aided Design and Drafting Technician* Electrical Drafter* Electrical Systems Drafter* Electronic Drafter* Printed Circuit Board Drafter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "35.9", 0.3f, "190,350", "Pediatricians, general    * General Pediatrician* Internal Medicine Pediatrician* Neonatal Doctor* Neonatologist* Paediatrician* Pediatric Cardiologist* Pediatrist* Primary Care Pediatrician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "64.8", 0.6f, "59,630", "Civil engineering technologists and technicians    * Civil Engineering Technician* Civil Engineering Technologist* Concrete Engineering Technician* Geotechnical Engineering Technician* Highway Engineering Technician* Structural Engineering Technician* Transportation Engineering Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "291.6", 2.5f, "54,360", "Bus and truck mechanics and diesel engine specialists    * Biodiesel Engine Specialist* Diesel Engine Fitter* Diesel Service Technician* Marine Diesel Technician* School Bus Mechanic* Tractor Trailer Mechanic* Truck Engine Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "956.3", 8.6f, "51,390", "Carpenters    * Beam Builder* Building Carpenter* Construction Carpenter* Counter Installer* Custom Wood Stair Builder* Finish Carpenter* Hardwood Floor Installer* House Carpenter* Wood Floor Layer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "0.8", 0f, "239,200", "Pediatric surgeons    * Pediatric Neurosurgeon* Pediatric Vascular Surgeon" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.6", 0.1f, "148,720", "Podiatrists    * Chiropodist* Doctor of Podiatric Medicine* Foot Doctor* Foot Orthopedist* Foot and Ankle Surgeon* Orthopedic Podiatrist* Podiatric Physician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "75.6", 0.8f, "29,120", "Gambling dealers    * 21 Dealer* Blackjack Dealer* Casino Dealer* Casino Games Dealer* Craps Dealer* Keno Dealer* Poker Dealer* Roulette Dealer* Table Games Dealer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "266.1", 2.6f, "35,800", "Parts salespersons    * Appliance Parts Counter Clerk* Auto Parts Salesperson* Electronic Parts Salesperson* Parts Clerk* Parts Counter Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,072.3", 11.1f, "62,360", "Secondary school teachers, except special and career/technical education    * High School Algebra Teacher* High School Biology Teacher* High School English Teacher* High School French Teacher* High School History Teacher* High School Math Teacher* High School Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.4", 0f, "44,060", "Camera and photographic equipment repairers    * Aircraft Photographic Equipment Repairer* Camera Machinist* Camera Repair Technician* Camera Repairer* Photographic Equipment Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1.5", 0f, "88,900", "Geographers    * Biogeographer* Economic Geographer* GIS Geographer* Geomorphologist* Glaciologist* Physical Geographer* Political Geographer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.2", 0.1f, "94,990", "Administrative law judges, adjudicators, and hearing officers    * Appeals Examiner* Appeals Referee* Appellate Conferee* Hearing Examiner* Hearing Officer* Justice of The Peace* Traffic Court Referee" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.9", 0.1f, "56,670", "Explosives workers, ordnance handling experts, and blasters    * Blast Setter* Blaster* Dynamite Shooter* Dynamiter* Explosive Ordnance Handler* Explosive Technician* Mining Powder Crew Worker* Tier and Detonator* Unexploded Ordnance Quality Control Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.8", 0.1f, "122,480", "Nuclear engineers    * Atomic Process Engineer* Nuclear Engineer* Nuclear Radiation Engineer* Nuclear Steam Supply System Engineer* Radiation Engineer* Reactor Engineer* Reactor Projects Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "21.3", 0.2f, "36,810", "Ophthalmic laboratory technicians    * Contact Lens Cutter* Contact Lens Technician* Eyeglass Assembler* Eyeglass Lens Cutter* Eyeglass Maker* Lens Grinder* Lens Grinder and Polisher* Lens Mounter* Precision Lens Centerer and Edger* Prescription Eyeglass Maker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "34.2", 0.4f, "68,180", "Railroad conductors and yardmasters    * Freight Conductor* Passenger Car Conductor* Train Conductor* Yard Conductor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "43.7", 0.5f, "47,130", "Financial clerks, all other    * Bank Vault Attendant* Bank Vault Clerk* Bank Vault Custodian* Financial Operations Clerk* Financial Reserve Clerk* Safe Deposit Clerk* Safety Deposit Clerk* Vault Teller" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "51.8", 0.6f, "62,940", "Music directors and composers    * Choir Director* Choirmaster* Chorus Master* Composer* Maestro* Music Adapter* Music Arranger* Music Copyist* Music Director* Music Minister* Music Pastor* Orchestra Conductor* Orchestra Director* Orchestrator* Songwriter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "103.8", 1.2f, "34,240", "Tire repairers and changers    * Auto Tire Worker* Tire Balancer* Tire Fixer* Tire Mechanic* Tire Mounter* Tire Servicer* Tire Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "300.4", 3.3f, "101,320", "Education administrators, kindergarten through secondary    * Elementary School Principal* High School Principal* Junior High School Principal* K-12 School Principal* K-8 School Principal* Middle School Principal* Secondary School Principal" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "12.2", 0.1f, "67,540", "Railroad brake, signal, and switch operators and locomotive firers    * Diesel Locomotive Firer* Dinkey Engine Firer* Freight Brake Operator* Locomotive Switch Operator* Railroad Brake Operator* Railroad Firer* Railway Switch Operator* Switch Coupler* Train Brake Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.6", 0.1f, "81,300", "Signal and track switch repairers    * Electric Track Switch Maintainer* Light Rail Signal Technician* Rail Signal Mechanic* Railway Signal Technician* Third Rail Installer* Train Control Electronic Technician* Train Control Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "22.8", 0.3f, "51,070", "Reinforcing iron and rebar workers    * Post Tensioning Ironworker* Rebar Worker* Reinforcing Steel Worker* Rod Buster* Steel Rod Buster* Steel Tier" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "41.6", 0.5f, "40,030", "Outdoor power equipment and other small engine mechanics    * Chain Saw Mechanic* Edge Trimmer Mechanic* Electric Golf Cart Repairers* Electric Wheelchair Repairer* Go-Cart Mechanic* Golf Cart Mechanic* Lawn Mower Repairer* Mobility Scooter Repairer* Power Saw Mechanic* Power Wheelchair Mechanic* Snowblower Mechanic* Snowmobile Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "70.1", 0.9f, "74,280", "English language and literature teachers, postsecondary    * Children's Literature Professor* Composition Professor* Contemporary English Literature Professor* Creative Writing English Professor* Etymology Professor* Medieval English Literature Professor* Seventeenth-Century English Literature Professor* Victorian Literature Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "153.3", 1.9f, "47,670", "Automotive body and related repairers    * Auto Body Customizer* Auto Body Technician* Auto Body Worker* Auto Bumper Straightener* Body Shop Worker* Body and Frame Technician* Car Refinisher* Truck Body Repairer* Vehicle Body Sander" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "173.5", 2.1f, "0", "Musicians and singers    * Accompanist* Baritone* Bassoonist* Bugler* Cellist* Choir Member* Church Organist* Clarinetist* Concert Pianist* Concert Singer* Double Bass Player* English Horn Player* Flutist* Guitar Player* Guitarist* Harpist* Horn Player* Instrumentalist* Musician* Oboist* Opera Singer* Organist* Percussionist* Pianist* Piano Player* Piccoloist* Rapper* Soloist* Tenor* Timpanist* Trombonist* Trumpet Player* Trumpeter* Violinist* Violist* Vocalist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.3", 0.1f, "87,300", "Ship engineers    * Barge Engineer* Ferry Engineer* Towboat Engineer* Tug Boat Engineer* Tugboat Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.9", 0.2f, "50,980", "Environmental engineering technologists and technicians    * Air Analysis Engineering Technician* Environmental Engineering Technologist* Environmental Remediation Engineering Technician* Environmental Technician* Pollution Control Engineering Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "22.8", 0.3f, "79,400", "History teachers, postsecondary    * African History Professor* American History Professor* Historiography Professor* Jewish History Professor* Russian History Professor* South Asian History Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "62.2", 0.8f, "81,500", "School psychologists    * Educational Psychologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "123.0", 1.6f, "39,160", "Reservation and transportation ticket agents and travel clerks    * Airline Reservation Agent* Airline Reservationist* Airline Ticket Agent* Gate Agent* Hotel Reservationist* Passenger Agent* Passenger Booking Clerk* Reservation Agent* Reservation Sales Agent* Train Clerk* Train Reservation Clerk* Transportation Clerk* Travel Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2,382.9", 29.9f, "31,990", "Janitors and cleaners, except maids and housekeeping cleaners    * Building Custodian* Cleaning and Maintenance Worker* Custodial Worker* Custodian* Floor Cleaner* Heavy Duty Custodian* Industrial Plant Custodian* Janitor* Office Cleaner* School Custodian* Window Cleaner* Window Washer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.5", 0.2f, "63,230", "Rail-track laying and maintenance equipment operators    * Ballast Cleaning Machine Operator* Rail Maintenance Worker* Railroad Track Mechanic* Track Layer* Track Machine Operator* Track Maintainer* Track Moving Machine Operator* Track Repair Worker* Track Repairer* Track Service Worker* Track Surfacing Machine Operator* Trackwalker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "23.0", 0.3f, "132,250", "Air traffic controllers    * Air Traffic Control Operator* Air Traffic Control Specialist* Air Traffic Coordinator* Airport Tower Controller* Control Tower Operator* Enroute Controller" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "24.7", 0.3f, "76,030", "Foreign language and literature teachers, postsecondary    * Arabic Professor* Biblical Languages Professor* Chinese Language Professor* French Professor* German Professor* Greek Professor* Hebrew Professor* Japanese Professor* Russian Language Professor* Spanish Literature Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.7", 0.3f, "54,680", "Riggers    * Acrobatic Rigger* Boat Rigger* Crane Rigger* Fly Rail Operator* Gantry Rigger* High Rigger* Marine Rigger* Parachute Rigger* Ship Rigger* Theatrical Rigger* Wire Rigger* Yacht Rigger* Yard Rigger" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "275.3", 3.9f, "35,490" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "358.8", 4.9f, "41,270", "Bus drivers, school    * School Bus Driver* School Bus Operator* Special Education Bus Driver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "431.8", 6.2f, "47,540", "Welders, cutters, solderers, and brazers    * Aluminum Welder* Arc Welder* Brazer* Certified Maintenance Welder* Cutting Torch Operator* Pipe Welder* Silver Solderer* Sub Arc Operator* Welder Fitter* Wire Welder" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.7", 0.1f, "36,080", "Helpers--painters, paperhangers, plasterers, and stucco masons    * Billboard Poster Helper* Bridge Painter Helper* Dry Plasterer Helper* Highway Painter Helper* House Painter Helper* Ornamental Plasterer Helper* Plaster Tender* Ship Painter Helper* Swimming Pool Plasterer Helper* Wallpaper Hanger Helper* Wallpaperer Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.6", 0.1f, "85,990", "Hydrologists    * Hydrogeologist* Isotope Hydrologist* Surface Hydrologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "25.1", 0.4f, "99,000", "Elevator and escalator installers and repairers    * Elevator Adjuster* Elevator Constructor* Elevator Installer* Elevator Mechanic* Elevator Repair and Maintenance Technician* Elevator Service Technician* Escalator Installer* Escalator Mechanic* Escalator Service Mechanic* Freight Elevator Erector* Hydraulic Elevator Constructor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "108.4", 1.6f, "30,570", "Parking attendants    * Auto Parker* Car Jockey* Parking Ramp Attendant* Valet Parker* Valet Runner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "109.5", 1.6f, "48,250", "Tax preparers    * Corporate Tax Preparer* Income Tax Advisor* Income Tax Preparer* Licensed Tax Consultant* Tax Consultant* Tax Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "114.4", 1.7f, "86,280", "Detectives and criminal investigators    * Criminal Investigator* Deputy United States Marshal* FBI Investigator* Homicide Detective* Narcotics Detective* Narcotics Investigator* Police Detective" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "114.0", 1.7f, "43,410", "Mixing and blending machine setters, operators, and tenders    * Asphalt Blender* Clay Mixer* Concrete Batcher* Dye Mixer* Glue Mixer* Ink Blender* Ink Mixer* Plaster Mixer* Resin Mixer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "195.4", 2.9f, "44,500", "Installation, maintenance, and repair workers, all other    * Bowling Alley Mechanic* Curtain Mender* Fabric Awning Repairer* Fire Extinguisher Installer* Gasoline Pump Installer* Gunsmith* Hand-Woven Carpet and Rug Mender* Parachute Repairer* Sail Repairer* Ski Lift Mechanic* Tarp Repairer* Wheelwright* Window Shade Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "372.4", 5.5f, "46,090", "Painters, construction and maintenance    * Bridge Painter* Facilities Painter* Highway Painter* House Painter* Industrial Painter* Parking Line Painter* Roof Painter* Traffic Line Painter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3,410.1", 50.4f, "27,930", "Fast food and counter workers    * Barista* Cafe Server* Cafeteria Server* Concession Stand Attendant* Food Counter Worker* Hot Dog Vender* Ice Cream Server* Mess Attendant* Snack Bar Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.3", 0.2f, "53,930", "Tank car, truck, and ship loaders    * Barge Loader* Bulk Tank Car Unloader* Dock Loader* Rail Car Loader* Rail Loader* Ship Unloader* Tank Car Loader* Tank Truck Loader" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.4", 0.3f, "239,200", "Orthopedic surgeons, except pediatric    * Joint Preservationist* Orthopaedic Surgeon* Orthopedic Sports Medicine Physician* Orthopedic Surgeon" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "27.3", 0.4f, "36,700", "Food cooking machine operators and tenders    * Doughnut Machine Operator* Dumpling Machine Operator* Fish Fryer* Food Cooking Machine Operator* Kettle Fry Cook Operator* Pierogi Maker* Potato Chip Frier* Tripe Cooker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "28.3", 0.4f, "37,820", "Helpers, construction trades, all other    * Boiler Coverer Helper* Bridge Ironworker Helper* Carpet Layer Helper* Cellulose Insulation Helper* Construction Ironworker Helper* Cork Insulator Helper* Drywall Hanger Helper* Drywall Stripper Helper* Drywall Taper Helper* HVAC Sheet Metal Installer Helper* Heat and Frost Insulator Helper* Linoleum Layer Helper* Ornamental Ironworker Helper* Pipe Insulator Helper* Plate Glass Installer Helper* Post Tensioning Ironworker Helper* Rod Buster Helper* Sheet Metal Duct Installer Helper* Sheet Rock Installation Helper* Sheet Rock Taper Helper* Stained Glass Glazier Helper* Terrazzo Finisher Helper* Terrazzo Layer Helper* Terrazzo Worker Helper* Trench Digger Helper* Wall Taper Helper* Window Glazier Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "106.6", 1.7f, "27,650", "Ushers, lobby attendants, and ticket takers    * Drive-In Theater Attendant* Lobby Attendant* Theater Usher* Ticket Attendant* Ticket Collector* Usher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "116.4", 1.9f, "50,440", "Drywall and ceiling tile installers    * Acoustical Ceiling Installer* Drywall Applicator* Drywall Finisher* Drywall Hanger* Drywall Installer* Drywall Sander* Drywall Stripper* Drywall Worker* Sheet Rock Applier* Sheet Rock Hanger* Sheet Rock Installer* Sheet Rock Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "217.1", 3.5f, "35,280", "Couriers and messengers    * Bank Courier* Bicycle Messenger* Courier* Court Messenger* Laboratory Courier* Office Messenger* Office Runner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "222.1", 3.6f, "107,560", "Industrial production managers    * Industrial Production Manager* Manufacturing Director* Plant Chief* Plant Manager* Plant Superintendent* Production Control Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "782.2", 12.8f, "46,970", "Automotive service technicians and mechanics    * Auto Clutch Rebuilder* Auto Clutch Specialist* Auto Radiator Specialist* Auto Suspension and Steering Mechanic* Auto Transmission Specialist* Automotive Alignment Specialist* Automotive Brake Adjuster* Automotive Brake Specialist* Automotive Brake Technician* Automotive Fuel Injection Servicer* Automotive Fuel Systems Converter* Automotive Specialty Technician* Hybrid Car Mechanic* Motor Tune-Up Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "21.9", 0.4f, "43,700", "Automotive glass installers and repairers    * Auto Glass Installer* Auto Glass Mechanic* Automotive Glass Technician* Automotive Glazier* Windshield Installer* Windshield Repair Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "27.2", 0.5f, "50,590", "Insulation workers, mechanical    * Boiler Coverer* Heat and Frost Insulator* Pipe Coverer* Pipe Insulator* Refrigeration Insulator* Sheet Metal Insulator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "34.4", 0.6f, "45,380", "Insulation workers, floor, ceiling, and wall    * Ceiling Insulation Blower* Composition Weatherboard Installer* Cork Insulation Installer* Cork Insulator* Insulation Machine Operator* Interior Surface Insulation Worker* Wall Insulation Sprayer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "36.5", 0.6f, "88,900", "Social scientists and related workers, all other    * Behavioral Scientist* Demographer* Ethnologist* Etymologist* Linguist* Philologist* Social Scientist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "39.6", 0.7f, "95,210", "Captains, mates, and pilots of water vessels    * Barge Captain* Barge Master* Boat Pilot* Car Ferry Captain* Car Ferry Master* Coastal Tug Mate* Deck Officer* Docking Pilot* Ferry Boat Captain* Ferry Captain* Ferryboat Captain* First Mate* Harbor Boat Pilot* Harbor Pilot* Harbor Tug Captain* Port Captain* River Boat Captain* River Pilot* Sailboat Captain* Ship Harbor Pilot* Tow Boat Captain* Towboat Pilot* Tug Boat Captain* Tugboat Captain* Tugboat Mate* Tugboat Operator* Tugboat Pilot" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "62.2", 1f, "50,490", "Title examiners, abstractors, and searchers    * Abstract Searcher* Abstract Writer* Advisory Title Officer* Escrow Officer* Land Title Examiner* Lease Examiner* Lien Searcher* Title Agent* Title Checker* Title Examiner* Title Inspector* Title Investigator* Title Officer* Title Searcher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.2", 0.2f, "35,720", "Agricultural workers, all other    * Crop Scout* Irrigation Worker* Livestock Showman" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.1", 0.3f, "43,370", "Motorcycle mechanics    * ATV Technician* All Terrain Vehicle Technician* Motor Scooter Mechanic* Motorcycle Repairer* Motorcycle Service Technician* Motorcycle Technician* Scooter Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "71.6", 1.3f, "60,500", "Structural iron and steel workers    * Bridge Ironworker* Construction Ironworker* Iron Guardrail Installer* Metal Tank Erector* Ornamental Ironworker* Pre-Engineered Metal Building Ironworker* Precast Concrete Ironworker* Steel Fabricator* Steel Fitter* Structural Steel Erector* Wind Turbine Erector" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.1", 0.1f, "46,010", "Rock splitters, quarry    * Quarry Chop Saw Operator* Quarry Plug and Feather Driller* Sandstone Splitter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "23.8", 0.5f, "62,240", "Special education teachers, preschool    * Early Childhood Special Education Teacher* Early Childhood Special Educator* Pre-K Special Education Teacher* Pre-Kindergarten Education Intervention Teacher* Pre-Kindergarten Special Education Teacher* Special Education Preschool Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "30.9", 0.6f, "127,830", "Advertising and promotions managers    * Advertising Director* Advertising Executive* Advertising Manager* Classified Advertising Manager* Promotions Director* Promotions Manager* VP Advertising* VP Promotions" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "84.8", 1.6f, "39,990", "Rehabilitation counselors    * Certified Rehabilitation Counselor* Coordinator of Rehabilitation Services* Psychosocial Rehabilitation Counselor* Veterans Rehabilitation Counselor* Vocational Rehabilitation Counselor* Vocational Rehabilitation Job Coach" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "148.0", 2.9f, "61,250", "Teachers and instructors, all other    * Sunday School Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "327.0", 6.3f, "48,510", "Machinists    * Automotive Machinist* CNC Machinist* Gear Machinist* Manual Lathe Machinist* Precision Machinist* Production Machinist* Tool Room Machinist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "5.9", 0.1f, "37,020", "Helpers--roofers    * Hot Tar Roofer Helper* Industrial Roofer Helper* Residential Roofer Helper* Roofer Assistant* Roofer Helper* Roofing Laborer* Shingles Roofer Helper* Slate Roofer Helper* Terra Cotta Roofer Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.1", 0.3f, "44,720", "Agricultural inspectors    * Cattle Examiner* Cattle Inspector* Grain Sampler* Meat and Poultry Inspector* Milk Tester* Wheat Inspector" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "23.2", 0.5f, "41,440", "Pesticide handlers, sprayers, and applicators, vegetation    * Certified Pesticide Applicator* Fruit Sprayer* Herbicide Sprayer* Orchard Sprayer* Plant Sprayer* Weed Sprayer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "32.3", 0.6f, "44,890" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "30.7", 0.6f, "47,490", "Sailors and marine oilers    * Able Seaman* Deck Cadet* Deck Hand* Deckhand* Merchant Mariner* Merchant Seaman* Ordinary Seaman* Sailor* Vessel Ordinary Seaman" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "32.4", 0.7f, "75,910", "Commercial and industrial designers    * Automobile Designer* Bank Note Designer* Bicycle Designer* Car Body Designer* Ceramic Designer* Ceramic Mold Designer* Furniture Designer* Package Designer* Rug Designer* Snowboard Designer* Textile Designer* Tile Designer* Toy Designer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "35.2", 0.7f, "106,230", "Healthcare diagnosing or treating practitioners, all other    * Homeopathic Doctor* Hypnotherapist* Naturopath* Naturopathic Doctor* Naturopathic Physician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "141.0", 2.8f, "35,070", "Meat, poultry, and fish cutters and trimmers    * Crab Picker* Deboner* Fish Cutter* Fish Filleter* Frozen Meat Cutter* Meat Trimmer* Oyster Shucker* Poultry Cutter* Poultry Eviscerator* Shrimp Peeler* Shrimp Picker* Wing Scorer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "154.5", 3.1f, "47,920", "Roofers    * Composition Roofer* Hot Tar Roofer* Industrial Roofer* Metal Roofing Mechanic* Residential Roofer* Sheet Metal Roofer* Shingles Roofer* Slate Roofer* Terra Cotta Roofer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.5", 0.1f, "45,320", "Animal breeders    * Cat Breeder* Dairy Husbandry Worker* Dog Breeder* Equine Breeder* Horse Breeder* Livestock Breeder* Poultry Inseminator* Stallion Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "25.4", 0.5f, "107,970" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "27.3", 0.6f, "49,730", "Plasterers and stucco masons    * Dry Plasterer* Journey Level Plasterer* Molding Plasterer* Ornamental Plasterer* Plasterer Apprentice* Stucco Plasterer* Stucco Worker* Swimming Pool Plasterer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "434.5", 8.9f, "32,510", "Cooks, institution and cafeteria    * Cafeteria Cook* Camp Cook* Galley Cook* Institutional Cook* Mess Cook* School Cook" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.3", 0.1f, "112,110", "Mathematicians    * Algebraist* Cipher Expert* Cryptanalyst* Cryptographer* Cryptographic Vulnerability Analyst* Geometrician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.4", 0.1f, "42,280", "Rail transportation workers, all other    * Railway Equipment Operator* Retarder Operator* Transfer Table Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.5", 0.4f, "131,280", "Compensation and benefits managers    * Compensation Director* Employee Benefits Coordinator* Employee Benefits Director* Employee Benefits Manager* Wage and Salary Administrator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "20.4", 0.4f, "51,740", "Earth drillers, except oil and gas    * Blast Hole Driller* Churn Drill Operator* Churn Driller* Earth Auger Operator* Earth Boring Machine Operator* Hard Rock Drill Operator* Rock Drill Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.3", 0.4f, "39,520", "Grounds maintenance workers, all other    * Trail Construction Worker* Trail Maintenance Worker* Trailhead Construction Worker* Trailhead Maintenance Worker* Tree Trimmer Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "22.9", 0.5f, "239,200", "Obstetricians and gynecologists    * Gynecological Oncologist* Gynecologist* Maternal-Fetal Medicine Physician* OB Specialist* OB/GYN* OB/GYN Physician* Obstetrician* Obstetrician/Gynecologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "29.6", 0.7f, "151,030", "Judges, magistrate judges, and magistrates    * Administrative Court Justice* Circuit Court Judge* County Court Judge* Criminal Court Judge* District Court Judge* Jurist* Justice* Probate Judge* Trial Court Judge* Tribal Judge" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "36.4", 0.8f, "72,110", "Funeral home managers    * Funeral Home Director* Funeral Home Manager* Funeral Service Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "54.5", 1.2f, "48,720", "Glaziers    * Leaded Glass Installer* Plate Glass Installer* Stained Glass Glazier* Stained Glass Installer* Stained Glass Joiner* Window Glazier" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "157.5", 3.5f, "49,230", "Eligibility interviewers, government programs    * Medicare Interviewer* Public Housing Interviewer* Social Security Benefits Interviewer* Unemployment Benefits Claims Taker* Welfare Interviewer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.3", 0.4f, "57,490", "Judicial law clerks    * Judicial Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "47.8", 1.1f, "36,340", "Helpers--pipelayers, plumbers, pipefitters, and steamfitters    * Gas Main Fitter Helper* Hydraulic Plumber Helper* Industrial Gas Fitter Helper* Marine Pipefitter Helper* Marine Steam Fitter Helper* Pipe Fitter Helper* Plumber Assistant* Plumber Helper* Sewer Pipe Layer Helper* Sprinkler Fitter Helper* Trench Pipe Layer Helper* Water Main Installer Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "145.3", 3.3f, "47,650", "Educational instruction and library workers, all other    * Aptitude Test (SAT) Grader* General Educational Development (GED¿) Examiner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "482.7", 10.9f, "60,090", "Plumbers, pipefitters, and steamfitters    * Fire Sprinkler Installer* Gas Main Fitter* Gas Plumber* Hydraulic Plumber* Industrial Gas Fitter* Marine Pipefitter* Marine Steamfitter* Master Plumber* Pipe Fitter* Plumber* Solar Thermal Installer* Sprinkler Fitter* Steamfitter* Water Pump Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.6", 0.1f, "56,340", "Rail yard engineers, dinkey operators, and hostlers    * Coal Tram Driver* Dinkey Driver* Dinkey Operator* Engine Hostler* Haulage Engine Operator* Railcar Switcher* Yard Hostler" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.3", 0.3f, "64,220", "Foresters    * Environmental Protection Forester* Forest Ecologist* Forestry Scientist* Land Management Forester* Operations Forester* Resource Forester* Service Forester* Timber Management Specialist* Urban Forester" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "15.9", 0.4f, "89,530", "Radiation therapists    * Radiation Therapy Technologist* Registered Radiation Therapist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "44.7", 1.1f, "39,590", "Molders, shapers, and casters, except metal and plastic    * Burial Vault Maker* Cigar Roller* Clay Modeler* Concrete Vault Maker* Glass Bender* Glass Block Bender* Glass Blower* Glass Presser* Glass Tube Bender* Mannequin Mold Maker* Neon Glass Bender* Neon Glass Blower* Neon Molder* Neon Tube Bender* Rubber Molder* Stone Carver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "173.4", 4.1f, "35,380", "Merchandise displayers and window trimmers    * Display Artist* Display Decorator* Display Designer* Display Specialist* Mannequin Decorator* Merchandise Displayer* Show Floor Decorator* Visual Merchandiser* Visual Merchandising Specialist* Window Decorator* Window Draper* Window Dresser* Window Trimmer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "576.2", 14f, "73,140", "First-line supervisors of mechanics, installers, and repairers    * Automobile Body Repair Supervisor* Body Shop Supervisor* Electronic Maintenance Supervisor* Fleet Maintenance Supervisor* Heating, Ventilation, and Air Conditioning Supervisor* Oil Field Equipment Mechanic Supervisor* Railroad Car Repair Supervisor* Repair Department Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.1", 0.4f, "37,200", "Building cleaning workers, all other    * Building Pressure Washer* Chimney Sweep* Chimney Sweeper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.1", 0.4f, "48,260", "Electric motor, power tool, and related repairers    * AC/DC Rewinder* Armature Rewinder* Battery Repairer* Dynamo Repairer* Electric Motor Fitter* Electric Motor Rewinder* Electrical Parts Reconditioner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.6", 0.4f, "42,160", "Medical appliance technicians    * Arch-Support Maker* Brace Maker* Hearing Aid Repair Technician* Manufacturing Orthopedic Technologist* Orthotic Fabricator Technician* Orthotic Finish Grinding Technician* Orthotics Fitter* Orthotics Technician* Prosthetics Fabrication Technician* Prosthetics Lab Technician* Prosthetics Technician* Surgical Appliance Fitter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "21.4", 0.5f, "131,800", "Petroleum engineers    * Natural Gas Engineer* Oil Drilling Engineer* Oil Exploration Engineer* Oil Well Engineer* Petroleum Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "66.0", 1.7f, "47,080", "Tree trimmers and pruners    * Pruner* Tree Pruner* Tree Specialist* Tree Surgeon* Tree Trimmer* Utility Arborist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "72.6", 1.8f, "214,460", "General internal medicine physicians    * General Internal Medicine Doctor* General Internist* Internal Medicine Physician* Internist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "96.5", 2.4f, "35,100", "Helpers--installation, maintenance, and repair workers    * Automobile Body Repairer Helper* Cable Splicer Helper* Hydroelectric Machinery Mechanic Helper* Locksmith Helper* Logging Equipment Mechanic Helper* Mechanic's Assistant* Meter Repairer Helper* Motorboat Mechanic Helper* Powerhouse Mechanic Helper* Streetcar Repairer Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "93.9", 2.4f, "59,860", "Probation officers and correctional treatment specialists    * Correctional Treatment Specialist* Juvenile Probation Officer* Parole Agent* Parole Officer* Probation Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "216.6", 5.3f, "66,490", "Instructional coordinators    * Curriculum Coordinator* Curriculum Designer* Curriculum Specialist* Curriculum and Assessment Director* Curriculum and Instruction Director* Instructional Materials Director* School Curriculum Developer* Special Education Curriculum Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "339.9", 8.3f, "90,520", "Network and computer systems administrators    * LAN Administrator* LAN Systems Administrator* Local Area Network Administrator* Network Analyst* Network Coordinator* Network Support Coordinator* Network Support Manager* Network Systems Administrator* Network Systems Coordinator* WAN Systems Administrator* Wide Area Network Administrator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "809.9", 20.4f, "74,080", "First-line supervisors of construction trades and extraction workers    * Carpenter Supervisor* Drilling Foreman* Electrician Supervisor* Excavating Supervisor* Foreman* Foreperson* Forewoman* Quarry Boss* Rig Supervisor* Roustabout Crew Leader* Segmental Paving Supervisor* Solar Panel Installation Supervisor* Tool Pushers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "5.3", 0.1f, "80,710", "Gambling managers    * Bingo Manager* Casino Manager* Gambling Department Head* Gambling Director* Gambling Manager* Slot Operations Director* Slots Manager* Table Games Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.2", 0.5f, "75,390", "Social sciences teachers, postsecondary, all other    * Social Science Professor* Survey Research Professor* Urban Planning Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "40.0", 1f, "239,200", "Anesthesiologists    * Ambulatory Anesthesiologist* Anaesthesiologist* Anesthetist* Attending Anesthesiologist* Obstetrical Anesthesiologist* Staff Anesthetist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "230.9", 6.1f, "50,810", "First-line supervisors of landscaping, lawn service, and groundskeeping workers    * Gardening Supervisor* Greenskeeper Supervisor* Grounds Crew Supervisor* Grounds Foreman* Grounds Maintenance Supervisor* Head Greenskeeper* Horticultural Services Supervisor* Landscape Installation Foreman* Turf and Grounds Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "334.2", 8.7f, "132,750", "Pharmacists    * Apothecary* Clinical Pharmacist* Druggist* Hospital Pharmacist* Registered Pharmacist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "5.8", 0.2f, "212,740", "Dentists, all other specialists    * Endodontist* Maxillofacial Pathology* Oral Pathologist* Pediatric Dentist* Pedodontist* Periodontist* Public Health Dentist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.5", 0.4f, "64,990", "Criminal justice and law enforcement teachers, postsecondary    * Criminal Justice Professor* Criminology Professor* Penology Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "25.7", 0.7f, "79,570", "Transportation inspectors    * Aircraft Inspector* Aircraft Landing Gear Inspector* Aircraft Quality Control Inspector* Airworthiness Safety Inspector* Freight Inspector* Locomotive Inspector* Motor Vehicle Emissions Inspector* Railroad Car Inspector* Railroad Inspector* School Bus Inspector* Transit Vehicle Inspector" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "29.1", 0.8f, "78,780", "Philosophy and religion teachers, postsecondary    * Biblical Studies Professor* Divinity Professor* Eastern Philosophy Professor* Ethics Professor* Old Testament Professor* Pastoral Ministries Professor* Religious Studies Professor* Theology Professor* Western Philosophy Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "56.6", 1.5f, "54,490", "First-line supervisors of farming, fishing, and forestry workers    * Animal Caretaker Supervisor* Aquacultural Worker Supervisor* Corn Crop Supervisor* Corral Boss* Cranberry Bog Supervisor* Farm Supervisor* Farrowing Manager* Feed Manager* Fish Hatchery Supervisor* Harvest Crew Supervisor* Harvest Manager* Logging Crew Supervisor* Picking Crew Supervisor* Planting Supervisor* Ranch Hand Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "73.3", 2f, "39,610", "Opticians, dispensing    * Certified Optician* Contact Lens Fitter* Eyeglass Fitter* Licensed Dispensing Optician* Licensed Optical Dispenser* Licensed Optician* Optical Dispenser* Optician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "161.1", 4.3f, "44,720", "Information and record clerks, all other    * Election Clerk* Flight Crew Scheduler* Probate Clerk* Student Admissions Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "380.8", 10.4f, "35,830", "Counter and rental clerks    * Airplane Charter Clerk* Apartment Rental Clerk* Automobile Rental Clerk* Automotive Service Writer* Bicycle Rental Clerk* Boat Rental Clerk* Car Rental Agent* Dry Cleaning Counter Clerk* Layaway Clerk* Rental Clerk* Storage Facility Rental Clerk* Video Rental Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "437.6", 11.6f, "51,430", "Operating engineers and other construction equipment operators    * Angle Dozer Operator* Blade Grader Operator* Construction Backhoe Operator* Construction Bulldozer Operator* Construction Excavator* Construction Shovel Operator* Ditching Machine Operating Engineer* Grader Operator* Motor Grader Operator* Road Grader* Scraper Operator* Steam Shovel Operating Engineer* Steam Shovel Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "21.3", 0.6f, "63,560", "Court reporters and simultaneous captioners    * Court Recording Monitor* Court Stenographer* Court Transcriber* Deposition Reporter* Realtime Captioner* Stenocaptioner* Voice Writing Reporter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "31.3", 0.9f, "239,200", "Emergency medicine physicians    * Critical Care Physician* Disaster Medicine Physician* Emergency Medicine Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "33.2", 0.9f, "31,160", "Funeral attendants    * Funeral Assistant* Funeral Greeter* Funeral Home Assistant* Funeral Home Associate* Mortician Helper* Pallbearer* Undertaker Helper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "36.5", 1f, "58,230", "Camera operators, television, video, and film    * Electronic News Gathering Camera Operator* Motion Picture Camera Operator* Movie Shot Camera Operator* News Camera Operator* News Videographer* Television Camera Operator* Video Camera Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "33.5", 1f, "67,120", "Stationary engineers and boiler operators    * Boiler Engineer* Boiler Operator* Boiler Plant Operator* Boiler Room Operator* Heating, Ventilation, and Air Conditioning (HVAC) Mechanic Boiler Operator* High Pressure Boiler Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "57.6", 1.6f, "89,130" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "83.0", 2.3f, "50,130", "Security and fire alarm systems installers    * Alarm Adjuster* Alarm Technician* Burglar Alarm Installer* Fire Alarm Installer* Fire Alarm Technician* Home Security Alarm Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "122.4", 3.5f, "82,340", "Electrical power-line installers and repairers    * Electric Powerline Examiner* Electric Utility Lineworker* Electrical High Tension Tester* Electrical Lineworker* Power Lineworker* Underground Conduit Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.6", 0.1f, "41,430", "Motorboat operators    * Launch Operator* Outboard Motorboat Operator* Speedboat Driver* Speedboat Operator* Water Taxi Ferry Operator* Water Taxi Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "42.1", 1.2f, "43,590", "Roustabouts, oil and gas    * Gas Floorhand* Oil Field Roustabout* Oil Rig Floorhand* Oil Rig Roughneck* Oil and Gas Floorhand* Roustabout* Roustabout Pusher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "43.9", 1.3f, "63,950", "Special education teachers, all other    * Special Education Teacher for Adults with Disabilities" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "354.8", 10.4f, "65,740", "Loan officers    * Branch Lending Officer* Commercial Lender* Loan Analyst* Loan Officer* Loan Reviewer* Payday Loan Officer* Real Estate Loan Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.8", 0.6f, "108,860", "Law teachers, postsecondary    * Constitutional Law Professor* Contracts Law Professor* Criminal Law Professor* Environmental Law Professor* Labor Law Professor* Torts Law Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.1", 0.6f, "67,430", "Zoologists and wildlife biologists    * Aquatic Biologist* Entomologist* Fish Culturist* Fishery Biologist* Herpetologist* Ichthyologist* Lepidopterist* Marine Biologist* Migratory Game Bird Biologist* Ornithologist* Protozoologist* Wildlife Biologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "21.5", 0.7f, "37,790", "Food and tobacco roasting, baking, and drying machine operators and tenders    * Bean Roaster* Coffee Roaster* Fish Smoker* Food Dehydrator Operator* Grain Roaster* Malt House Kiln Operator* Meat Curer* Meat Smoker* Sausage Smoker* Smokehouse Worker* Tobacco Drier Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "42.1", 1.3f, "60,930", "Millwrights    * Construction Millwright* Machine Erector* Machinery Dismantler* Maintenance Millwright* Manufacturing Millwright" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "44.5", 1.3f, "31,410", "Physical therapist aides    * Clinical Rehabilitation Aide* Physical Therapy Aide* Physiotherapy Aide" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "95.0", 2.9f, "36,460", "Protective service workers, all other    * Warrant Server" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "141.2", 4.3f, "61,660", "Librarians and media collections specialists    * Acquisitions Librarian* Audio-Visual Collections Coordinator* Catalog Librarian* Children's Librarian* Collection Development Librarian* College Librarian* Electronic Resources Librarian* Film Librarian* Government Documents Librarian* High School Librarian* Interlibrary Loan Services Librarian* Law Librarian* Library Media Specialist* Medical Librarian* Multimedia Services Coordinator* Music Librarian* Periodicals Librarian* Record Librarian* Reference Librarian* Research Librarian* School Librarian* Serials Librarian* Technical Services Librarian* University Librarian* Youth Services Librarian" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "170.6", 5.1f, "44,140", "Court, municipal, and license clerks    * Circuit Court Clerk* City Clerk* Court Clerk* Courtroom Clerk* Deputy Court Clerk* Docket Clerk* Dog Licenser* License Clerk* Motor Vehicle License Clerk* Motor Vehicle Representative* Municipal Clerk* Tax Clerk* Township Clerk* Warrant Clerk" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "254.9", 7.7f, "44,440", "First-line supervisors of housekeeping and janitorial workers    * Building Cleaning Supervisor* Cleaning Staff Supervisor* Custodial Supervisor* Head Custodian* Head School Custodian* Janitor Supervisor* Maid Supervisor* Maintenance and Custodian Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "330.9", 10f, "223,410", "Physicians, all other    * Gastroenterologist* Immunologist* Nephrologist* Oncologist* Physiatrist* Pulmonary Physician* Pulmonologist* Rheumatologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.5", 0.1f, "64,540", "Historians    * Genealogist* Historiographer* Protohistorian" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.4", 0.3f, "48,490", "Geological technicians, except hydrologic technicians    * Crude Tester* Geological Sample Tester* Geophysical Prospector* Magnetometer Operator* Mineral Technologist* Mining Technician* Mud Logger* Petroleum Technician* Seismic Interpreter* Seismic Observer* Seismograph Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "12.4", 0.4f, "239,200", "Dermatologists    * Dermatopathologist* Procedural Dermatologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "18.0", 0.6f, "239,200", "Cardiologists    * Electrophysiology Cardiologist* Interventional Cardiologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "33.5", 1.1f, "65,390", "Designers, all other    * Memorial Marker Designer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "74.1", 2.3f, "65,520", "Engineering technologists and technicians, except drafters, all other    * Agricultural Engineering Technician* Agricultural Engineering Technologist* Biomedical Engineering Technician* Biomedical Engineering Technologist* Chemical Engineering Technician* Chemical Engineering Technologist* Marine Engineering Technician* Marine Engineering Technologist* Materials Engineering Technician* Materials Engineering Technologist* Metallurgical Engineering Technician* Metallurgical Engineering Technologist* Non-Destructive Testing Specialist* Nuclear Engineering Technician* Nuclear Engineering Technologist* Optical Engineering Technician* Optical Engineering Technologist* Ordnance Engineering Technician* Ordnance Engineering Technologist* Radar Technicians* Salvage Engineering Technician* Salvage Engineering Technologist* Sonar Technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "95.0", 3f, "38,310", "Pest control workers    * Exterminator* Fumigator* Insecticide Expert* Mosquito Sprayer* Pest Controller* Rat Exterminator* Rodent Exterminator* Termite Technician* Termite Treater" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "137.9", 4.3f, "96,290", "First-line supervisors of police and detectives    * Commanding Officer Homicide Squad* Detective Lieutenant* Detective Supervisor* Police Lieutenant* Traffic Lieutenant* Traffic Sergeant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "258.6", 8.1f, "30,300", "Food servers, nonrestaurant    * Boat Hop* Hospital Food Service Worker* Room Service Food Server" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.3", 0.1f, "64,310", "Pile driver operators    * Diesel Pile Hammer Operator* Hydraulic Pile Hammer Operator* Hydraulic Press-In Operator* Vibratory Pile Driver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.4", 0.1f, "69,150", "Transit and railroad police    * Railroad Detective* Railroad Police Officer* Track Patrol* Transit Authority Police* Transit Police Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "12.2", 0.4f, "224,260", "Neurologists    * Clinical Neuromuscular Pathologist* Epileptologist* Headache Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "20.2", 0.6f, "33,390", "Cooks, all other    * Falafel Cart Cook* Fraternity House Cook" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "29.7", 1f, "56,290", "First-line supervisors of gambling services workers    * Blackjack Pit Boss* Blackjack Supervisor* Cardroom Manager* Cardroom Supervisor* Casino Slot Supervisor* Casino Supervisor* Electronic Gambling Device Supervisor* Executive Casino Host* Gambling Supervisor* Pit Boss* Poker Room Supervisor* Slot Floor Supervisor* Slot Host* Slot Key Person* Slot Shift Manager* Table Games Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "55.9", 1.8f, "77,420", "Mathematical science teachers, postsecondary    * Actuarial Science Professor* Biostatistics Professor* Calculus Professor* Geometry Professor* Mathematics Professor* Statistical Methods Professor* Statistics Professor* Topology Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "58.8", 1.9f, "50,840", "Chemical technicians    * Assayer* Chemical Laboratory Technician* Inorganic Chemical Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "69.1", 2.2f, "61,210", "Industrial engineering technologists and technicians    * Industrial Engineering Technician* Industrial Engineering Technologist* Motion Study Technician* Production Control Technologist* Time Study Technician* Time Study Technologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "78.1", 2.5f, "0", "Actors    * Actor Understudy* Actress* Dramatic Reader* Elocutionist* Monologist* Vaudeville Actor* Voice-Over Artist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "123.9", 3.9f, "77,280", "Art, drama, and music teachers, postsecondary    * Ballet Professor* Graphic Design Professor* Media Arts Professor* Music Professor* Photography Professor* Piano Performance and Pedagogy Professor* Piano Professor* Scene and Lighting Design Lecturer* Stagecraft Professor* Theatre Professor* Voice Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "146.4", 4.7f, "43,540", "Refuse and recyclable material collectors    * Garbage Collector* Recyclable Materials Collector* Refuse Collector* Scrap Metal Collector* Solid Waste Collector* Trash Collector" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "354.7", 11.4f, "44,110", "Self-enrichment teachers    * Citizenship Teacher* Driver Education Instructor* Knitting Instructor* Recreational Activities Instructor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "462.6", 14.9f, "49,980", "Real estate sales agents    * Agricultural Real Estate Agent* Apartment Rental Agent* Industrial Real Estate Agent* Land Sales Agent* Right of Way Agent" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.8", 0.4f, "79,180", "Emergency management directors    * Director of Civil Defense* Disaster Response Director* EMS Director* Emergency Management System Director* Emergency Planner* Emergency Planning and Response Manager* Emergency Preparedness Coordinator* Emergency Services Director* Emergency Services Program Coordinator* Public Safety Director" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.3", 0.5f, "72,650", "Recreation and fitness studies teachers, postsecondary    * Health and Physical Education Professor* Human Performance Professor* Kinesiology Professor* Leisure Studies Professor* Physical Education (PE) Professor* Physical Education Professor* Swimming Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "24.9", 0.8f, "76,700", "Fashion designers    * Apparel Designer* Clothes Designer* Clothing Designer* Costume Designer* Custom Furrier* Dance Costume Designer* Dress Designer* Hat Designer* Sweater Designer* Uniform Designer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "51.6", 1.7f, "82,260", "Budget analysts    * Budget Analyst* Budget Coordinator* Budget Examiner* Budget Officer* Cost Analyst" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "64.2", 2.1f, "47,180", "Surveying and mapping technicians    * Cartographic Aide* Cartographic Technician* Field Map Technician* GIS Mapping Technician* Geophysical Prospecting Surveying Technician* Mapping Technician* Mineral Surveying Technician* Surveying Technician* Topography Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "170.3", 5.7f, "104,600", "Engineers, all other    * Calibration Engineer* Coastal Engineer* Corrosion Control Engineer* Mathematical Engineer* Mechatronics Engineer* Metrologist* Ocean Engineer* Optical Engineer* Ordnance Engineer* Photonics Engineer* Salvage Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "223.7", 7.4f, "36,680", "Tutors    * Algebra Tutor* Reading Tutor* Spanish Tutor* Standardized Test Tutor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "270.9", 8.9f, "57,990", "Graphic designers    * Graphic Artist* Visual Designer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "641.3", 21.3f, "29,380", "Bartenders    * Barkeep* Drink Mixer* Mixologist* Taproom Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "684.0", 22.5f, "65,790", "Police and sheriff's patrol officers    * Border Guard* Border Patrol Officer* Campus Police Officer* Constable* Cop* Deputy Sheriff* Highway Patrol Officer* Motorcycle Police* Mounted Police* Park Police* Patrol Officer* Policeman* Policewoman* State Highway Police Officer* State Trooper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,228.3", 41f, "128,620", "Managers, all other    * Clerk of Court* Environmental Control Administrator* Highway Patrol Commander* Safety Coordinator* Social Science Manager* Utilities Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.5", 0.1f, "128,970", "Medical dosimetrists    * Certified Medical Dosimetrist* Qualified Medical Dosimetrist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.0", 0.5f, "69,760", "Artists and related workers, all other    * Calligrapher* Tattoo Artist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.5", 0.5f, "59,720", "Radio, cellular, and tower equipment installers and repairers    * Radio Frequency Technician* Radio Mechanic* Radio Repairer* Two-Way Radio Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.3", 0.6f, "69,490", "Media and communication equipment workers, all other    * Satellite Communications Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "24.5", 0.8f, "61,030", "First-line supervisors of protective service workers, all other    * Animal Control Supervisor* Animal Cruelty Investigation Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "33.6", 1.2f, "76,250", "Communications teachers, postsecondary    * Interpersonal Communications Professor* Journalism Professor* Professor of Communication and Writing* Professor of Rhetoric* Public Speaking Professor* Speech Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "44.4", 1.5f, "48,090", "Legislators    * City Alderman* City Council Member* Congressional Representative* Councilor* Legislator* Member of Congress* Selectman* Senator* Tribal Council Member" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "55.6", 1.9f, "46,250", "Separating, filtering, clarifying, precipitating, and still machine setters, operators, and tenders    * Brewmaster* Fermentation Operator* Fermenter* Linseed Oil Temperer* Milk Pasteurizer* Milk Processor* Molasses Preparer* Pasteurizer* Winemaker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "99.5", 3.4f, "46,900", "Public safety telecommunicators    * 911 Dispatcher* 911 Operator* Ambulance Dispatcher* Emergency Communications Dispatcher* Emergency Communications Operator* Emergency Operator* Emergency Telecommunications Dispatcher* Fire Dispatcher* Police Dispatcher* Police Radio Dispatcher* Public Safety Dispatcher* Public Safety Telecommunicator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "512.3", 17.2f, "35,330", "Preschool teachers, except special education    * Early Childhood Teacher* Head Start Teacher* Home-based Preschool Teacher* Nursery School Teacher* Nursery Teacher* Pre-K Teacher* Pre-Kindergarten Teacher* Preschool Head Start Teacher* Preschool Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.5", 0.3f, "88,260", "Subway and streetcar operators    * Light Rail Operator* Light Rail Transit Operator* Light Rail Vehicle Operator* Rapid Transit Operator* Subway Conductor* Subway Train Operator* Tram Operator* Trolley Car Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.6", 0.3f, "50,050", "Traffic technicians    * Highway Traffic Control Technician* Traffic Engineering Technician* Traffic Signal Technician* Transportation Planning Technician* Transportation Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "20.2", 0.7f, "33,960", "Dietetic technicians    * Clinical Dietetic Technician* Cook Chill Technician* DTR* Dietary Aide* Dietary Technician* Nutrition Technician* Registered Diet Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "25.9", 0.9f, "80,720", "Chemistry teachers, postsecondary    * Chemistry Professor* Inorganic Chemistry Professor* Organic Chemistry Professor* Physical Chemistry Professor* Phytochemistry Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "26.1", 0.9f, "38,800", "Material moving workers, all other    * Back Hoe Operator* Backhoe Operator* Bulldozer Operator* End Loader Operator* Freight Elevator Operator* Payloader Operator* Shovel Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "66.3", 2.3f, "46,400", "Travel agents    * Auto Travel Counselor* Certified Corporate Travel Executive* Certified Travel Counselor* Corporate Travel Expert* Travel Consultant* Travel Counselor* Travel Service Consultant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "127.2", 4.4f, "62,190", "Real estate brokers    * Licensed Real Estate Broker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "180.2", 6.3f, "126,900", "Computer network architects    * Computer Network Engineer* Network Designer* Network Developer* Network Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "218.2", 7.7f, "99,940", "Education administrators, postsecondary    * Continuing Education Director* Director of Student Services* Graduate School Dean* Graduate Studies Dean* Provost* University Dean* University Department Chair" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,176.1", 41.7f, "35,890", "Landscaping and groundskeeping workers    * Golf Course Laborer* Greenskeeper* Greenskeeper Laborer* Grounds Caretaker* Grounds Maintenance Worker* Hedge Trimmer* Lawn Care Worker* Lawn Caretaker* Lawn Maintenance Worker* Lawn Mower* Lawn Service Worker* Shrub Planter* Sod Layer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.2", 0.4f, "55,860", "Pump operators, except wellhead pumpers    * Acid Pump Operator* Brewery Pumper* Concrete Pump Operator* Fluid Pump Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.6", 0.5f, "97,770", "Atmospheric, earth, marine, and space sciences teachers, postsecondary    * Climatology Professor* Earth Science Professor* Geology Professor* Geoscience Professor* Meteorology Professor* Mineralogy Professor* Oceanic Sciences Professor* Oceanography Professor* Volcanology Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "12.8", 0.5f, "219,810", "Ophthalmologists, except pediatric    * Cornea and External Disease Physician* Viteroretinal Disease Physician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.8", 0.6f, "51,330", "Recreational therapists    * CTRS* Certified Recreational Therapist* Certified Therapeutic Recreation Specialist* Drama Therapist* Therapeutic Recreation Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "20.1", 0.7f, "62,510", "Rail car repairers    * Freight Car Repairer* Mine Car Mechanic* Rail Car Maintenance Mechanic* Rail Car Mechanic* Streetcar Repairer* Subway Car Repairer* Tank Car Reconditioner* Trolley Car Mechanic* Trolley Car Overhauler" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "31.2", 1.1f, "239,200", "Radiologists    * Diagnostic Radiologist* Interventional Radiologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "87.1", 3.1f, "80,150", "First-line supervisors of firefighting and prevention workers    * Fire Lieutenant* Municipal Fire Fighting and Prevention Supervisor* Supervising Fire Marshal" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "262.8", 9.4f, "76,920", "Postsecondary teachers, all other    * Flight Simulator Instructor* Military Science Instructor* Packaging Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "334.2", 12f, "51,680", "Firefighters    * Fire Engine Pump Operator* Fire Equipment Operator* Fire Fighter* Forest Firefighter* Marine Firefighter* Municipal Firefighter* Smoke Jumper* Wildland Firefighter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,607.2", 57.2f, "44,980", "Maintenance and repair workers, general    * Building Maintenance Mechanic* Building Mechanic* Building Services Mechanic* Facilities Maintenance Worker* General Maintenance Worker* Maintenance Mechanic* Mechanics Handyman* Plant Maintenance Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.9", 0.1f, "44,930", "Paperhangers    * Billboard Poster* Wall Covering Installer* Wallpaper Hanger* Wallpaperer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "15.0", 0.6f, "69,450", "Fire inspectors and investigators    * Arson Investigator* CFEI* Certified Fire Investigator* Certified Fire and Explosion Investigator* Certified Vehicle Fire Investigator* Fire Hazard Inspector* Fire Investigator* Fire Prevention Inspector* Fire Safety Inspector" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "15.0", 0.6f, "78,970", "Sociology teachers, postsecondary    * Comparative Sociology Professor* Race Relations Professor* Social Organization Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.3", 0.7f, "83,770", "Political science teachers, postsecondary    * Government Professor* International Relations Professor* Political Theory Professor* Public Policy Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "22.0", 0.8f, "100,660", "Health and safety engineers, except mining safety engineers and inspectors    * Fire Prevention Engineer* Fire Protection Engineer* Industrial Safety Engineer* Product Safety Engineer* Product Safety Test Engineer* System Safety Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "24.5", 0.9f, "51,570", "Morticians, undertakers, and funeral arrangers    * Certified Mortician* Funeral Arrangement Director* Funeral Arranger" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "42.3", 1.6f, "47,270", "Paving, surfacing, and tamping equipment operators    * Asphalt Paver* Asphalt Paving Machine Operator* Asphalt Roller Operator* Asphalt Tamping Machine Operator* Blacktop-Paver Operator* Paver Operator* Screed Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "44.7", 1.7f, "79,540", "Urban and regional planners    * City Planner* Community Development Planner* Regional Planner* Urban Planner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "58.9", 2.2f, "63,020", "Cardiovascular technologists and technicians    * Cardiac Catheterization Laboratory Technologist* Cardiac Catheterization Technologist* Cardiac Monitor Technician* Cardiac Technician* Cardiopulmonary Technologist* Cardiovascular Interventional Technologist* Cardiovascular Technologist* EKG Technician* Electrocardiogram Technician* Electrocardiograph Operator* Pulmonary Function Technologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "74.3", 2.8f, "66,930", "Education teachers, postsecondary    * Literacy Education Professor* Mathematics Education Professor* Primary Education Professor* Science Education Professor* Secondary Education Professor* Special Education Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "108.0", 4f, "211,300", "Family medicine physicians    * Board Certified Family Physician* Family Physician* Family Practice Medical Doctor* Family Practice Physician* Family Practitioner* GP Doctor* General Practitioner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "151.2", 5.6f, "73,150", "Writers and authors    * Advertising Copy Writer* Advertising Copywriter* Author* Biographer* Copy Writer* Copywriter* Lyricist* Novelist* Playwright* Poet* Program Writer* Radio Script Writer* Screen Writer* Short Story Writer* Song Lyricist* Television Writer* Verse Writer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "305.6", 11.4f, "97,710", "Sales representatives, wholesale and manufacturing, technical and scientific products    * Chemical Sales Representative* Electroplating Sales Representative* Engineering Supplies Sales* Pharmaceutical Detailer* Pharmaceutical Sales Representative* Pharmaceutical Salesperson* Surgical Instruments Sales Representative* Wholesale Ultrasonic Equipment Salesperson" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "401.8", 15f, "31,000", "Cleaners of vehicles and equipment    * Aircraft Cleaner* Auto Cleaner* Auto Detailer* Automobile Detailer* Beer Coil Cleaner* Boat Detailer* Bus Cleaner* Bus Washer* Car Wash Attendant* Car Washer* Equipment Cleaner* Machine Cleaner* Railroad Car Cleaner* Truck Washer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "796.6", 29.9f, "41,230", "Industrial truck and tractor operators    * Forklift Driver* Forklift Operator* Front-End Loader Operator* Hydraulic Lift Driver* Industrial Truck Operator* Reach-Lift Truck Driver* Stacker Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.2", 0.3f, "93,220", "Architecture teachers, postsecondary    * Architectural Design Professor* Architecture Professor* Interior Design Professor* Landscape Architecture Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.4", 0.5f, "36,250", "Bicycle repairers    * Bicycle Mechanic* Bicycle Service Technician* Bike Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.0", 0.5f, "37,190", "Cleaning, washing, and metal pickling equipment operators and tenders    * Acid Dipper* Bottle Washing Machine Operator* Degreaser Operator* Glass Cleaning Machine Tender* Immersion Metal Cleaner* Metal Pickling Equipment Operator* Pickle House Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.8", 0.6f, "103,930", "Economics teachers, postsecondary    * Agricultural Economics Professor* Econometrics Professor* Industrial Economics Professor* Labor Economics Professor* Macroeconomics Professor* Microeconomics Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.2", 0.6f, "86,550", "Physics teachers, postsecondary    * Aerodynamics Professor* Astrophysics Professor* Atomic Physics Professor* Ballistics Professor* Hydrodynamics Professor* Medical Physics Professor* Nuclear Physics Professor* Thermodynamics Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "80.0", 3f, "50,290", "Life, physical, and social science technicians, all other    * Meteorological Aide* Polygraph Examiner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.0", 0.1f, "40,360", "Crematory operators    * Cremation Arranger* Cremator* Crematory Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.9", 0.1f, "76,440", "Family and consumer sciences teachers, postsecondary    * Family Resource Management Professor* Family and Consumer Sciences Professor* Home Economics Professor* Home and Family Living Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.5", 0.4f, "38,150", "Craft artists    * Hand Potter* Metal Crafts Artist* Quilter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.9", 0.5f, "80,910", "Area, ethnic, and cultural studies teachers, postsecondary    * African Studies Professor* Asian Studies Professor* Black Studies Professor* Ethnology Professor* Gender Studies Professor* Latin American Studies Professor* Women's Studies Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "12.1", 0.5f, "37,430", "Transportation workers, all other    * Pedicab Driver* Rickshaw Driver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "48.8", 1.9f, "34,710", "Food processing workers, all other    * Olive Pitter* Pasta Press Operator* Poultry Hanger* Yeast Maker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "60.4", 2.3f, "87,300", "Biological scientists, all other    * Biologist* Bryologist* Embryologist* Osteologist* Paleobotanist* Phytopathologist* Plant Etiologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "91.7", 3.5f, "211,790", "Airline pilots, copilots, and flight engineers    * Airline Captain* Airline Pilot* Airline Pilot Flight Instructor* Airline Pilot In Command* Airline Pilot Second In Command* Airline Transport Pilot* Charter Pilot (Air Transport Pilot Certificate Required)* Charter Pilot (Airline)* Regional Airline Pilot" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "94.9", 3.7f, "61,590", "Interior designers    * Certified Kitchen Designer* Furniture Arranger* Home Lighting Adviser* Interior Decorator* Interior Designer* Kitchen Designer* Kitchen and Bath Designer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.2", 0.2f, "85,000", "Anthropology and archeology teachers, postsecondary    * Cultural Anthropology Professor* Ethnoarchaeology Professor* Near East Archeology Professor* Paleology Professor* Sociocultural Anthropology Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.9", 0.5f, "39,320", "Animal control workers    * Animal Control Officer* Animal Cruelty Investigator* Animal Treatment Investigator* Animal Warden* Dog Catcher* Dog Warden* Humane Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "15.5", 0.6f, "66,510", "Social work teachers, postsecondary    * Family Welfare Social Work Professor* Geriatric Social Work Professor* Health Social Work Professor* Social Work Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "45.0", 1.8f, "34,770", "Demonstrators and product promoters    * Home Demonstrator* Home Service Demonstrator* Hostess Party Sales Representative* In-Store Demonstrator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "50.9", 2.1f, "103,910", "Commercial pilots    * Aerial Crop Duster* Aerial Hurricane Hunter* Aerial Sprayer* Agricultural Pilot* Air Ambulance Captain* Air Tour Pilot* Balloon Pilot* Charter Pilot (Commercial Pilot Certificate Required)* Charter Pilot (Commercial)* Commercial Helicopter Pilot* Corporate Pilot* EMS Helicopter Pilot* Emergency Medical Service Helicopter Pilot* Emergency Medical Service Rotary Wing Pilot* Executive Pilot* Flight Instructor (Commercial Pilots)* Helicopter Pilot" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "554.7", 22.5f, "130,600", "Sales managers    * District Sales Manager* E-Commerce Director* Export Manager* Regional Sales Manager* Sales Account Manager* Sales Director* Territory Sales Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "5.4", 0.2f, "76,370", "Library science teachers, postsecondary    * Library and Information Science Professor* Library and Information Technology Instructor* Medical Records Library Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.5", 0.6f, "34,630", "Passenger attendants    * Dining Car Steward* Ship Steward* Sleeping Car Service Attendant* Train Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "24.7", 1f, "64,460", "Conservation scientists    * Conservation Science Officer* Grassland Conservationist* Land Reclamation Specialist* Land Resource Specialist* Range Conservationist* Range Ecologist* Range Scientist* Resource Conservationist* Soil Conservationist* Water Conservationist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "94.1", 3.8f, "33,380", "Crossing guards and flaggers    * Construction Site Crossing Guard* Crossing Guard* School Crossing Guard* School Traffic Guard" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "148.9", 6.1f, "40,170", "Photographers    * Advertising Photographer* Aerial Photographer* Industrial Photographer* Marine Photographer* Medical Photographer* News Photographer* Newspaper Photojournalist* Photojournalist* Portrait Photographer* School Photographer* Wedding Photographer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "201.5", 8.2f, "159,920", "Architectural and engineering managers    * Electrical Engineering Director* Engineering Design Manager* Engineering Manager* Engineering Research Manager* Global Engineering Manager* Mechanical Engineering Director* Process Engineering Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "421.6", 17.4f, "35,250", "Substitute teachers, short-term    * Elementary School Substitute Teacher* English Substitute Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,113.2", 45.7f, "62,400", "Sales representatives of services, except advertising, insurance, financial services, and travel    * Automobile Club Membership Sales Agent* Bookkeeping Service Sales Agent* Business Services Sales Representative* Membership Solicitor* Pest Control Service Sales Agent" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,174.8", 48.7f, "75,990", "Business operations specialists, all other    * Mystery Shopper* Ship Purser" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,361.3", 56.5f, "35,760", "Nursing assistants    * C.N.A.* Certified Nurse Aide* Certified Nursing Assistant* Hospital Aide* Hospital Attendant* Nursing Aide* Nursing Attendant* Nursing Care Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2,192.3", 89.3f, "49,920", "Heavy and tractor-trailer truck drivers    * Auto Carrier Driver* Cement Truck Driver* Concrete Mixer Driver* Concrete Mixer Truck Driver* Dump Truck Driver* Fuel Truck Driver* Garbage Truck Driver* Line Haul Driver* Log Truck Tractor-Trailer Driver* Logging Flatbed Truck Driver* Logging Truck Driver* Over-the-Road Driver* Self-loading Flatbed Truck Driver* Semi-Truck Driver* Tanker Driver* Tow Truck Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.0", 0.3f, "63,940", "Anthropologists and archeologists    * Anthropologist* Applied Anthropologist* Archaeologist* Ethnoarchaeologist* Medical Anthropologist* Physical Anthropologist* Political Anthropologist* Research Anthropologist* Research Archaeologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.9", 0.3f, "83,040", "Environmental science teachers, postsecondary    * Environmental Science Professor* Environmental Science, Management and Policy Professor* Environmental Studies Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "23.8", 1f, "0", "Disc jockeys, except radio    * Club DJ* DJ* Deejay" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "45.5", 1.9f, "34,520", "Orderlies    * Emergency Room Orderly* Hospital Orderly* Medical Orderly* Surgical Orderly" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "170.2", 7.1f, "38,050", "Teaching assistants, postsecondary    * Assistant Instructor* College Biology Teaching Assistant* University Teaching Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "188.8", 7.9f, "103,320", "Electrical engineers    * Electrical Design Engineer* Electrical Systems Engineer* Illuminating Engineer* Power Distribution Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "343.8", 14.4f, "27,780", "Amusement and recreation attendants    * Amusement Park Worker* Animal Ride Attendant* Arcade Attendant* Carnival Worker* Ferris Wheel Operator* Golf Caddy* Ice Rink Attendant* Ride Operator* Rides Attendant* Ski Lift Attendant* Ski Lift Operator* Sports Complex Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "354.3", 14.8f, "59,200", "Paralegals and legal assistants    * Assistant Paralegal* Legal Aide* Legal Assistant* Paralegal* Summer Associate" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "396.8", 16.5f, "50,630", "Production, planning, and expediting clerks    * Expeditor* Material Control Clerk* Material Expediter* Mill Recorder* Production Control Clerk* Production Control Coordinating Clerk* Production Control Coordinator* Production Scheduler* Work Ticket Distributor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "459.2", 19.2f, "29,120", "Dining room and cafeteria attendants and bartender helpers    * Banquet Set Up Person* Bar Back* Barback* Buffet Attendant* Bus Person* Busser* Lunchroom Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3,507.8", 147.3f, "98,100", "General and operations managers    * Department Store General Manager* Department Store Manager* General Manager* General Superintendent* Manufacturing Operations Manager* Operational Risk Manager* Operations Manager* Radio Station Manager* Television Store Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "20.8", 0.9f, "75,450", "Avionics technicians    * Aircraft Armament Mechanic* Aircraft Electrician* Aircraft Instrument Mechanic* Airplane Electrician* Automatic Pilot Mechanic* Aviation Electronics Technician* In-Flight Refueling System Repairer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "23.1", 1f, "56,090", "Personal service managers, all other    * Day Spa Director* Nail Salon Manager* Travel Agency Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "25.8", 1.1f, "65,000", "Media and communication workers, all other    * Public Address Announcer* Stage Technician* Train Announcer* Train Caller" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "68.7", 3f, "53,640", "Interpreters and translators    * American Sign Language Interpreter* Court Interpreter* Deaf Interpreter* Diplomatic Interpreter* Language Translator* Translator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "85.4", 3.7f, "30,840", "Food preparation and serving related workers, all other    * Kitchen Steward" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "140.2", 6.1f, "70,010", "Aircraft mechanics and service technicians    * A&P Mechanic* Aircraft Engine Mechanic* Aircraft Engine Specialist* Airframe Mechanic* Airframe and Power Plant Mechanic* Airplane Rigger* FAA Certified Powerplant Mechanic* Flight Test Mechanic* Helicopter Engine Mechanic* Helicopter Mechanic* Jet Engine Mechanic* Propeller-Driven Airplane Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.1", 0.2f, "81,920", "Geography teachers, postsecondary    * Cartography Professor* GIS Professor* Geographic Information Systems Professor* Geomatics Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.5", 0.5f, "83,780", "Atmospheric and space scientists    * Atmospheric Chemist* Atmospheric Scientist* Climatologist* Hurricane Tracker* Meteorologist* Oceanographic Meteorologist* Space Scientist* Storm Chaser* Tornado Chaser* Warning Coordination Meteorologist* Weather Analyst* Weather Forecaster* Weatherman" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.3", 0.5f, "62,050", "Calibration technologists and technicians    * Calibration Technician* Calibration Technologist* Hydrometer Calibrator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "77.5", 3.4f, "131,350", "Purchasing managers    * Contract Administrator* Contracting Manager* Director of Strategic Sourcing* Procurement Manager* Purchasing Director* Sourcing Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "136.7", 6f, "155,040", "Dentists, general    * Family Dentist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,418.6", 61.9f, "40,750", "Construction laborers    * Air Hammer Operator* Construction Craft Laborer* Construction Trench Digger" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,538.4", 67.4f, "78,000", "Accountants and auditors    * Account Auditor* Accountant* Auditor* Auditor-In-Charge* CPA* Certified Public Accountant* Cost Accountant* Field Auditor* Financial Accountant* Financial Auditor* Fund Accountant* Internal Auditor* Payroll Auditor* Tax Accountant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.3", 0.1f, "98,590", "Sociologists    * Criminologist* Family Sociologist* Penologist* Rural Sociologist* Urban Sociologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.2", 0.3f, "174,360", "Orthodontists    * Dentofacial Orthopedics Dentist* Invisible Braces Orthodontist* Pediatric Orthodontist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.6", 0.8f, "41,760", "Agricultural technicians    * Agronomy Technician* Artificial Breeding Technician* Cotton Program Technician* Feed Mill Lab Technician* Feed Research Technician* Seed Analyst* Sugarcane Research Technician* Weed Science Research Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "136.8", 6.1f, "44,120", "Sales and related workers, all other    * Auctioneer* Blood Donor Recruiter* Leaflet Distributor* Livestock Auctioneer* Pawn Shop Clerk* Personal Shopper* Store Gift Wrap Associate" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "282.9", 12.7f, "38,580" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "505.8", 22.9f, "101,480", "Construction managers    * Construction Coordinator* Construction Superintendent* General Contractor* Masonry Contractor Administrator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.4", 0.1f, "128,330", "Astronomers    * Astrophysicist* Cosmologist* Extragalactic Astronomer* Galactic Astronomer* High-energy Astrophysicist* Optical Astronomer* Planetary Astronomer* Radio Astronomer* Solar Astronomer* Stellar Astronomer* Theoretical Astronomer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.2", 0.6f, "239,200", "Physicians, pathologists    * Clinical Pathologist* Immunopathologist* Neuropathologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "50.8", 2.3f, "63,080", "Surveyors    * City Surveyor* County Surveyor* Geodetic Surveyor* Geophysical Prospecting Surveyor* Land Surveyor* Mine Surveyor* Mineral Surveyor* Registered Land Surveyor* Topographical Surveyor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "78.1", 3.6f, "132,360", "Computer hardware engineers    * Computer Hardware Designer* Computer Hardware Developer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "77.6", 3.6f, "61,560" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "127.0", 5.8f, "99,030", "Facilities managers    * Conference Center Manager* Director of University Housing* Stadium Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "289.4", 13.4f, "31,680", "Recreation workers    * Camp Counselor* Recreation Assistant* Recreational Activities Aide* Recreational Activities Assistant* Recreational Aide" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "377.5", 17.2f, "71,690", "Compliance officers    * Air Pollution Compliance Inspector* Compliance Investigator* Driver's License Examiner* EEO Officer* Environmental Compliance Inspector* Equal Employment Opportunity Investigator* Equal Employment Opportunity Officer* Equal Employment Opportunity Representative* Immigration Investigator* Inspector of Weights and Measures* License Inspector* Mortician Investigator* Wage and Hour Investigator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "373.2", 17.3f, "36,750", "Packaging and filling machine operators and tenders    * Bottle Capper* Bottle Line Worker* Bottle Packer* Can Filler* Can Sealer* Keg Filler* Potato Chip Packaging Machine Operator* Tea Bag Packer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.2", 0.8f, "65,730", "Soil and plant scientists    * Agriculturist* Agronomist* Arboreal Scientist* Crop Nutrition Scientist* Floriculturist* Horticulturist* Plant Physiologist* Plant Scientist* Pomologist* Soil Fertility Extension Specialist* Soil Scientist* Viticulturist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.9", 0.9f, "37,050", "Aircraft service attendants    * Aircraft De-Icer* Aircraft Refueler* Airplane Refueler" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "21.1", 1f, "142,850", "Physicists    * Computational Physicist* Condensed Matter Physicist* Fluid Dynamicist* Health Physicist* Mathematical Physicist* Medical Physicist* Molecular Physicist* Nuclear Physicist* Optical Scientist* Plasma Physicist* Research Physicist* Rheologist* Thermodynamic Physicist* Thermodynamicist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "60.9", 2.9f, "108,530", "Sales engineers    * Aerospace Products Sales Engineer* Missile Navigation Systems Sales Engineer* Nuclear Equipment Sales Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "74.8", 3.5f, "50,660", "Audio and video technicians    * Audio-Visual Production Specialist* Event AV Operator* Video Control Operator* Video Equipment Technician* Video Production Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "81.4", 3.9f, "49,650", "Biological technicians    * Bacteriology Technician* Biochemistry Technician* Biology Laboratory Assistant* Marine Fisheries Technician* Microbiology Technician* Wildlife Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "601.1", 28.1f, "57,860" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.9", 0.4f, "73,630", "Electrical and electronics installers and repairers, transportation equipment    * Locomotive Electrician* Marine Electronics Repairer* Marine Electronics Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.1", 0.5f, "85,860", "Agricultural sciences teachers, postsecondary    * Agricultural Soil Conservation Professor* Agronomy Professor* Animal Husbandry Professor* Animal Science Professor* Aquaculture and Fisheries Professor* Farm Management Professor* Floriculture Professor* Horticulture Instructor* Olericulture Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "34.4", 1.6f, "50,470", "Social science research assistants    * City Planning Aide* Economic Research Assistant* Economist Research Assistant* Historian Research Assistant* Political Science Research Assistant* Psychologist Research Assistant* Sociology Research Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "86.3", 4.2f, "144,440", "Natural sciences managers    * Agricultural Research Director* Geochemical Manager* Geophysical Manager* Ocean Program Administrator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "123.7", 6f, "82,840", "Architects, except landscape and naval    * Building Architect* Building Architectural Designer* Structural Architect" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.8", 0.2f, "37,060", "Occupational therapy aides    * Certified Occupational Rehabilitation Aide* OT Aide* Occupational Rehabilitation Aide* Occupational Therapist Aide* Rehabilitation Services Aide" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "15.0", 0.7f, "49,600", "Airfield operations specialists    * Aviation Operations Specialist* Flight Operations Coordinator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "32.4", 1.6f, "37,160", "Psychiatric aides    * Mental Health Orderly* Psychiatric Nursing Aide* Psychiatric Orderly* Psychiatric Technician Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "218.8", 10.8f, "32,780", "Bakers    * Bagel Maker* Bread Baker* Dough Maker* Pastry Baker* Pastry Finisher* Pie Baker* Pie Maker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "342.9", 16.8f, "57,380" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,221.7", 60f, "37,050", "First-line supervisors of food preparation and serving workers    * Banquet Supervisor* Bar Manager* Cafeteria Manager* Dairy Bar Manager* Food Service Supervisor* Head Waiter* Head Waitress* Kitchen Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.9", 0.2f, "239,200", "Oral and maxillofacial surgeons    * Dental Surgeon* Maxillofacial Surgeon* Oral Surgeon" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.9", 0.3f, "50,990", "Choreographers    * Dance Director* Dance Master" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.1", 0.3f, "48,470", "Costume attendants    * Theatrical Wardrobe Attendant* Theatrical Wardrobe Dresser* Wardrobe Assistant* Wardrobe Attendant* Wardrobe Custodian* Wardrobe Dresser* Wardrobe Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.1", 0.5f, "64,030", "Arbitrators, mediators, and conciliators    * Alternative Dispute Resolution Coordinator* Mediation Commissioner* Ombudsman" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.0", 0.7f, "71,890", "Cartographers and photogrammetrists    * Cadastral Mapper* Digital Cartographer* Engineer, Photogrammetric* Map Maker* Mapper* Orthophotography Technician* Photo Cartographer* Photogrammetrist* Topographer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "326.3", 16.2f, "89,940", "Civil engineers    * Architectural Engineer* Bridge Engineer* Construction Engineer* Facilities Engineer* Geotechnical Engineer* Highway Engineer* Hydrographic Engineer* Railroad Design Consultant* Research Hydraulic Engineer* Structural Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "736.2", 36.8f, "57,890", "Computer user support specialists    * Computer Customer Support Specialist* Computer Help Desk Representative* Computer Help Desk Specialist* End-User Support Specialist* Help Desk Analyst* Help Desk Technician* IT Support Specialist* PC Support Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.1", 0.4f, "42,890", "Cooling and freezing equipment operators and tenders    * Ammonia Refrigeration Worker* Chiller Operator* Chiller Tender* Freezer Operator* Refrigerating Machine Operator* Refrigeration Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "7.9", 0.4f, "104,380", "Materials scientists    * Metal Alloy Scientist* Plastics Scientist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.7", 1f, "99,550", "Bioengineers and biomedical engineers    * Bio-Mechanical Engineer* Biochemical Engineer* Biomaterials Engineer* Biomedical Engineer* Dialysis Engineer* Genetic Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "22.3", 1.1f, "100,140", "Materials engineers    * Automotive Sheet Metal Engineer* Ceramic Engineer* Forensic Materials Engineer* Glass Science Engineer* Metallographer* Metallurgical Engineer* Metallurgist* Welding Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "26.3", 1.3f, "87,480", "Geoscientists, except hydrologists and geographers    * Crystallographer* Development Geologist* Environmental Geologist* Exploration Geologist* Geochemist* Geodesist* Geologist* Geomagnetist* Geophysicist* Geoscientist* Mine Geologist* Mineralogist* Mining Production Geologist* Oceanographer* Oceanologist* Paleontologist* Petroleum Geologist* Petrologist* Research Geologist* Sedimentationist* Seismologist* Stratigrapher* Volcanologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "33.7", 1.7f, "107,390", "Fundraising managers    * Donor Relations Manager* Foundation Director* Funding Coordinator* Fundraising Director" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "56.3", 2.9f, "106,420", "Psychologists, all other    * Developmental Psychologist* Experimental Psychologist* Forensic Psychologist* Neuropsychologist* Psychotherapist* Rehabilitation Psychologist* Social Psychologist* Sports Psychologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "169.1", 8.6f, "59,440", "Mobile heavy equipment mechanics, except engines    * Bulldozer Mechanic* Construction Equipment Mechanic* Dragline Mechanic* Forklift Mechanic* Forklift Technician* Logging Equipment Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1.5", 0.1f, "96,500", "Forestry and conservation science teachers, postsecondary    * Ecology Professor* Environmental Conservation Professor* Forest Biometrics Professor* Forest Ecology Professor* Forest Management Professor* Forest Pathology Professor* Forest Resources Professor* Forest Technology Professor* Silviculture Professor* Timber Management Professor* Wildlife Conservation Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.0", 0.5f, "83,930", "Life scientists, all other    * Life Science Taxonomist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.7", 1f, "57,290", "Surgical assistants    * Surgical First Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "21.2", 1.1f, "47,860", "Food science technicians    * Flavor Technician* Food Quality Control Technician* Food Quality Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "20.9", 1.1f, "81,990", "Microbiologists    * Bacteriologist* Clinical Microbiologist* Medical Microbiologist* Microbiological Analyst* Public Health Microbiologist* Quality Control Microbiologist* Virologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "29.1", 1.5f, "57,560", "Fine artists, including painters, sculptors, and illustrators    * Book Illustrator* Caricature Artist* Comic Artist* Comic Book Artist* Comic Illustrator* Commercial Artist* Concrete Sculptor* Editorial Cartoonist* Fashion Illustrator* Free Lance Artist* Fresco Artist* Glass Artist* Ice Sculptor* Medical Illustrator* Mural Painter* Muralist* Non-Representational Metal Sculptor* Oil Painter* Pattern Illustrator* Political Cartoonist* Portrait Artist* Portrait Painter* Scientific Illustrator* Sketch Artist* Sports Cartoonist* Stained Glass Artist* Water Colorist* Watercolor Artist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "44.4", 2.3f, "60,160", "Healthcare practitioners and technical workers, all other    * Podiatric Technician* Traditional Chinese Herbalist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "50.9", 2.7f, "78,810", "Psychology teachers, postsecondary    * Applied Psychology Professor* Child Development Professor* Clinical Psychology Professor* Educational Psychology Professor* Human Relations Professor* Industrial Psychology Professor* Industrial/Organizational Psychology Professor* Psychology Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "124.0", 6.5f, "61,190", "Fundraisers    * Campaign Fundraiser* Donor Relations Officer* Fundraising Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "191.6", 10f, "130,000", "Human resources managers    * Employee Relations Manager* Job Analysis Manager* Labor Relations Director* Personnel Administrator* Personnel Director* Personnel Manager* Position Description Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.5", 0.6f, "0", "Dancers    * Ballerina* Ballet Company Member* Ballet Dancer* Ballet Soloist* Burlesque Dancer* Dance Artist* Discotheque Dancer* Exotic Dancer* Go-Go Dancer* Line Dancer* Soft Shoe Dancer* Tap Dancer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "26.6", 1.4f, "72,220", "Acupuncturists    * Acupuncture Physician* Licensed Acupuncturist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "42.0", 2.2f, "84,760", "Computer science teachers, postsecondary    * C++ Professor* Computer Information Systems Professor* Computer Programming Professor* IT Professor* Information Systems Professor* Information Technology Professor* Java Programming Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "174.4", 9.2f, "56,520", "Chefs and head cooks    * Banquet Chef* Chef De Cuisine* Chef De Froid* Executive Chef* Head Chef* Kitchen Chef* Master Chef* Pastry Chef* Sous Chef* Sushi Chef" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "355.3", 18.9f, "50,820", "Child, family, and school social workers    * C-CYFSW* Certified Children, Youth, and Family Social Worker* Child Abuse Worker* Child Protective Services Social Worker* Child Protective Services Specialist* Child Welfare Social Worker* Child Welfare Worker* Child and Family Services Worker* Family Preservation Caseworker* Family Preservation Worker* Family Service Caseworker* Foster Care Social Worker* Foster Care Worker* School Social Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "655.0", 34.9f, "54,620", "Licensed practical and licensed vocational nurses    * LP Nurse* LPN* LVN* Licensed Practical Nurse* Licensed Vocational Nurse* Pediatric Licensed Practical Nurse* Triage Licensed Practical Nurse" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2,988.5", 158.8f, "36,110", "Laborers and freight, stock, and material movers, hand    * Cargo Handler* Cart Pusher* Freight Handler* Grave Digger* Manufacturing Laborer* Material Handler* Package Handler* Shipping and Receiving Material Handler* Van Loader* Wharf Laborer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "5.2", 0.3f, "27,260", "Entertainment attendants and related workers, all other    * Jockey Valet" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "32.8", 1.8f, "47,320", "Credit counselors    * Credit Counselor* Debt Management Counselor* Student Financial Aid Counselor* Student Loan Counselor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "66.7", 3.6f, "41,480", "Medical equipment preparers    * Central Sterile Supply Technician* Certified Registered Central Service Technician* Health Equipment Servicer* Medical Supply Technician* Oxygen Equipment Preparer* Sterile Preparation Technician* Sterile Processing Technician* Sterile Processing and Distribution Technician* Sterilization Specialist* Sterilization Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "98.3", 5.3f, "49,090", "Paramedics    * Ambulance Driver-Paramedic* Flight Paramedic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "109.2", 5.9f, "55,960", "Surgical technologists    * Certified Surgical Technologist* OR Tech* Operating Room Technician* Surgical Scrub Technologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "156.4", 8.4f, "50,890", "Bus drivers, transit and intercity    * Charter Coach Driver* Motor Coach Bus Driver* Motor Coach Driver* Motor Coach Tour Operator* Public Transit Bus Driver* Public Transit Trolley Driver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "170.7", 9.3f, "36,680", "Emergency medical technicians    * EMT* EMT-B* EMT-I/85* EMT-I/99" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "342.4", 18.4f, "60,140", "Educational, guidance, and career counselors and advisors    * Admissions Counselor* Career Counselor* Career Technical Counselor* Education Counselor* Guidance Counselor* International Student Counselor* School Adjustment Counselor* School Guidance Counselor* Student Advisor* Student Development Advisor* Student Services Counselor* Student Success Counselor* Study Abroad Advisor* Vocational Adviser" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "429.6", 23.4f, "60,670", "Property, real estate, and community association managers    * Apartment Manager* Building Rental Manager* Community Association Manager* Condominium Association Manager* Homeowner Association Manager* Land Acquisition Manager* Leasing Property Manager* Property Manager* Real Estate Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "51.5", 2.8f, "38,040", "Machine feeders and offbearers    * Brick Offbearer* Chain Offbearer* Chopper Feeder* Doffer* Dryer Feeder* Hopper Feeder* Hopper Filler* Line Feeder* Offbearer* Packing Machine Can Feeder* Spike Machine Feeder* Spinning Doffer* Spooler Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "63.6", 3.5f, "53,310", "Maintenance workers, machinery    * Crane Oiler" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "222.8", 12.2f, "65,140", "Radiologic technologists and technicians    * Computed Axial Tomography Technologist* Computed Tomography (CT) Scanner Operator* Radiologic Technician* Registered Radiologic Technologist* Skiagrapher* X-Ray Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "415.8", 23f, "51,390", "Heating, air conditioning, and refrigeration mechanics and installers    * Air Conditioning Service Technician* Bulk Cooler Installer* Evaporative Cooler Installer* Furnace Converter* Furnace Fitter* Gas Furnace Installer* Heating, Ventilation, and Air Conditioning (HVAC) Mechanic* Oil Burner Repairer* Oil Furnace Installer* Refrigeration Systems Installer* Stoker Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "38.7", 2.2f, "35,560", "Concierges    * Activities Concierge* Club Concierge* Conference Concierge* Guest Service Supervisor* Hotel Concierge* Hotel Guest Service Agent" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "250.8", 14f, "103,330", "Administrative services managers    * Business Office Manager* Business Unit Manager* Records Management Director* Records and Information Manager* University Registrar" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "459.6", 25.9f, "37,790", "Pharmacy technicians    * CPHT* Certified Pharmacy Technician* Pharmacist Technician* Pharmacy Laboratory Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3,172.5", 177.4f, "81,220", "Registered nurses    * CCU Nurse* CNS* Clinical Nurse Specialist* Community Health Nurse* Coronary Care Unit Nurse* Emergency Room RN* Endoscopy Registered Nurse* Hospice Registered Nurse* Obstetrical Nurse* Oncology Registered Nurse* PACU Nurse* Pediatric Registered Nurse* Post-Anesthesia Care Unit Nurse* Psychiatric Nurse* RN* Triage Registered Nurse" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "0.4", 0f, "0", "Prosthodontists    * Maxillofacial Prosthetics Dentist* Maxillofacial Prosthodontist* Reconstructive Dentist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.8", 0.2f, "69,390", "Animal scientists    * Animal Geneticist* Animal Nutritionist* Beef Cattle Nutritionist* Dairy Scientist* Poultry Scientist* Swine Genetics Researcher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "29.3", 1.7f, "48,280", "Motorboat mechanics and service technicians    * Certified Marine Mechanic* Marine Propulsion Technician* Marine Technician* Motorboat Mechanic* Outboard Motor Mechanic* Outboard Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "112.7", 6.4f, "40,420", "Healthcare support workers, all other    * Ortho/Prosthetic Aide" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "30.6", 1.8f, "36,890", "Conveyor operators and tenders    * Ash Conveyor Operator* Assembly Line Tender* Chip Bin Conveyor Tender* Conveyor Belt Operator* Conveyor Tender* Grain Elevator Operator* Packing Line Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "35.0", 2f, "48,380", "Environmental science and protection technicians, including health    * Air Quality Technician* Certified Indoor Environmentalist* Environmental Science Technician* Infectious Waste Technician* Pollution Control Technician* Public Health Sanitarian Technician* Radon Inspector" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1.8", 0.1f, "46,180", "Communications equipment operators, all other    * Communications Equipment Operator* Radio Operator* Telegraph and Teletype Operator* Telex Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.1", 0.6f, "139,280", "Industrial-organizational psychologists    * Engineering Psychologist* Human Resources Psychologist* I/O Psychologist* Industrial Psychologist* Management Psychologist* Organizational Psychologist* Organizational Research Consultant* Personnel Research Psychologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "72.0", 4.3f, "129,430", "Public relations managers    * Communication Manager* Public Affairs Director* Public Information Director* Public Information Relations Manager* Public Relations Director* Public Relations Manager* Publicity Director" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "874.5", 51.4f, "64,240", "Human resources specialists    * Corporate Recruiter* Credentialing Coordinator* Employee Placement Specialist* Human Resources Generalist* Job Placement Officer* Job Placement Specialist* Job Recruiter* Personnel Coordinator* Personnel Officer* Personnel Recruiter* Personnel Specialist* Staffing Coordinator* Student Recruiter* Volunteer Coordinator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.4", 0.3f, "68,300", "Commercial divers    * Marine Diver* Non Destructive Testing Underwater Welder* Salvage Diver* Scuba Diver* Submarine Diver* Underwater Welder" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "95.7", 5.7f, "35,720", "Residential advisors    * Dormitory Counselor* House Parent* Residence Director* Residence Life Coordinator* Residential Director* Residential Life Director* Sorority Mother" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "38.3", 2.3f, "52,120", "Private detectives and investigators    * Certified Legal Investigator* Licensed Private Investigator* Loss Prevention Detective* Private Detective* Private Eye* Private Investigator* Skip Tracer* Store Detective" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "47.3", 2.9f, "96,530", "Environmental engineers    * Air Pollution Control Engineer* Environmental Remediation Engineer* Hazardous Substances Engineer* Hazardous Waste Management Control Engineer* Pollution Control Engineer* Soil Engineer* Waste Management Engineer* Wastewater Treatment Engineer* Water Treatment Plant Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "63.8", 3.9f, "126,880", "Aerospace engineers    * Aerodynamics Engineer* Aeronautical Engineer* Aircraft Design Engineer* Aircraft Designer* Aircraft Engineer* Astronautical Engineer* Flight Systems Test Engineer* Flight Test Engineer* Wind Tunnel Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "80.5", 4.9f, "76,480", "Environmental scientists and specialists, including health    * Ecological Modeler* Environmental Analyst* Environmental Scientist* Hazardous Substances Scientist* Health Environmentalist* Water Pollution Scientist* Water Quality Analyst" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "135.1", 8.2f, "105,180", "Art directors    * Magazine Designer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "136.0", 8.3f, "73,810", "Financial specialists, all other    * Bail Bondsman* Bondsman* Executor of Estate" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "297.1", 18f, "67,440", "Public relations specialists    * Environmental Communications Specialist* Lobbyist* Media Relations Specialist* Press Agent* Press Secretary* Public Affairs Officer* Public Relations Counselor* Public Relations Officer* Public Relations Representative* Publicist* Publicity Agent* Publicity Writer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.1", 0.3f, "71,700", "Mathematical science occupations, all other    * Harmonic Analyst* Mathematical Engineering Technician* Mathematics Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "87.1", 5.4f, "80,670", "Chemists    * Agricultural Chemist* Analytical Chemist* Bench Chemist* Food Chemist* Formulary Chemist* Industrial Chemist* Inorganic Chemist* Laboratory Chemist* Nuclear Chemist* Organic Chemist* Quality Control Chemist* Research and Development Chemist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "113.5", 7f, "27,270", "Lifeguards, ski patrol, and other recreational protective service workers    * Beach Lifeguard* Certified Ski Patroller* Life Guard* OEC Technician* Outdoor Emergency Care Technician* Pool Lifeguard* Ski Patrol" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "881.3", 54.7f, "95,370", "Project management specialists    * Design Project Management Specialists* Movie Project Management Specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1.6", 0.1f, "83,260", "Agricultural engineers    * Agricultural Engineer* Agricultural Production Engineer* Agricultural Research Engineer* Farm Equipment Engineer* Research Agricultural Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.6", 1.1f, "113,940", "Economists    * Agricultural Economist* Econometrician* Economic Development Specialist* Economic Research Analyst* Environmental Economist* Industrial Economist* Labor Economist* Price Economist* Social Economist* Tax Economist* Trade Economist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "27.7", 1.7f, "31,510", "Baggage porters and bellhops    * Baggage Porter* Bell Staff* Bellperson* Bellstaff* Hotel Baggage Handler* Luggage Attendant* Redcap* Skycap" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "173.7", 11f, "59,960", "Telecommunications equipment installers and repairers, except line installers    * Communications Equipment Installer* Fiber Optic Central Office Installer* Headend Technician* Private Branch Exchange (PBX ) Installer and Repairer* Switchboard Wirer* Telecommunications Switch Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "385.8", 24.2f, "63,080", "Training and development specialists    * Computer Software Training Specialist* Computer Training Specialist* Corporate Trainer* Employee Development Specialist* Insurance Employee Trainer* Job Training Specialist* Training Coordinator* Training Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2,851.6", 178.6f, "34,220", "Stockers and order fillers    * Grocery Stocker* Night Stocker* Retail Stocker* Store Stocker* Warehouse Stocker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.2", 0.5f, "120,880", "Nurse midwives    * Certified Nurse Midwife* Certified Nurse Midwife (CNM)" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "762.6", 49.2f, "60,240", "Electricians    * Chief Electrician* Control Electrician* Electrical Maintenance Worker* Electrical Sign Wirer* House Wirer* Licensed Electrician* Lighting Fixture Installer* Marine Electrician* Master Electrician* Solar Photovoltaic Electrician* Stage Electrician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "41.3", 2.7f, "120,000", "Training and development managers    * E-Learning Manager* Employee Development Director* Employee Development Manager* Labor Training Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "103.0", 6.7f, "47,290", "Community and social service specialists, all other    * Community Organization Worker* Veterans Service Officer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "6.2", 0.4f, "128,020", "Political scientists    * Government Affairs Researcher* Government Affairs Specialist* Local Governance and Citizen Participation Specialist* Political Consultant* Political Research Scientist* Political Researcher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "68.4", 4.5f, "61,420", "Social workers, all other    * Adult Protective Service Social Worker* Criminal Justice Social Worker* Forensic Social Worker* Sexual Assault Social Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "78.6", 5.2f, "66,450", "Dietitians and nutritionists    * Clinical Dietitian* Dietitian* Nutritionist* Pediatric Dietician* Public Health Dietitian* Public Health Nutritionist* Research Dietitian* Sports Nutritionist* Therapeutic Dietitian" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "168.0", 11.1f, "44,990", "Health technologists and technicians, all other    * CRTT* Certified Respiratory Therapy Technician* Dialysis Technician* Electroencephalogram (EEG) Technologist* Electroneurodiagnostic Technologist* Encephalographer* Oxygen Therapy Technician* Perfusionist* Polysomnograph Tech* Respiratory Therapy Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "358.2", 23.7f, "140,040", "Marketing managers    * Internet Marketing Manager* Marketing Administrator* Marketing Director* VP Marketing" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "28.6", 1.9f, "226,880", "Psychiatrists    * Addiction Psychiatrist* Child Psychiatrist* Clinical Psychiatrist* Forensic Psychiatrist* Geriatric Psychiatrist* Neuropsychiatrist* Pediatric Psychiatrist* Staff Psychiatrist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "34.5", 2.3f, "103,810", "Biochemists and biophysicists    * Biochemist* Biological Chemist* Biophysicist* Clinical Biochemist* Physical Biochemist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "50.8", 3.4f, "61,910", "Lodging managers    * Bed and Breakfast Innkeeper* Boardinghouse Keeper* Hotel Director* Hotel Manager* Hotel Operations Manager* Innkeeper* Lodging Facilities Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "112.1", 7.5f, "60,580", "Telecommunications line installers and repairers    * Cable Television Installer* FIOS Line Installer* Fiber Optic Technician* Telecommunication Lines Repairer* Telecommunications Line Installer* Telephone Cable Splicer* Telephone Lines Repairer* Telephone Lineworker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "175.3", 11.7f, "85,320", "Producers and directors    * Broadcast Producer* Casting Director* Film Maker* Independent Film Maker* Independent Video Producer* Motion Picture Director* Movie Producer* Music Video Director* Music Video Producer* News Production Supervisor* Newscast Director* Newscast Producer* On-Air Director* Pageant Director* Radio Producer* Radio and Television Technical Director* Stage Manager* Television News Producer* Television Newscast Director* Television Producer* Television Program Director* Theater Company Producer* Video Producer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "696.6", 46.6f, "38,500", "Medical secretaries and administrative assistants    * Dental Secretary* Hospital Secretary* Psychiatric Secretary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "53.3", 3.7f, "79,960", "Technical writers    * Assembly Instructions Writer* Documentation Writer* Engineering Writer* Handbook Writer* Specifications Writer* Technical Communicator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "59.4", 4.1f, "48,340", "Tile and stone setters    * Ceramic Tile Installer* Hard Tile Setter* Marble Ceiling Installer* Parquet Floor Layer* Tile Installer* Tile Mason* Wood Tile Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "99.9", 6.9f, "88,790", "Business teachers, postsecondary    * Accounting Professor* Banking and Finance Instructor* Business Administration Professor* Finance Professor* Management Professor* Marketing Instructor* Marketing Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "371.0", 25.7f, "44,820", "Dental assistants    * Certified Dental Assistant* Dental Aide* Expanded Functions Dental Assistant* Orthodontic Assistant* Orthodontist Assistant* Registered Dental Assistant* Surgical Dental Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "12.9", 0.9f, "30,210", "Locker room, coatroom, and dressing room attendants    * Athletic Equipment Manager* Bathhouse Attendant* Checkroom Attendant* Cloak Room Attendant* Coat Checker* Ladies Locker Room Attendant* Locker Room Attendant* Locker Room Manager* Locker Room Supervisor* Washroom Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "63.1", 4.4f, "34,990", "Barbers    * Barber Apprentice* Master Barber" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "85.2", 6f, "99,890", "Database administrators    * Automatic Data Processing Planner* Database Administration Manager* Database Coordinator* Database Programmer* Database Security Administrator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "98.2", 6.9f, "67,780", "Compensation, benefits, and job analysis specialists    * Benefits Analyst* Compensation Analyst* Compensation Specialist* Employee Benefits Specialist* Job Analyst* Job Specification Writer* Occupational Analyst* Pension Administrator* Position Classification Specialist* Retirement Plan Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "177.9", 12.5f, "68,050", "Computer network support specialists    * Network Diagnostic Support Specialist* Network Support Technician* Network Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "60.4", 4.4f, "59,990", "Health education specialists    * Certified Diabetes Educator* Certified Health Education Specialist* Community Health Education Coordinator* Diabetes Educator* Health Educator* Public Health Educator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "110.9", 7.9f, "108,170", "Electronics engineers, except computer    * Antenna Engineer* Circuit Design Engineer* Electronic Design Automation Engineer* Electronic Engineer* Electronic Parts Designer* Telecommunication Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "27.8", 2f, "59,990", "Set and exhibit designers    * Scenic Designer* Set Decorator* Set Designer* Stage Scenery Designer* Theater Set Production Designer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "30.2", 2.2f, "48,870", "Floor layers, except carpet, wood, and hard tiles    * Composition Floor Layer* Cork Floor Installer* Laminate Floor Installer* Linoleum Installer* Resilient Tile Installer* Shock-Absorption Floor Layer* Vinyl Flooring Installer* Vinyl Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1.6", 0.1f, "49,330", "Farm labor contractors    * Farm Labor Contractor* Harvesting Contractor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "29.5", 2.2f, "45,610", "Septic tank servicers and sewer pipe cleaners    * Electric Sewer Cleaning Machine Operator* Septic Pump Truck Driver* Septic Tank Cleaner* Sewage Screen Operator* Sewer Cleaner* Sewer Pipe Cleaner* Sewer and Drain Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "219.4", 16.3f, "81,400", "Dental hygienists    * Oral Hygienist* RDH* Registered Dental Hygienist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "482.2", 35.6f, "67,480", "Securities, commodities, and financial services sales agents    * Commodities Broker* Commodity Trader* Equity Trader* Foreign Exchange Trader* Investment Banker* Municipal Bond Trader* Mutual Fund Sales Agent* Securities Trader* Stock Broker* Stock Trader" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "15.3", 1.1f, "79,860", "Food scientists and technologists    * Dairy Bacteriologist* Enologist* Food Preservation Scientist* Food Processing Scientist* Food Safety Scientist* Food Scientist* Food Technologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "132.0", 9.9f, "52,560", "Meeting, convention, and event planners    * Certified Meeting Professional* Conference Organizer* Conference Planner* Conference Planning Manager* Conference Services Director* Conference Services Manager* Convention Planner* Convention Services Manager* Corporate Meeting Planner* Event Planner* Events Manager* Wedding Planner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "826.3", 62.4f, "135,740", "Lawyers    * Agency Legal Counsel* Assistant Attorney General* Assistant Corporation Counsel* Assistant Counsel* Associate Attorney* Attorney* Attorney At Law* Attorney General* Brief Writer* City Attorney* Civil Lawyer* Commonwealth Attorney* Corporate Attorney* Corporate Counsel* Corporate Counselor* County Attorney* Defense Attorney* Deputy Attorney General* Deputy Chief Counsel* District Attorney* Environmental Attorney* Estate Conservator* General Counsel* Insurance Attorney* Legal Counsel* Probate Lawyer* Prosecutor* Public Defender* Real Estate Attorney* Sports Attorney* Tax Attorney* Trial Attorney* Trial Lawyer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "317.2", 24.2f, "95,080", "Financial and investment analysts    * Corporate Financial Analyst* Corporate Securities Research Analyst* Corporate Statistical Financial Analyst* Institutional Commodity Analyst* Organizational Investment Analyst" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "41.4", 3.2f, "80,090", "Magnetic resonance imaging technologists    * Computed Tomography/Magnetic Resonance Imaging (CT/MRI) Technologist* MRI Technologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "114.6", 8.8f, "44,660", "First-line supervisors of entertainment and recreation workers, except gambling services    * Arcade Supervisor* Caddy Master* Recreation Attendant Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "139.4", 10.8f, "38,530", "Phlebotomists    * Certified Phlebotomy Technician* Phlebotomy Technician* Venipuncturist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "541.0", 41.9f, "32,690", "Driver/sales workers    * Bobtailer* Delivery Sales worker* Newspaper Deliverer* Newspaper Delivery Driver* Pizza Delivery Driver* Route Sales Person* Route Salesperson* Sales Route Driver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "555.8", 42.8f, "33,290", "Hairdressers, hairstylists, and cosmetologists    * Beautician* Cosmetologist* Funeral Home Makeup Artist* Hair Colorist* Hair Stylist* Hair and Makeup Designer* Hairdresser* Hairpiece Stylist* Wedding Makeup Artist* Wig Stylist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "171.5", 13.4f, "36,580", "Food batchmakers    * Almond Paste Mixer* Candy Maker* Candy Puller* Cheese Processor* Cottage Cheese Maker* Dough Scaler and Mixer* Frozen Yogurt Maker* Honey Blender* Ice Cream Maker* Liquid Sugar Fortifier* Peanut Butter Maker* Pickle Maker* Relish Maker* Taffy Puller" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "68.3", 5.4f, "33,210", "Motor vehicle operators, all other    * Assembly Line Driver* Ice-Resurfacing Machine Operators* Motorcycle Deliverer* Street Cleaning Equipment Operator* Street Sweeper Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "151.2", 12f, "44,930", "Highway maintenance workers    * Highway Maintainer* Highway Maintenance Crew Worker* Highway Worker* Lane Marker Installer* Road Patcher* Road Sign Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "536.8", 42.5f, "57,860", "Insurance sales agents    * Health Insurance Sales Agent* Insurance Agent* Insurance Broker* Life Insurance Agent* Life Insurance Salesperson* Pension Agent" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "24.6", 2f, "44,690", "Semiconductor processing technicians    * Electronic Semiconductor Processor* Semiconductor Assembler* Wafer Fabricator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "218.4", 17.5f, "32,800", "Shuttle drivers and chauffeurs    * Airport Apron Bus Driver* Airport Shuttle Driver* Airside Transfer Bus Driver* Courtesy Car Driver* Courtesy Van Driver* Funeral Car Driver* Hearse Driver* Hotel Shuttle Driver* Nonemergency Medical Transporter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "20.8", 1.7f, "106,260", "Chemical engineers    * Absorption and Adsorption Engineer* Chemical Process Engineer* Chemical Research Engineer* Fuels Engineer* Oxidation Engineer* Plastics Engineer* Polymerization Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "45.6", 3.7f, "48,010", "Farm equipment mechanics and service technicians    * Agricultural Equipment Mechanic* Combine Mechanic* Dairy Equipment Mechanic* Dairy Equipment Repairer* Harvester Mechanic* Irrigation Equipment Mechanic* Milking Machine Mechanic* Tractor Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "53.6", 4.3f, "34,440" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.4", 0.8f, "58,640", "Archivists    * Digital Archivist* Film Archivist* Historical Records Administrator* Image Archivist* Museum Archivist* Processing Archivist* Reference Archivist* State Archivist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "19.9", 1.6f, "82,530", "Agents and business managers of artists, performers, and athletes    * Artist Manager* Artist Representative* Author's Agent* Band Manager* Booking Agent* Booking Manager* Fight Manager* Literary Agent* Modeling Agent* Talent Agent* Talent Manager* Theatrical Agent" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "26.5", 2.2f, "0", "Entertainers and performers, sports and related workers, all other    * Acrobat* Aerialist* Amusement Park Entertainer* Bareback Rider* Baton Twirler* Clown* Comedian* Fortune Teller* Impersonator* Juggler* Magician* Marionette Performer* Palmist* Professional Poker Player* Prompter* Puppeteer* Ringmaster* Rodeo Performer* Story Teller* Stunt Performer* Tumbler* Ventriloquist* Wire Walker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "58.9", 4.8f, "102,120", "Financial risk specialists    * Financial Risk Analyst" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "89.3", 7.4f, "98,950", "Special effects artists and animators    * 3D Animator* Animator* Multimedia Artist* Special Effects Artist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "177.7", 14.6f, "98,560", "Transportation, storage, and distribution managers    * Airport Manager* Cold Storage Supervisor* Distribution Center Manager* Logistics Manager* Logistics Supply Officer* Marine Oil Terminal Superintendent* Traffic Safety Administrator* Transportation Manager* Warehouse Manager* Warehouse Operations Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.2", 0.8f, "74,410", "Aerospace engineering and operations technologists and technicians    * Aerospace Engineering and Operations Technologist* Altitude Chamber Technician* Flight Data Technician* Wind Tunnel Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "26.4", 2.2f, "67,220", "Entertainment and recreation managers, except gambling    * Amusement Park Manager* Boat Club Manager* Fitness Club Manager* Golf Club Manager* Marina Club Manager* Skating Rink Manager* Ski Resort Manager* Tennis Club Manager* Theme Park Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "159.0", 13.1f, "43,680", "First-line supervisors of personal service workers    * Animal Trainer Supervisor* Child Care Worker Supervisor* Hair Salon Supervisor* Head Butler" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "194.3", 16.5f, "47,180", "Medical records specialists    * Health Information Coder* Health Records Technician* Medical Bill Coder" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "4.6", 0.4f, "96,370", "Makeup artists, theatrical and performance    * Special Effects Makeup Artist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "8.0", 0.7f, "53,490", "Aircraft cargo handling supervisors    * Air Cargo Ground Crew Supervisor* Air Cargo Ground Operations Supervisor* Air Cargo Supervisor* Aircraft Loadmaster* Airport Ramp Supervisor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "62.4", 5.3f, "81,650", "Biological science teachers, postsecondary    * Anatomy Professor* Bacteriology Professor* Biochemistry Professor* Botany Professor* Embryology Professor* Microbiology Professor* Zoology Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "64.0", 5.5f, "37,780", "Agricultural equipment operators    * Cane Flume Chute Operator* Combine Driver* Combine Operator* Corn Detasseler Machine Operator* Cotton Ginner* Cotton Picker Operator* Custom Harvester* Farm Tractor Operator* Feed Mixer Operator* Hay Baler* Hay Stacker Operator* Rake Operator* Replanting Machine Operator* Tractor Operator* Wheat Combine Driver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "415.1", 35.6f, "38,520", "Social and human service assistants    * Addictions Counselor Assistant* Case Work Aide* Clinical Social Work Aide* Family Service Assistant* Human Services Worker* Social Work Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "196.9", 17.1f, "31,130", "Manicurists and pedicurists    * Fingernail Sculptor* Nail Technician* Pedicurist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "43.4", 3.8f, "125,590", "Optometrists    * Doctor of Optometry" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "55.0", 4.9f, "75,380", "Chiropractors    * Chiropractic Doctor* Chiropractic Physician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "49.4", 4.5f, "203,090", "Nurse anesthetists    * Certified Registered Nurse Anesthetist* Certified Registered Nurse Anesthetist (CRNA)* DNAP* Doctor of Nurse Anesthesia Practice" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.0", 1.3f, "94,270", "Athletes and sports competitors    * National Association for Stock Car Auto Racing Driver* Profession Cyclist* Professional All Terrain Vehicle Racer* Professional Athlete* Professional Auto Racer* Professional Baseball Pitcher* Professional Baseball Player* Professional Basketball Player* Professional Bass Fisher* Professional Bicycle Racer* Professional Bicyclist* Professional Billiard Player* Professional Bowler* Professional Bull Rider* Professional Car Racer* Professional Dirt Bike Racer* Professional Drag Car Racer* Professional Figure Skater* Professional Football Player* Professional Golfer* Professional Hockey Player* Professional Horse Racer* Professional Ice Skater* Professional Jockey* Professional Kick Boxer* Professional Motocross Racer* Professional Prize Fighter* Professional Pugilist* Professional Race Car Driver* Professional Roller Skater* Professional Skater* Professional Skier* Professional Snowboarder* Professional Soccer Player* Professional Softball Player* Professional Stock Car Driver* Professional Surfer* Professional Swimmer* Professional Tennis Player* Professional Volleyball Player* Professional Wrestler" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "82.0", 7.5f, "38,060", "Skincare specialists    * Electrolysis Needle Operator* Electrolysis Operator* Electrolysist* Esthetician* Facialist* Licensed Esthetician* Medical Esthetician* Skin Care Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "178.4", 16.2f, "74,240", "Social and community service managers    * Child Welfare Director* Community Service Director* Community Service Organization Director* Family Service Center Director* Neighborhood Service Center Director* Social Service Director* Social Services Director* Youth Program Director" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "275.2", 25.3f, "44,890", "Coaches and scouts    * Athletic Coach* Baseball Coach* Baseball Scout* Basketball Coach* Boxing Coach* Coach* Football Coach* Hockey Scout* Ice Skating Coach* Riding Coach* Ski Coach* Tennis Coach" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "45.5", 4.2f, "103,550", "Engineering teachers, postsecondary    * Aeronautical Engineering Professor* Ceramic Engineering Professor* Chemical Engineering Professor* Civil Engineering Professor* Electrical Engineering Professor* Electronics Engineering Professor* Industrial Engineering Professor* Manufacturing Engineering Professor* Marine Engineering Professor* Mechanical Engineering Professor* Petroleum Engineering Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "51.0", 4.8f, "63,520", "Film and video editors    * Cue Selector* Electronic News Gathering Editor* Film Editor* Movie Editor* News Video Editor* News Videotape Editor* Tape Editor* Television News Video Editor* Video Tape Transferrer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "28.0", 2.7f, "47,010", "Mechanical door repairers    * Automatic Door Mechanic* Door Closer Mechanic* Garage Door Technician* Overhead Door Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "191.4", 18.4f, "60,280", "Healthcare social workers    * AIDS Social Worker* C-SWHC* Certified Social Workers In Health Care* Hospice Home Care Social Worker* Hospice Social Worker* Hospital Social Worker* Medical Social Worker* Neonatal Social Worker* Nephrology Social Worker* Oncology Social Worker* Pediatric Social Worker* Public Health Social Worker* Renal Social Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "531.4", 51.1f, "102,240", "Computer systems analysts    * Applications Analyst* Computer Systems Consultant* Data Processing Systems Analyst* Information Systems Analyst* Information Systems Planner* Programmer Analyst* Systems Architect" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "20.4", 2f, "36,010", "Umpires, referees, and other sports officials    * Athletic Events Scorer* Baseball Umpire* Diving Judge* Dressage Judge* Equestrian Events Judge* Handicapper* Horse Show Judge* Paddock Judge* Pit Steward* Placing Judge* Race Starter" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "95.9", 9.3f, "46,860", "Cargo and freight agents    * Cargo Agent* Cargo Router* Freight Agent* Freight Shipping Agent" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "107.1", 10.4f, "37,380", "Psychiatric technicians    * Behavioral Health Technician* Mental Health Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "449.4", 43.8f, "98,740", "Computer occupations, all other    * Computer Console Operator* Computer Laboratory Technician* Data Center Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "987.6", 95.7f, "95,290", "Management analysts    * Business Analyst* Business Consultant* Business Management Analyst* Business Process Consultant* Clerical Methods Analyst* Commercial Specialist* Industrial Analyst* Management Consultant* Records Management Analyst* University Institutional Researcher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "17.7", 1.7f, "45,030", "Recreational vehicle service technicians    * Master Certified RV Technician* Mobile Service Recreational Vehicle Technician* RV Mechanic* RV Servicer* RVDA Master Certified RV Technician* Recreational Vehicle (RV) Repairer* Recreational Vehicle Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "119.0", 11.6f, "99,930", "Medical scientists, except epidemiologists    * Cancer Researcher* Clinical Pharmacologist* Gerontologist* Histopathologist* Immunochemist* Industrial Pharmacist* Medical Health Researcher* Medical Research Scientist* Medical Scientist* Neuroscientist* Pharmacologist* Serologist* Toxicologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.4", 1.4f, "47,270", "Museum technicians and conservators    * Art Conservator* Art Handler* Conservation Technician* Ethnographic Materials Conservator* Museum Exhibit Technician* Objects Conservator* Paintings Conservator* Paper Conservator* Textile Conservator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "64.0", 6.4f, "134,870", "Database architects    * Data Architect* Data Integration Specialist* Data Warehousing Specialist* Database Developer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "286.1", 28.5f, "96,310", "Mechanical engineers    * Auto Research Engineer* Combustion Engineer* Engine Designer* Heating and Cooling Systems Engineer* Tool Engineer* Tool and Die Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "24.7", 2.5f, "57,970", "Occupational health and safety technicians    * CHST* Construction Health and Safety Technician* Environmental Health Technologist* Ergonomics Technician* Occupational Health and Safety Technologist* Occupational Health and Safety Technologist (OHST)" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "16.5", 1.7f, "51,350", "Exercise physiologists    * Applied Exercise Physiologist* Clinical Exercise Physiologist* Kinesiotherapist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "14.4", 1.5f, "82,680", "Audiologists    * Clinical Audiologist* Dispensing Audiologist* Educational Audiologist* Hearing Therapist* Licensed Audiologist* Pediatric Audiologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "113.5", 12f, "51,240", "Mental health and substance abuse social workers    * Community Mental Health Social Worker* Drug Abuse Social Worker* Psychiatric Social Worker* Psychotherapist Social Worker" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "13.9", 1.5f, "60,380", "Curators    * Collections Curator* Collections and Archives Director* Educational Institution Curator* Exhibitions and Collections Manager* Herbarium Curator* Museum Curator* Photography and Prints Curator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.3", 1.3f, "27,860", "Shampooers    * Scalp Treatment Specialist* Shampoo Assistant* Shampoo Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "67.5", 7.7f, "90,130", "Clinical and counseling psychologists    * Eating Disorder Psychologists* Geropsychologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "111.1", 12.6f, "63,760", "Flight attendants    * Airline Flight Attendant* Airplane Flight Attendant* Flight Steward" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "139.6", 16.1f, "93,180", "Occupational therapists    * OT* Occupational Therapist* Registered Occupational Therapist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,164.6", 133.8f, "40,410", "Light truck drivers    * Grocery Light Truck Driver* Parcel Truck Driver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "327.3", 38.4f, "96,350", "Industrial engineers    * Efficiency Engineer* Manufacturing Engineer* Packaging Engineer* Production Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "42.3", 5.2f, "60,800", "Therapists, all other    * Art Therapist* Auriculotherapist* Educational Therapist* Hydrotherapist* Music Therapist* Peripatologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "133.1", 16.7f, "70,540", "Respiratory therapists    * CRT* Certified Respiratory Therapist* Inhalation Therapist* Oxygen Therapist* RRT* Registered Respiratory Therapist* Respiratory Therapist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "18.5", 2.3f, "63,740", "Forensic science technicians    * Ballistic Technician* Ballistician* Ballistics Expert* Crime Lab Technician* Crime Scene Technician* Criminalist Technician* Fingerprint Expert* Forensic Analyst* Handwriting Expert* Trace Evidence Technician* Wildlife Forensic Geneticist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "66.5", 8.4f, "38,860", "Ophthalmic medical technicians    * Ocular Care Technologist* Ophthalmic Technologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "327.6", 42f, "95,390", "Personal financial advisors    * Certified Financial Planner* Estate Planner* Estate Planning Counselor* Financial Counselor* Individual Pension Adviser* Individual Pension Consultant* Personal Financial Planner* Personal Investment Adviser" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "66.4", 8.8f, "57,860", "Medical equipment repairers    * BMET* Biomedical Electronics Technician* Biomedical Equipment Technician* Certified Biomedical Equipment Technician* Dental Equipment Mechanic* Dental Equipment Repairer* Durable Medical Equipment Repairer* Electromedical Equipment Technician* Radiology Equipment Servicer* Surgical Instrument Mechanic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "113.8", 15.2f, "78,570", "Occupational health and safety specialists    * Certified Industrial Hygienist* Certified Professional Ergonomist* Environmental Health Sanitarian* Health and Safety Inspector* Industrial Hygienist* Industrial Safety and Health Specialist* Occupational Safety and Health Inspector* Radiological Health Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "868.6", 116.6f, "68,230", "Market research analysts and marketing specialists    * Advertising Analyst* Market Research Analyst* Market Research Specialist* Marketing Analyst* Marketing Consultant* Marketing Forecaster* Marketing Specialist* Search Marketing Strategist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "329.5", 45.2f, "45,380", "Exercise trainers and group fitness instructors    * Aerobics Instructor* Certified Personal Trainer* Fitness Trainer* Group Exercise Instructor* Group Fitness Instructor* Personal Fitness Trainer* Personal Trainer* Weight Trainer* Weight Training Instructor* Yoga Instructor* Yoga Teacher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "764.4", 105.9f, "38,270", "Medical assistants    * Autopsy Assistant* Certified Medical Assistant* Chiropractic Assistant* Clinical Medical Assistant* Morgue Attendant* Ocular Care Aide* Optometric Aide* Optometrist Assistant* Optometry Assistant* Orthopedic Cast Specialist* Podiatric Aide" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "33.8", 4.8f, "53,840", "Athletic trainers    * Certified Athletic Trainer* Clinical Athletic Instructor* Resident Athletic Trainer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "67.2", 9.4f, "46,190", "Community health workers    * CHW* Community Health Advisor* Community Health Representative* Lay Health Advocate* Peer Health Promoter* Promotor(a)" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "83.8", 12f, "81,350", "Diagnostic medical sonographers    * Cardiac/Vascular Sonographer* Echocardiogram Technician* Echocardiographer* Echocardiographic Technologist* Echocardiography Technician* Echocardiology Technologist* Registered Diagnostic Medical Sonographer* Sonographer* Ultrasonographer* Ultrasound Technician* Ultrasound Technologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.2", 1.5f, "59,020", "Hearing aid specialists    * Hearing Aid Fitter* Hearing Aid Technician* Hearing Instrument Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "2.4", 0.4f, "48,110", "Forest fire inspectors and prevention specialists    * Environmental Protection Fire Control Officer* Fire Operations Forester* Fire Ranger* Forest Fire Control Officer* Forest Fire Officer* Wildfire Prevention Specialist* Wildland Fire Operations Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "71.2", 10.6f, "56,570", "Marriage and family therapists    * Child and Family Counselor* Couples Therapist* Family Counselor* Family Therapist* Marriage Counselor* Marriage Therapist* Relationship Counselor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "402.2", 59.9f, "59,830", "Industrial machinery mechanics    * Bag Machine Adjuster* Boilerhouse Mechanic* Foundry Equipment Mechanic* Hydroelectric Machinery Mechanic* Industrial Conveyor Belt Repairer* Loom Fixer* Loom Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "246.8", 37.3f, "97,720", "Physical therapists    * Cardiopulmonary Physical Therapist* Geriatric Physical Therapist* Orthopedic Physical Therapist* PT* Pediatric Physical Therapist* Physiotherapist* Pulmonary Physical Therapist* Sports Physical Therapist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "117.9", 17.9f, "83,240", "Web and digital interface designers    * Digital Designer* Graphic Web Designer* Web Content Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "9.5", 1.5f, "77,070", "Orthotists and prosthetists    * American Board Certified Orthotist* Artificial Limb Fitter* Certified Orthotic Fitter* Certified Prosthetist/Orthotist* Licensed Prosthetist* Orthotic/Prosthetic Practitioner* Orthotist* Pedorthist* Prosthetist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "557.4", 86f, "164,070", "Computer and information systems managers    * Application Development Director* Chief Technology Officer* Computer Operations Manager* Computer Security Manager* Data Operations Director* Data Processing Manager* Information Systems Director* Information Systems Manager* Information Technology Director* Information Technology Systems Director* Internet Technology Manager* MIS Director* Management Information Systems Director" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "339.0", 52.5f, "29,530", "Animal caretakers    * Animal Care Giver* Animal Care Technician* Animal Caregiver* Animal Daycare Provider* Animal Groomer* Animal Shelter Worker* Animal Sitter* Aquarist* Aquarium Tank Attendant* Cat and Dog Bather* Dog Bather* Dog Beautician* Dog Groomer* Dog Sitter* Horse Exerciser* Kennel Aide* Kennel Attendant* Kennel Helper* Kennel Worker* Pet Feeder* Pet Groomer* Pet Sitter* Pet Stylist* Zookeeper" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "28.5", 4.6f, "60,800", "Computer numerically controlled tool programmers    * Computer Numerically Controlled (CNC) Programmer* Numerical Control Programmer* Numerical Tool Programmer* Numerical Tool and Process Control Programmer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "54.1", 8.7f, "35,620", "Animal trainers    * Dog Handler* Dog Trainer* Dolphin Trainer* Guide Dog Instructor* Guide Dog Mobility Instructor* Guide Dog Trainer* Horse Breaker* Licensed Guide Dog Instructor* Lion Trainer* Marine Mammal Trainer* Seeing Eye Dog Trainer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "792.6", 126.6f, "139,790", "Financial managers    * Bank Branch Manager* Banking Center Manager* Banking Manager* City Comptroller* City Treasurer* Comptroller* Credit Manager* Financial Director* Financial Officer* Fiscal Manager* International Bank Manager* Residential Mortgage Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "3.5", 0.6f, "89,990", "Genetic counselors    * Certified Genetic Counselor* Chromosomal Disorders Counselor* Mitochondrial Disorders Counselor* Prenatal Genetic Counselor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "37.9", 6.2f, "58,250", "Health information technologists and medical registrars    * Cancer Registrar* Clinical Informatics Analyst* Health Informatics Specialist* Health Information Analyst* Health Information Systems Technician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "98.8", 16.7f, "78,580", "Web developers    * Intranet Developer* Web Applications Developer* Web Architect* Web Content Developer* Web Developer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "68.2", 11.7f, "43,390", "Counselors, all other    * AIDS Counselor* Anger Control Counselor* Grief Counselor* HIV Counselor* Sexual Assault Counselor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "85.9", 15.6f, "78,580", "Nursing instructors and teachers, postsecondary    * Advanced Nursing Professor* Clinical Nursing Instructor* Clinical Nursing Professor* Registered Nursing Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "134.3", 24.6f, "49,860", "Massage therapists    * Deep Tissue Massage Therapist* Licensed Massage Practitioner* Licensed Massage Therapist* Masseur* Masseuse* Massotherapist* Rolfer* Swedish Masseuse" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "208.7", 38.3f, "77,520", "Logisticians    * Logistician* Logistics Analyst* Logistics Coordinator* Logistics Planner* Logistics Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "388.2", 71.5f, "49,710" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "262.8", 50.2f, "100,300", "Health specialties teachers, postsecondary    * Clinical Laboratory Science Professor* Clinical Sciences Professor* Dentistry Professor* Gastroenterology Professor* Neurology Professor* Nutrition Professor* Occupational Therapy Professor* Optometry Professor* Pharmacology Professor* Physical Therapy Professor* Podiatric Medicine Professor* Podiatry Professor* Public Health Professor" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "171.4", 33.1f, "84,140", "Speech-language pathologists    * Language Pathologist* Public School Speech Clinician* Public School Speech Therapist* Speech Clinician* Speech Pathologist* Speech Therapist* Speech and Language Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "65.6", 12.8f, "82,210", "Financial examiners    * Bank Compliance Officer* Bank Examiner* Financial Compliance Examiner* Home Mortgage Disclosure Act Specialist* Payroll Examiner* Pension Examiner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "89.5", 17.7f, "103,260", "Veterinarians    * Animal Pathologist* Animal Surgeon* Doctor of Veterinary Medicine* Doctor of Veterinary Medicine (DVM)* Equine Veterinarian* Large Animal Veterinarian* Poultry Pathologist* Public Health Veterinarian* Small Animal Veterinarian* Veterinary Cardiologist* Veterinary Medicine Scientist* Veterinary Radiologist* Wildlife Veterinarian" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "200.8", 40.8f, "99,620", "Software quality assurance analysts and testers    * Applications Tester* Software Quality Assurance Technician* Software Quality Control Specialist* Software Quality Engineer* Software Test Engineer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,361.2", 277.6f, "34,110", "Cooks, restaurant    * Banquet Cook* Breakfast Cook* Chef De Partie* Line Cook* Saucier* Specialty Cook" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "87.0", 17.9f, "34,670", "Personal care and service workers, all other    * Butler* Doula* House Sitter* Magnetic Healer* Shoe Shiner* Valet" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "114.8", 23.5f, "34,740", "Veterinary assistants and laboratory animal caretakers    * Laboratory Animal Caretaker* Veterinarian Assistant* Veterinarian Helper* Veterinary Attendant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "122.9", 25.2f, "38,240", "Veterinary technologists and technicians    * Certified Veterinary Technician* LVT* Licensed Veterinary Technician* Registered Veterinary Technician* Veterinary Lab Tech* Veterinary Laboratory Technician* Veterinary Surgery Technician* Veterinary Surgery Technologist* Veterinary Technologist* Veterinary X-Ray Operator" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "177.3", 36.4f, "30,670", "Taxi drivers    * Cab Driver* Rideshare Cab Driver" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { "3,715.5", 804.6f, "30,180" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "29.4", 6.6f, "45,230", "Solar photovoltaic installers    * PV Installer* PV Panel Installer* Photovoltaic (PV) Installation Technician* Solar PV Installer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "109.9", 24.7f, "85,720", "Operations research analysts    * Operations Analyst* Procedure Analyst* Process Analyst" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "36.5", 8.3f, "136,620", "Computer and information research scientists    * Computational Theory Scientist* Computer Scientist* Control System Computer Scientist* Programming Methodology and Languages Researcher" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "30.0", 7f, "113,990", "Actuaries    * Actuarial Associate* Actuarial Mathematician* Health Actuary* Insurance Actuary* Pricing Actuary* Product Development Actuary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "45.1", 10.8f, "64,250", "Occupational therapy assistants    * COTA* Certified Occupational Therapy Assistant* Licensed Occupational Therapy Assistant* Occupational Therapist Assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "1,594.5", 410.4f, "127,260", "Software developers    * Application Integration Engineer* Applications Developer* Computer Applications Developer* Computer Applications Engineer* Computer Systems Engineer* Computer Systems Software Architect* Computer Systems Software Engineer* Embedded Systems Software Developer* Enterprise Systems Engineer* Mobile Applications Developer* Software Applications Architect* Software Applications Designer* Software Applications Engineer* Software Engineer* Software Systems Engineer* Systems Software Designer* Systems Software Developer* Systems Software Specialist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "100.7", 26.3f, "62,770", "Physical therapist assistants    * LPTA* Licensed Physical Therapist Assistant* Physical Therapy Assistant* Physical Therapy Technician* Physiotherapy Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "148.0", 39.3f, "126,010", "Physician assistants    * Anesthesiologist Assistant* Certified Physician's Assistant* Family Practice Physician Assistant* Orthopaedic Physician Assistant* Orthopedic Physician Assistant* Pediatric Physician Assistant* Radiology Practitioner Assistant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "10.0", 2.7f, "78,520", "Epidemiologists    * Clinical Epidemiologist* Communicable Disease Specialist* Environmental Epidemiologist* Epidemiology Investigator* Malariologist* Medical Epidemiologist* Pharmacoepidemiologist" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "509.5", 144.7f, "104,830", "Medical and health services managers    * Chief Medical Information Officer* Clinic Director* Clinical Informatics Director* Clinical Services Director* Emergency Medical Service Coordinator* Health Care Manager* Health Information Services Manager* Health Services Administrator* Health Services Director* Healthcare Administrator* Healthcare Manager* Hospice Director* Hospice Plan Administrator* Hospital Administrator* Hospital Director* Medical Director* Medical Records Administrator* Medical and Health Information Manager* Mental Health Program Manager* Nursing Home Manager* Nursing Service Director* Occupational Therapy Director* Public Health Administrator* Respiratory Therapy Director* Speech and Hearing Therapy Director* Wellness Director* Wellness Manager" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "168.9", 53.2f, "112,000", "Information security analysts    * Computer Security Specialist* Computer Systems Security Analyst* IT Risk Specialist* Information Security Analyst* Information Systems Security Analyst* Network Security Analyst" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "33.3", 10.5f, "98,920", "Statisticians    * Analytical Statistician* Applied Statistician* Biometrician* Biostatistician* Environmental Statistician* Mathematical Statistician* Research Biostatistician* Sampling Expert* Statistical Analyst* Statistical Reporting Analyst* Survey Statistician* Time Study Statistician" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "168.9", 59.4f, "103,500", "Data scientists    * Business Intelligence Developer* Data Analytics Specialist* Data Mining Analyst* Data Visualization Developer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "266.3", 118.6f, "121,610", "Nurse practitioners    * Acute Care Nurse Practitioner* Adult Nurse Practitioner* Cardiology Nurse Practitioner* Certified Nurse Practitioner* Certified Pediatric Nurse Practitioner* Certified Registered Nurse Practitioner* Dermatology Nurse Practitioner* Electrophysiology Nurse Practitioner* Emergency Medicine Nurse Practitioner* Family Health Nurse Practitioner* Family Practice Nurse Practitioner* Gastroenterology Nurse Practitioner* Gerontological Nurse Practitioner* Internal Medicine Nurse Practitioner* NP* Neurosurgical Nurse Practitioner* Obstetrics-Gynecology Nurse Practitioner* Orthopedic Nurse Practitioner* Palliative Care Nurse Practitioner* Pediatric Nurse Practitioner* Surgical Nurse Practitioner" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { "11.2", 5f, "57,320", "Wind turbine service technicians    * Wind Energy Mechanic* Wind Energy Technician* Wind Turbine Mechanic* Wind Turbine Technician" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "median_annual_wage",
                table: "Occupations",
                type: "decimal(12,3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "decade_change_percentage",
                table: "Occupations",
                type: "decimal(12,3)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "currently_employed",
                table: "Occupations",
                type: "decimal(12,3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 44.0m, -17m, 44330m, "Word processors and typists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.1m, -0.6m, 48370m, "Watch and clock repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1.8m, -0.5m, 60210m, "Roof bolters, mining" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.3m, -2.3m, 36130m, "Cutters and trimmers, hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.1m, -1.1m, 38330m, "Telephone operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 165.6m, -43.1m, 36190m, "Data entry keyers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 48.4m, -12.1m, 34670m, "Switchboard operators, including answering service" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.5m, -2.7m, 40120m, "Foundry mold and coremakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 161.4m, -35.3m, 48780m, "Legal secretaries and administrative assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 29.8m, -6.5m, 29690m, "Pressers, textile, garment, and related materials" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.3m, -0.5m, 54970m, "Patternmakers, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 0.6m, -0.1m, 50550m, "Refractory materials repairers, except brickmasons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 511.1m, -108.1m, 65980m, "Executive secretaries and executive administrative assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.1m, -0.9m, 36820m, "Manufactured building and mobile home installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 97.7m, -20.1m, 31030m, "Telemarketers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.5m, -2.8m, 36960m, "Grinding and polishing workers, hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 50.9m, -9.6m, 50850m, "Engine and other machine assemblers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.4m, -0.6m, 57620m, "Model makers, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 0.4m, -0.1m, 42290m, "Timing device assemblers and adjusters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.6m, -1.2m, 42450m, "Drilling and boring machine tool setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 132.8m, -24.2m, 38060m, "Order clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 54.5m, -9.8m, 33160m, "Floral designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.7m, -1.7m, 41600m, "Electronic equipment installers and repairers, motor vehicles" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 5.4m, -1m, 63920m, "Loading and moving machine operators, underground mining" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 25.7m, -4.4m, 43560m, "Prepress technicians and workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.1m, -1.8m, 43160m, "Coil winders, tapers, and finishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 165.4m, -27.2m, 49630m, "Payroll and timekeeping clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 59.6m, -9.8m, 47200m, "Structural metal fabricators and fitters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 41.4m, -6.8m, 36970m, "Print binding and finishing workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 91.1m, -14.6m, 37290m, "File clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 36.4m, -5.8m, 31100m, "Door-to-door sales workers, news and street vendors, and related workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.9m, -1.1m, 31530m, "Sewers, hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 141.9m, -21.6m, 31740m, "Sewing machine operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 33.9m, -5.1m, 58430m, "Aircraft structure, surfaces, rigging, and systems assemblers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.9m, -1.6m, 46540m, "Forging machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 364.1m, -52.9m, 36380m, "Tellers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 46.6m, -6.7m, 40820m, "New accounts clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 31.6m, -4.5m, 36710m, "Office machine operators, except computer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 15.7m, -2.2m, 46870m, "Milling and planing machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 742.0m, -101.6m, 27640m, "Cooks, fast food" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 33.9m, -4.6m, 34280m, "Tailors, dressmakers, and custom sewers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.5m, -1.1m, 47910m, "Desktop publishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 42.2m, -5.3m, 58590m, "Adult basic education, adult secondary education, and english as a second language instructors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 32.2m, -4m, 93060m, "Power plant operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.4m, -0.8m, 36280m, "Photographic process workers and processing machine operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.3m, -0.3m, 64180m, "Underground mining machine operators, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 21.1m, -2.6m, 44760m, "Meter readers, utilities" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1.6m, -0.2m, 52330m, "Terrazzo workers and finishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.8m, -1.7m, 79460m, "Gas plant operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2030.2m, -235.9m, 41000m, "Secretaries and administrative assistants, except legal, medical, and executive" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 28.0m, -3.2m, 41750m, "Broadcast announcers and radio disc jockeys" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 115.0m, -13m, 49130m, "Postal service mail sorters, processors, and processing machine operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 147.4m, -16.6m, 97800m, "Computer programmers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 25.1m, -2.8m, 45240m, "Carpet installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 18.2m, -2m, 47400m, "Locksmiths and safe repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 92.7m, -10.2m, 45710m, "Paper goods machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 28.2m, -3.1m, 46310m, "Rolling machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.8m, -1.1m, 32460m, "Shoe and leather workers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 184.8m, -20.1m, 39340m, "Cutting, punching, and press machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.9m, -2m, 39430m, "Helpers--brickmasons, blockmasons, stonemasons, and tile and marble setters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.3m, -0.4m, 33060m, "Shoe machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 96.4m, -10.4m, 44910m, "Computer, automated teller, and office machine repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.1m, -1.2m, 34420m, "Textile cutting machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.8m, -1.9m, 35750m, "Textile knitting and weaving machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3345.8m, -348.1m, 28240m, "Cashiers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.1m, -0.7m, 58260m, "Layout workers, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 175.4m, -17.7m, 38700m, "Interviewers, except eligibility and loan" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 209.7m, -20.1m, 39470m, "Bill and account collectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.1m, -0.2m, 33360m, "Motion picture projectionists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 75.0m, -7.1m, 38910m, "Grinding, lapping, polishing, and buffing machine tool setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.0m, -0.7m, 32680m, "Textile bleaching and dyeing machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 32.9m, -3.1m, 37900m, "Plating machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.7m, -1.9m, 47020m, "Lathe and turning machine tool setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.0m, -0.7m, 38150m, "Musical instrument repairers and tuners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.5m, -0.6m, 49160m, "Fallers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 193.0m, -17.9m, 34670m, "Helpers--production workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.0m, -1.5m, 40900m, "Heat treating equipment setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.2m, -0.6m, 45070m, "Pourers and casters, metal" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 43.7m, -3.9m, 54680m, "Brokerage clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.3m, -1m, 32270m, "Forest and conservation workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 25.0m, -2.2m, 33720m, "Textile winding, twisting, and drawing out machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 155.5m, -13.2m, 39350m, "Printing press operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 62.7m, -5.3m, 59800m, "Tool and die makers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 5.5m, -0.5m, 41940m, "Tool grinders, filers, and sharpeners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 862.9m, -72.2m, 37760m, "Shipping, receiving, and inventory clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 32.9m, -2.8m, 44920m, "Welding, soldering, and brazing machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 215.1m, -17.8m, 38660m, "Office and administrative support workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 280.0m, -23m, 189520m, "Chief executives" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.7m, -1.6m, 50280m, "Metal-refining furnace operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 181.8m, -14.6m, 46760m, "" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 21.4m, -1.7m, 38340m, "Metal workers and plastic workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 18.7m, -1.5m, 57640m, "Drafters, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.3m, -1.1m, 32640m, "Textile, apparel, and furnishings workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 494.4m, -38m, 67620m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 65.3m, -4.9m, 45240m, "Procurement clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 1500.4m, -111.8m, 37280m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 378.5m, -28.6m, 49610m, "Correctional officers and jailers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.4m, -0.2m, 60320m, "Fabric and apparel patternmakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 111.4m, -8m, 58450m, "Advertising sales agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 49.6m, -3.6m, 61310m, "Mechanical drafters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.9m, -0.3m, 47110m, "Logging workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1405.8m, -94m, 45250m, "First-line supervisors of retail sales workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 314.5m, -21m, 54250m, "Postal service mail carriers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 74.8m, -5m, 56200m, "Postal service clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.0m, -0.9m, 82760m, "Postmasters and mail superintendents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2668.2m, -175.4m, 38040m, "Office clerks, general" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 26.9m, -1.8m, 44960m, "Audiovisual equipment installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 124.8m, -7.9m, 51600m, "Water and wastewater treatment plant and system operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.9m, -0.4m, 59500m, "Fish and game wardens" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1735.8m, -108.3m, 45860m, "Bookkeeping, accounting, and auditing clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 137.4m, -8.4m, 30360m, "Cooks, short order" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 78.6m, -4.8m, 37600m, "Library technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.5m, -0.8m, 50210m, "Stonemasons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.0m, -0.4m, 38700m, "Correspondence clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 82.9m, -4.8m, 31150m, "Library assistants, clerical" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.4m, -1m, 44830m, "Credit authorizers, checkers, and clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.4m, -1.1m, 30010m, "Gambling change persons and booth cashiers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2982.9m, -162.7m, 37780m, "Customer service representatives" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 120.2m, -6.6m, 49330m, "Chemical equipment operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 34.0m, -1.9m, 38570m, "Cooks, private household" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 12.2m, -0.7m, 31720m, "Gambling cage workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 199.4m, -10.5m, 34150m, "Farmworkers, farm, ranch, and aquacultural animals" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 25.1m, -1.3m, 37490m, "Helpers--carpenters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1567.2m, -80.7m, 61370m, "First-line supervisors of office and administrative support workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 30.1m, -1.5m, 32550m, "Graders and sorters, agricultural products" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 0.5m, 0m, 44290m, "Patternmakers, wood" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.6m, -0.5m, 101650m, "Power distributors and dispatchers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 107.6m, -5.2m, 45930m, "Human resources assistants, except payroll and timekeeping" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 931.8m, -44.8m, 29790m, "Food preparation workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 72.8m, -3.4m, 35070m, "Mail clerks and mail machine operators, except postal service" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 922.9m, -42.3m, 75760m, "Farmers, ranchers, and other agricultural managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 35.4m, -1.6m, 46050m, "Dental laboratory technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 38.0m, -1.7m, 45990m, "Pipelayers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 73.0m, -3.2m, 78850m, "Credit analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 36.6m, -1.6m, 46000m, "Home appliance repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 18.9m, -0.8m, 51650m, "Tire builders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 55.8m, -2.3m, 39880m, "Cutting and slicing machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 206.2m, -8.3m, 48300m, "Cement masons and concrete finishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 122.1m, -4.9m, 73080m, "Editors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.7m, -0.5m, 66920m, "Boilermakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.4m, -0.3m, 28940m, "Gambling and sports book writers and runners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 595.4m, -23m, 43900m, "Inspectors, testers, sorters, samplers, and weighers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 62.2m, -2.4m, 48810m, "First-line supervisors of security workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.2m, -0.3m, 45410m, "Proofreaders and copy markers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 49.0m, -1.8m, 34730m, "Medical transcriptionists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 36.4m, -1.4m, 48350m, "Excavating and loading machine and dragline operators, surface mining" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 35.3m, -1.3m, 46400m, "Logging equipment operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.8m, -0.3m, 60410m, "Survey researchers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 167.9m, -6.2m, 37050m, "Molding, coremaking, and casting machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 62.4m, -2.2m, 29880m, "School bus monitors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.5m, -0.5m, 35370m, "Woodworkers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1.1m, 0m, 46940m, "Model makers, wood" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 72.5m, -2.5m, 37070m, "Helpers--electricians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 28.8m, -1m, 43290m, "Crushing, grinding, and polishing machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.5m, -0.4m, 61650m, "Lighting technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 58.5m, -1.9m, 55960m, "News analysts, reporters, and journalists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 5.5m, -0.2m, 115870m, "Nuclear power reactor operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 259.0m, -8.2m, 46080m, "Insurance claims and policy processing clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.3m, -0.6m, 82670m, "Chemical plant and system operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.9m, -0.4m, 57360m, "Continuous mining machine operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2194.1m, -68.6m, 29120m, "Waiters and waitresses" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 329.0m, -10.3m, 72230m, "Claims adjusters, examiners, and investigators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 74.8m, -2.2m, 49690m, "Education and childcare administrators, preschool and daycare" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 47.2m, -1.4m, 47140m, "Jewelers and precious stone and metal workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 231.4m, -6.5m, 71200m, "Cost estimators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 55.6m, -1.6m, 39950m, "Weighers, measurers, checkers, and samplers, recordkeeping" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 43.7m, -1.2m, 33270m, "Pharmacy aides" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 58.5m, -1.6m, 63310m, "First-line supervisors of correctional officers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 26.1m, -0.7m, 93720m, "Electrical and electronics repairers, powerhouse, substation, and relay" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 15.2m, -0.4m, 60570m, "Electro-mechanical and mechatronics technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 257.7m, -6.6m, 28910m, "Hotel, motel, and resort desk clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.6m, -0.4m, 69380m, "Insurance appraisers, auto damage" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 31.5m, -0.8m, 39600m, "Upholsterers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 125.5m, -3m, 76230m, "Insurance underwriters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 447.1m, -10.2m, 29080m, "Dishwashers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 32.2m, -0.7m, 85090m, "Petroleum pump system operators, refinery operators, and gaugers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.1m, -0.4m, 49100m, "Bailiffs" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.3m, -0.4m, 39860m, "Extruding and forming machine setters, operators, and tenders, synthetic and glass fibers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 18.1m, -0.4m, 62360m, "Tapers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 523.5m, -11.3m, 33000m, "Farmworkers and laborers, crop, nursery, and greenhouse" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 364.4m, -8m, 82850m, "First-line supervisors of non-retail sales workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.2m, -0.4m, 63280m, "Wellhead pumpers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.4m, -0.3m, 38780m, "Adhesive bonding machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3765.6m, -79.1m, 30600m, "Retail salespersons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.9m, -0.1m, 59990m, "Gas compressor and gas pumping station operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 945.9m, -18.5m, 28520m, "Childcare workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.7m, -0.2m, 53450m, "Farm and home management educators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 105.7m, -2m, 38810m, "Cabinetmakers and bench carpenters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 64.3m, -1.2m, 39970m, "Extruding and drawing machine setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.6m, -0.1m, 51600m, "Extraction workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.8m, 0m, 58950m, "Hoist and winch operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 39.2m, -0.7m, 39690m, "Coin, vending, and amusement machine servicers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.4m, -0.1m, 48880m, "Statistical assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 5.6m, -0.1m, 42370m, "Log graders and scalers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 142.4m, -2.2m, 64480m, "Construction and building inspectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.0m, -0.1m, 41570m, "Parking enforcement workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1155.9m, -14.9m, 34750m, "Security guards" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 184.4m, -2.3m, 29060m, "Laundry and dry-cleaning workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 60.0m, -0.8m, 39480m, "Extruding, forming, pressing, and compacting machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 5.9m, -0.1m, 100420m, "Nuclear technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 131.6m, -1.6m, 36930m, "Butchers and meat cutters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.6m, -0.2m, 60670m, "Sound engineering technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 214.8m, -2.3m, 44830m, "Dispatchers, except police, fire, and ambulance" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 39.9m, -0.4m, 60700m, "Broadcast technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 659.6m, -6.6m, 32920m, "Packers and packagers, hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 247.1m, -2.5m, 46490m, "Loan interviewers and clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 81.1m, -0.8m, 35240m, "Slaughterers and meat packers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 64.6m, -0.6m, 36830m, "Woodworking machine setters, operators, and tenders, except sawing" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 64.6m, -0.5m, 82010m, "Labor relations specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.8m, 0m, 47280m, "Bridge and lock tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 53.6m, -0.4m, 64030m, "Electrical and electronics repairers, commercial and industrial equipment" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 35.2m, -0.3m, 39840m, "Fence erectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.2m, -0.1m, 37960m, "Furniture finishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 47.9m, -0.3m, 64810m, "Control and valve installers and repairers, except mechanical door" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 113.0m, -0.6m, 59840m, "Career/technical education teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 27.3m, -0.1m, 0m, "Fishing and hunting workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 22.6m, -0.1m, 38110m, "Fiberglass laminators and fabricators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 171.0m, -0.4m, 49380m, "Directors, religious activities and education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 88.0m, -0.2m, 62500m, "Career/technical education teachers, secondary school" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 82.8m, -0.1m, 62990m, "Special education teachers, middle school" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.5m, 0m, 37980m, "Etchers and engravers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 15.9m, 0m, 57470m, "Plant and system operators, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 126.2m, -0.2m, 55350m, "Sheet metal workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 194.7m, -0.1m, 62390m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.1m, 0m, 62630m, "Career/technical education teachers, middle school" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 12.1m, 0m, 61690m, "Precision instrument and equipment repairers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 51.3m, 0m, 47710m, "Transportation security screeners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 456.3m, 0.1m, 42810m, "Billing and posting clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.2m, 0m, 46060m, "Floor sanders and finishers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.5m, 0m, 38270m, "Painting, coating, and decorating workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.2m, 0m, 55260m, "Rotary drill operators, oil and gas" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 49.4m, 0.1m, 36270m, "Sawing machine setters, operators, and tenders, wood" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 39.5m, 0.1m, 50140m, "Service unit operators, oil and gas" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 1298.9m, 0.9m, 30920m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1238.8m, 1.6m, 29960m, "Maids and housekeeping cleaners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.1m, 0m, 30380m, "Ambulance drivers and attendants, except emergency medical technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 48.4m, 0.1m, 61340m, "Crane and tower operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 51.4m, 0.1m, 62340m, "Legal support workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 100.7m, 0.2m, 30850m, "Automotive and watercraft service attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1.0m, 0m, 47090m, "Dredge operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.5m, 0m, 97490m, "Mining and geological engineers, including mining safety engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 681.7m, 1.9m, 63510m, "First-line supervisors of production and operating workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.1m, 0m, 58360m, "Hydrologic technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.2m, 0.1m, 44530m, "Furnace, kiln, oven, drier, and kettle operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 18.1m, 0.1m, 85300m, "Nuclear medicine technologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1068.8m, 3.9m, 33960m, "Receptionists and information clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.2m, 0m, 43130m, "Models" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.9m, 0.1m, 51220m, "Derrick operators, oil and gas" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 73.0m, 0.3m, 59000m, "Brickmasons and blockmasons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 123.4m, 0.7m, 60490m, "Kindergarten teachers, except special education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 153.2m, 0.7m, 63560m, "Special education teachers, secondary school" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 357.5m, 1.6m, 61310m, "Food service managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 412.8m, 2m, 27720m, "Hosts and hostesses, restaurant, lounge, and coffee shop" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.8m, 0.1m, 35970m, "Gambling surveillance officers and gambling investigators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 31.5m, 0.2m, 41520m, "Forest and conservation technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 41.1m, 0.3m, 61990m, "Mechanical engineering technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 55.0m, 0.3m, 57950m, "Tax examiners and collectors, and revenue agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 75.8m, 0.4m, 39370m, "Religious workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 107.1m, 0.6m, 59820m, "Architectural and civil drafters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 139.9m, 0.8m, 39210m, "Multiple machine tool setters, operators, and tenders, metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 172.4m, 1m, 43960m, "Coating, painting, and spraying machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 266.7m, 1.5m, 55550m, "Clergy" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.0m, 0.1m, 96910m, "Marine engineers and naval architects" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 23.6m, 0.2m, 73210m, "Landscape architects" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1344.3m, 9.1m, 63230m, "Sales representatives, wholesale and manufacturing, except technical and scientific products" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1425.0m, 10m, 61690m, "Elementary school teachers, except special education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.1m, 0.1m, 30350m, "Gambling service workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.2m, 0.1m, 43110m, "Helpers--extraction workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 29.7m, 0.2m, 74570m, "Locomotive engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 26.5m, 0.2m, 239200m, "Surgeons, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 48.7m, 0.4m, 46690m, "Hazardous materials removal workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 102.5m, 0.8m, 66390m, "Electrical and electronic engineering technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 625.5m, 5.1m, 61810m, "Middle school teachers, except special and career/technical education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.0m, 0m, 49910m, "Embalmers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 21.8m, 0.2m, 64240m, "Electrical and electronics drafters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 35.9m, 0.3m, 190350m, "Pediatricians, general" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 64.8m, 0.6m, 59630m, "Civil engineering technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 291.6m, 2.5m, 54360m, "Bus and truck mechanics and diesel engine specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 956.3m, 8.6m, 51390m, "Carpenters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 0.8m, 0m, 239200m, "Pediatric surgeons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.6m, 0.1m, 148720m, "Podiatrists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 75.6m, 0.8m, 29120m, "Gambling dealers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 266.1m, 2.6m, 35800m, "Parts salespersons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1072.3m, 11.1m, 62360m, "Secondary school teachers, except special and career/technical education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.4m, 0m, 44060m, "Camera and photographic equipment repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1.5m, 0m, 88900m, "Geographers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.2m, 0.1m, 94990m, "Administrative law judges, adjudicators, and hearing officers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.9m, 0.1m, 56670m, "Explosives workers, ordnance handling experts, and blasters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.8m, 0.1m, 122480m, "Nuclear engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 21.3m, 0.2m, 36810m, "Ophthalmic laboratory technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 34.2m, 0.4m, 68180m, "Railroad conductors and yardmasters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 43.7m, 0.5m, 47130m, "Financial clerks, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 51.8m, 0.6m, 62940m, "Music directors and composers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 103.8m, 1.2m, 34240m, "Tire repairers and changers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 300.4m, 3.3m, 101320m, "Education administrators, kindergarten through secondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 12.2m, 0.1m, 67540m, "Railroad brake, signal, and switch operators and locomotive firers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.6m, 0.1m, 81300m, "Signal and track switch repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 22.8m, 0.3m, 51070m, "Reinforcing iron and rebar workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 41.6m, 0.5m, 40030m, "Outdoor power equipment and other small engine mechanics" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 70.1m, 0.9m, 74280m, "English language and literature teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 153.3m, 1.9m, 47670m, "Automotive body and related repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 173.5m, 2.1m, 0m, "Musicians and singers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.3m, 0.1m, 87300m, "Ship engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.9m, 0.2m, 50980m, "Environmental engineering technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 22.8m, 0.3m, 79400m, "History teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 62.2m, 0.8m, 81500m, "School psychologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 123.0m, 1.6m, 39160m, "Reservation and transportation ticket agents and travel clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2382.9m, 29.9m, 31990m, "Janitors and cleaners, except maids and housekeeping cleaners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.5m, 0.2m, 63230m, "Rail-track laying and maintenance equipment operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 23.0m, 0.3m, 132250m, "Air traffic controllers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 24.7m, 0.3m, 76030m, "Foreign language and literature teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.7m, 0.3m, 54680m, "Riggers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 275.3m, 3.9m, 35490m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 358.8m, 4.9m, 41270m, "Bus drivers, school" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 431.8m, 6.2m, 47540m, "Welders, cutters, solderers, and brazers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.7m, 0.1m, 36080m, "Helpers--painters, paperhangers, plasterers, and stucco masons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.6m, 0.1m, 85990m, "Hydrologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 25.1m, 0.4m, 99000m, "Elevator and escalator installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 108.4m, 1.6m, 30570m, "Parking attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 109.5m, 1.6m, 48250m, "Tax preparers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 114.4m, 1.7m, 86280m, "Detectives and criminal investigators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 114.0m, 1.7m, 43410m, "Mixing and blending machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 195.4m, 2.9m, 44500m, "Installation, maintenance, and repair workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 372.4m, 5.5m, 46090m, "Painters, construction and maintenance" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3410.1m, 50.4m, 27930m, "Fast food and counter workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.3m, 0.2m, 53930m, "Tank car, truck, and ship loaders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.4m, 0.3m, 239200m, "Orthopedic surgeons, except pediatric" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 27.3m, 0.4m, 36700m, "Food cooking machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 28.3m, 0.4m, 37820m, "Helpers, construction trades, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 106.6m, 1.7m, 27650m, "Ushers, lobby attendants, and ticket takers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 116.4m, 1.9m, 50440m, "Drywall and ceiling tile installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 217.1m, 3.5m, 35280m, "Couriers and messengers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 222.1m, 3.6m, 107560m, "Industrial production managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 782.2m, 12.8m, 46970m, "Automotive service technicians and mechanics" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 21.9m, 0.4m, 43700m, "Automotive glass installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 27.2m, 0.5m, 50590m, "Insulation workers, mechanical" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 34.4m, 0.6m, 45380m, "Insulation workers, floor, ceiling, and wall" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 36.5m, 0.6m, 88900m, "Social scientists and related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 39.6m, 0.7m, 95210m, "Captains, mates, and pilots of water vessels" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 62.2m, 1m, 50490m, "Title examiners, abstractors, and searchers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.2m, 0.2m, 35720m, "Agricultural workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.1m, 0.3m, 43370m, "Motorcycle mechanics" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 71.6m, 1.3m, 60500m, "Structural iron and steel workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.1m, 0.1m, 46010m, "Rock splitters, quarry" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 23.8m, 0.5m, 62240m, "Special education teachers, preschool" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 30.9m, 0.6m, 127830m, "Advertising and promotions managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 84.8m, 1.6m, 39990m, "Rehabilitation counselors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 148.0m, 2.9m, 61250m, "Teachers and instructors, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 327.0m, 6.3m, 48510m, "Machinists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 5.9m, 0.1m, 37020m, "Helpers--roofers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.1m, 0.3m, 44720m, "Agricultural inspectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 23.2m, 0.5m, 41440m, "Pesticide handlers, sprayers, and applicators, vegetation" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 32.3m, 0.6m, 44890m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 30.7m, 0.6m, 47490m, "Sailors and marine oilers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 32.4m, 0.7m, 75910m, "Commercial and industrial designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 35.2m, 0.7m, 106230m, "Healthcare diagnosing or treating practitioners, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 141.0m, 2.8m, 35070m, "Meat, poultry, and fish cutters and trimmers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 154.5m, 3.1m, 47920m, "Roofers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.5m, 0.1m, 45320m, "Animal breeders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 25.4m, 0.5m, 107970m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 27.3m, 0.6m, 49730m, "Plasterers and stucco masons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 434.5m, 8.9m, 32510m, "Cooks, institution and cafeteria" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.3m, 0.1m, 112110m, "Mathematicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.4m, 0.1m, 42280m, "Rail transportation workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.5m, 0.4m, 131280m, "Compensation and benefits managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 20.4m, 0.4m, 51740m, "Earth drillers, except oil and gas" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.3m, 0.4m, 39520m, "Grounds maintenance workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 22.9m, 0.5m, 239200m, "Obstetricians and gynecologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 29.6m, 0.7m, 151030m, "Judges, magistrate judges, and magistrates" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 36.4m, 0.8m, 72110m, "Funeral home managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 54.5m, 1.2m, 48720m, "Glaziers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 157.5m, 3.5m, 49230m, "Eligibility interviewers, government programs" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.3m, 0.4m, 57490m, "Judicial law clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 47.8m, 1.1m, 36340m, "Helpers--pipelayers, plumbers, pipefitters, and steamfitters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 145.3m, 3.3m, 47650m, "Educational instruction and library workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 482.7m, 10.9m, 60090m, "Plumbers, pipefitters, and steamfitters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.6m, 0.1m, 56340m, "Rail yard engineers, dinkey operators, and hostlers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.3m, 0.3m, 64220m, "Foresters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 15.9m, 0.4m, 89530m, "Radiation therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 44.7m, 1.1m, 39590m, "Molders, shapers, and casters, except metal and plastic" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 173.4m, 4.1m, 35380m, "Merchandise displayers and window trimmers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 576.2m, 14m, 73140m, "First-line supervisors of mechanics, installers, and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.1m, 0.4m, 37200m, "Building cleaning workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.1m, 0.4m, 48260m, "Electric motor, power tool, and related repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.6m, 0.4m, 42160m, "Medical appliance technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 21.4m, 0.5m, 131800m, "Petroleum engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 66.0m, 1.7m, 47080m, "Tree trimmers and pruners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 72.6m, 1.8m, 214460m, "General internal medicine physicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 96.5m, 2.4m, 35100m, "Helpers--installation, maintenance, and repair workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 93.9m, 2.4m, 59860m, "Probation officers and correctional treatment specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 216.6m, 5.3m, 66490m, "Instructional coordinators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 339.9m, 8.3m, 90520m, "Network and computer systems administrators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 809.9m, 20.4m, 74080m, "First-line supervisors of construction trades and extraction workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 5.3m, 0.1m, 80710m, "Gambling managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.2m, 0.5m, 75390m, "Social sciences teachers, postsecondary, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 40.0m, 1m, 239200m, "Anesthesiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 230.9m, 6.1m, 50810m, "First-line supervisors of landscaping, lawn service, and groundskeeping workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 334.2m, 8.7m, 132750m, "Pharmacists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 5.8m, 0.2m, 212740m, "Dentists, all other specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.5m, 0.4m, 64990m, "Criminal justice and law enforcement teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 25.7m, 0.7m, 79570m, "Transportation inspectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 29.1m, 0.8m, 78780m, "Philosophy and religion teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 56.6m, 1.5m, 54490m, "First-line supervisors of farming, fishing, and forestry workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 73.3m, 2m, 39610m, "Opticians, dispensing" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 161.1m, 4.3m, 44720m, "Information and record clerks, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 380.8m, 10.4m, 35830m, "Counter and rental clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 437.6m, 11.6m, 51430m, "Operating engineers and other construction equipment operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 21.3m, 0.6m, 63560m, "Court reporters and simultaneous captioners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 31.3m, 0.9m, 239200m, "Emergency medicine physicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 33.2m, 0.9m, 31160m, "Funeral attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 36.5m, 1m, 58230m, "Camera operators, television, video, and film" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 33.5m, 1m, 67120m, "Stationary engineers and boiler operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 57.6m, 1.6m, 89130m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 83.0m, 2.3m, 50130m, "Security and fire alarm systems installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 122.4m, 3.5m, 82340m, "Electrical power-line installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.6m, 0.1m, 41430m, "Motorboat operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 42.1m, 1.2m, 43590m, "Roustabouts, oil and gas" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 43.9m, 1.3m, 63950m, "Special education teachers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 354.8m, 10.4m, 65740m, "Loan officers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.8m, 0.6m, 108860m, "Law teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.1m, 0.6m, 67430m, "Zoologists and wildlife biologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 21.5m, 0.7m, 37790m, "Food and tobacco roasting, baking, and drying machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 42.1m, 1.3m, 60930m, "Millwrights" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 44.5m, 1.3m, 31410m, "Physical therapist aides" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 95.0m, 2.9m, 36460m, "Protective service workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 141.2m, 4.3m, 61660m, "Librarians and media collections specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 170.6m, 5.1m, 44140m, "Court, municipal, and license clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 254.9m, 7.7m, 44440m, "First-line supervisors of housekeeping and janitorial workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 330.9m, 10m, 223410m, "Physicians, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.5m, 0.1m, 64540m, "Historians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.4m, 0.3m, 48490m, "Geological technicians, except hydrologic technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 12.4m, 0.4m, 239200m, "Dermatologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 18.0m, 0.6m, 239200m, "Cardiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 33.5m, 1.1m, 65390m, "Designers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 74.1m, 2.3m, 65520m, "Engineering technologists and technicians, except drafters, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 95.0m, 3m, 38310m, "Pest control workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 137.9m, 4.3m, 96290m, "First-line supervisors of police and detectives" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 258.6m, 8.1m, 30300m, "Food servers, nonrestaurant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.3m, 0.1m, 64310m, "Pile driver operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.4m, 0.1m, 69150m, "Transit and railroad police" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 12.2m, 0.4m, 224260m, "Neurologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 20.2m, 0.6m, 33390m, "Cooks, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 29.7m, 1m, 56290m, "First-line supervisors of gambling services workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 55.9m, 1.8m, 77420m, "Mathematical science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 58.8m, 1.9m, 50840m, "Chemical technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 69.1m, 2.2m, 61210m, "Industrial engineering technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 78.1m, 2.5m, 0m, "Actors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 123.9m, 3.9m, 77280m, "Art, drama, and music teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 146.4m, 4.7m, 43540m, "Refuse and recyclable material collectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 354.7m, 11.4m, 44110m, "Self-enrichment teachers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 462.6m, 14.9m, 49980m, "Real estate sales agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.8m, 0.4m, 79180m, "Emergency management directors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.3m, 0.5m, 72650m, "Recreation and fitness studies teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 24.9m, 0.8m, 76700m, "Fashion designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 51.6m, 1.7m, 82260m, "Budget analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 64.2m, 2.1m, 47180m, "Surveying and mapping technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 170.3m, 5.7m, 104600m, "Engineers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 223.7m, 7.4m, 36680m, "Tutors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 270.9m, 8.9m, 57990m, "Graphic designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 641.3m, 21.3m, 29380m, "Bartenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 684.0m, 22.5m, 65790m, "Police and sheriff's patrol officers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1228.3m, 41m, 128620m, "Managers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.5m, 0.1m, 128970m, "Medical dosimetrists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.0m, 0.5m, 69760m, "Artists and related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.5m, 0.5m, 59720m, "Radio, cellular, and tower equipment installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.3m, 0.6m, 69490m, "Media and communication equipment workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 24.5m, 0.8m, 61030m, "First-line supervisors of protective service workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 33.6m, 1.2m, 76250m, "Communications teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 44.4m, 1.5m, 48090m, "Legislators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 55.6m, 1.9m, 46250m, "Separating, filtering, clarifying, precipitating, and still machine setters, operators, and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 99.5m, 3.4m, 46900m, "Public safety telecommunicators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 512.3m, 17.2m, 35330m, "Preschool teachers, except special education" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.5m, 0.3m, 88260m, "Subway and streetcar operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.6m, 0.3m, 50050m, "Traffic technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 20.2m, 0.7m, 33960m, "Dietetic technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 25.9m, 0.9m, 80720m, "Chemistry teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 26.1m, 0.9m, 38800m, "Material moving workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 66.3m, 2.3m, 46400m, "Travel agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 127.2m, 4.4m, 62190m, "Real estate brokers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 180.2m, 6.3m, 126900m, "Computer network architects" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 218.2m, 7.7m, 99940m, "Education administrators, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1176.1m, 41.7m, 35890m, "Landscaping and groundskeeping workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.2m, 0.4m, 55860m, "Pump operators, except wellhead pumpers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.6m, 0.5m, 97770m, "Atmospheric, earth, marine, and space sciences teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 12.8m, 0.5m, 219810m, "Ophthalmologists, except pediatric" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.8m, 0.6m, 51330m, "Recreational therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 20.1m, 0.7m, 62510m, "Rail car repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 31.2m, 1.1m, 239200m, "Radiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 87.1m, 3.1m, 80150m, "First-line supervisors of firefighting and prevention workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 262.8m, 9.4m, 76920m, "Postsecondary teachers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 334.2m, 12m, 51680m, "Firefighters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1607.2m, 57.2m, 44980m, "Maintenance and repair workers, general" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.9m, 0.1m, 44930m, "Paperhangers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 15.0m, 0.6m, 69450m, "Fire inspectors and investigators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 15.0m, 0.6m, 78970m, "Sociology teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.3m, 0.7m, 83770m, "Political science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 22.0m, 0.8m, 100660m, "Health and safety engineers, except mining safety engineers and inspectors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 24.5m, 0.9m, 51570m, "Morticians, undertakers, and funeral arrangers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 42.3m, 1.6m, 47270m, "Paving, surfacing, and tamping equipment operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 44.7m, 1.7m, 79540m, "Urban and regional planners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 58.9m, 2.2m, 63020m, "Cardiovascular technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 74.3m, 2.8m, 66930m, "Education teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 108.0m, 4m, 211300m, "Family medicine physicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 151.2m, 5.6m, 73150m, "Writers and authors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 305.6m, 11.4m, 97710m, "Sales representatives, wholesale and manufacturing, technical and scientific products" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 401.8m, 15m, 31000m, "Cleaners of vehicles and equipment" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 796.6m, 29.9m, 41230m, "Industrial truck and tractor operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.2m, 0.3m, 93220m, "Architecture teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.4m, 0.5m, 36250m, "Bicycle repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.0m, 0.5m, 37190m, "Cleaning, washing, and metal pickling equipment operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.8m, 0.6m, 103930m, "Economics teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.2m, 0.6m, 86550m, "Physics teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 80.0m, 3m, 50290m, "Life, physical, and social science technicians, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.0m, 0.1m, 40360m, "Crematory operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.9m, 0.1m, 76440m, "Family and consumer sciences teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.5m, 0.4m, 38150m, "Craft artists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.9m, 0.5m, 80910m, "Area, ethnic, and cultural studies teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 12.1m, 0.5m, 37430m, "Transportation workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 48.8m, 1.9m, 34710m, "Food processing workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 60.4m, 2.3m, 87300m, "Biological scientists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 91.7m, 3.5m, 211790m, "Airline pilots, copilots, and flight engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 94.9m, 3.7m, 61590m, "Interior designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.2m, 0.2m, 85000m, "Anthropology and archeology teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.9m, 0.5m, 39320m, "Animal control workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 15.5m, 0.6m, 66510m, "Social work teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 45.0m, 1.8m, 34770m, "Demonstrators and product promoters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 50.9m, 2.1m, 103910m, "Commercial pilots" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 554.7m, 22.5m, 130600m, "Sales managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 5.4m, 0.2m, 76370m, "Library science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.5m, 0.6m, 34630m, "Passenger attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 24.7m, 1m, 64460m, "Conservation scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 94.1m, 3.8m, 33380m, "Crossing guards and flaggers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 148.9m, 6.1m, 40170m, "Photographers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 201.5m, 8.2m, 159920m, "Architectural and engineering managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 421.6m, 17.4m, 35250m, "Substitute teachers, short-term" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1113.2m, 45.7m, 62400m, "Sales representatives of services, except advertising, insurance, financial services, and travel" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1174.8m, 48.7m, 75990m, "Business operations specialists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1361.3m, 56.5m, 35760m, "Nursing assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2192.3m, 89.3m, 49920m, "Heavy and tractor-trailer truck drivers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.0m, 0.3m, 63940m, "Anthropologists and archeologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.9m, 0.3m, 83040m, "Environmental science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 23.8m, 1m, 0m, "Disc jockeys, except radio" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 45.5m, 1.9m, 34520m, "Orderlies" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 170.2m, 7.1m, 38050m, "Teaching assistants, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 188.8m, 7.9m, 103320m, "Electrical engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 343.8m, 14.4m, 27780m, "Amusement and recreation attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 354.3m, 14.8m, 59200m, "Paralegals and legal assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 396.8m, 16.5m, 50630m, "Production, planning, and expediting clerks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 459.2m, 19.2m, 29120m, "Dining room and cafeteria attendants and bartender helpers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3507.8m, 147.3m, 98100m, "General and operations managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 20.8m, 0.9m, 75450m, "Avionics technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 23.1m, 1m, 56090m, "Personal service managers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 25.8m, 1.1m, 65000m, "Media and communication workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 68.7m, 3m, 53640m, "Interpreters and translators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 85.4m, 3.7m, 30840m, "Food preparation and serving related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 140.2m, 6.1m, 70010m, "Aircraft mechanics and service technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.1m, 0.2m, 81920m, "Geography teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.5m, 0.5m, 83780m, "Atmospheric and space scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.3m, 0.5m, 62050m, "Calibration technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 77.5m, 3.4m, 131350m, "Purchasing managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 136.7m, 6m, 155040m, "Dentists, general" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1418.6m, 61.9m, 40750m, "Construction laborers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1538.4m, 67.4m, 78000m, "Accountants and auditors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.3m, 0.1m, 98590m, "Sociologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.2m, 0.3m, 174360m, "Orthodontists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.6m, 0.8m, 41760m, "Agricultural technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 136.8m, 6.1m, 44120m, "Sales and related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 282.9m, 12.7m, 38580m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 505.8m, 22.9m, 101480m, "Construction managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.4m, 0.1m, 128330m, "Astronomers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.2m, 0.6m, 239200m, "Physicians, pathologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 50.8m, 2.3m, 63080m, "Surveyors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 78.1m, 3.6m, 132360m, "Computer hardware engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 77.6m, 3.6m, 61560m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 127.0m, 5.8m, 99030m, "Facilities managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 289.4m, 13.4m, 31680m, "Recreation workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 377.5m, 17.2m, 71690m, "Compliance officers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 373.2m, 17.3m, 36750m, "Packaging and filling machine operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.2m, 0.8m, 65730m, "Soil and plant scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.9m, 0.9m, 37050m, "Aircraft service attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 21.1m, 1m, 142850m, "Physicists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 60.9m, 2.9m, 108530m, "Sales engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 74.8m, 3.5m, 50660m, "Audio and video technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 81.4m, 3.9m, 49650m, "Biological technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 601.1m, 28.1m, 57860m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.9m, 0.4m, 73630m, "Electrical and electronics installers and repairers, transportation equipment" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.1m, 0.5m, 85860m, "Agricultural sciences teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 34.4m, 1.6m, 50470m, "Social science research assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 86.3m, 4.2m, 144440m, "Natural sciences managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 123.7m, 6m, 82840m, "Architects, except landscape and naval" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.8m, 0.2m, 37060m, "Occupational therapy aides" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 15.0m, 0.7m, 49600m, "Airfield operations specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 32.4m, 1.6m, 37160m, "Psychiatric aides" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 218.8m, 10.8m, 32780m, "Bakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 342.9m, 16.8m, 57380m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1221.7m, 60m, 37050m, "First-line supervisors of food preparation and serving workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.9m, 0.2m, 239200m, "Oral and maxillofacial surgeons" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.9m, 0.3m, 50990m, "Choreographers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.1m, 0.3m, 48470m, "Costume attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.1m, 0.5m, 64030m, "Arbitrators, mediators, and conciliators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.0m, 0.7m, 71890m, "Cartographers and photogrammetrists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 326.3m, 16.2m, 89940m, "Civil engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 736.2m, 36.8m, 57890m, "Computer user support specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.1m, 0.4m, 42890m, "Cooling and freezing equipment operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 7.9m, 0.4m, 104380m, "Materials scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.7m, 1m, 99550m, "Bioengineers and biomedical engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 22.3m, 1.1m, 100140m, "Materials engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 26.3m, 1.3m, 87480m, "Geoscientists, except hydrologists and geographers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 33.7m, 1.7m, 107390m, "Fundraising managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 56.3m, 2.9m, 106420m, "Psychologists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 169.1m, 8.6m, 59440m, "Mobile heavy equipment mechanics, except engines" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1.5m, 0.1m, 96500m, "Forestry and conservation science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.0m, 0.5m, 83930m, "Life scientists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.7m, 1m, 57290m, "Surgical assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 21.2m, 1.1m, 47860m, "Food science technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 20.9m, 1.1m, 81990m, "Microbiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 29.1m, 1.5m, 57560m, "Fine artists, including painters, sculptors, and illustrators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 44.4m, 2.3m, 60160m, "Healthcare practitioners and technical workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 50.9m, 2.7m, 78810m, "Psychology teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 124.0m, 6.5m, 61190m, "Fundraisers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 191.6m, 10m, 130000m, "Human resources managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.5m, 0.6m, 0m, "Dancers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 26.6m, 1.4m, 72220m, "Acupuncturists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 42.0m, 2.2m, 84760m, "Computer science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 174.4m, 9.2m, 56520m, "Chefs and head cooks" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 355.3m, 18.9m, 50820m, "Child, family, and school social workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 655.0m, 34.9m, 54620m, "Licensed practical and licensed vocational nurses" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2988.5m, 158.8m, 36110m, "Laborers and freight, stock, and material movers, hand" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 5.2m, 0.3m, 27260m, "Entertainment attendants and related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 32.8m, 1.8m, 47320m, "Credit counselors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 66.7m, 3.6m, 41480m, "Medical equipment preparers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 98.3m, 5.3m, 49090m, "Paramedics" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 109.2m, 5.9m, 55960m, "Surgical technologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 156.4m, 8.4m, 50890m, "Bus drivers, transit and intercity" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 170.7m, 9.3m, 36680m, "Emergency medical technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 342.4m, 18.4m, 60140m, "Educational, guidance, and career counselors and advisors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 429.6m, 23.4m, 60670m, "Property, real estate, and community association managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 51.5m, 2.8m, 38040m, "Machine feeders and offbearers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 63.6m, 3.5m, 53310m, "Maintenance workers, machinery" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 222.8m, 12.2m, 65140m, "Radiologic technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 415.8m, 23m, 51390m, "Heating, air conditioning, and refrigeration mechanics and installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 38.7m, 2.2m, 35560m, "Concierges" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 250.8m, 14m, 103330m, "Administrative services managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 459.6m, 25.9m, 37790m, "Pharmacy technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3172.5m, 177.4m, 81220m, "Registered nurses" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 0.4m, 0m, 0m, "Prosthodontists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.8m, 0.2m, 69390m, "Animal scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 29.3m, 1.7m, 48280m, "Motorboat mechanics and service technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 112.7m, 6.4m, 40420m, "Healthcare support workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 30.6m, 1.8m, 36890m, "Conveyor operators and tenders" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 35.0m, 2m, 48380m, "Environmental science and protection technicians, including health" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1.8m, 0.1m, 46180m, "Communications equipment operators, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.1m, 0.6m, 139280m, "Industrial-organizational psychologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 72.0m, 4.3m, 129430m, "Public relations managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 874.5m, 51.4m, 64240m, "Human resources specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.4m, 0.3m, 68300m, "Commercial divers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 95.7m, 5.7m, 35720m, "Residential advisors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 38.3m, 2.3m, 52120m, "Private detectives and investigators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 47.3m, 2.9m, 96530m, "Environmental engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 63.8m, 3.9m, 126880m, "Aerospace engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 80.5m, 4.9m, 76480m, "Environmental scientists and specialists, including health" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 135.1m, 8.2m, 105180m, "Art directors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 136.0m, 8.3m, 73810m, "Financial specialists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 297.1m, 18m, 67440m, "Public relations specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.1m, 0.3m, 71700m, "Mathematical science occupations, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 87.1m, 5.4m, 80670m, "Chemists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 113.5m, 7m, 27270m, "Lifeguards, ski patrol, and other recreational protective service workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 881.3m, 54.7m, 95370m, "Project management specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1.6m, 0.1m, 83260m, "Agricultural engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.6m, 1.1m, 113940m, "Economists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 27.7m, 1.7m, 31510m, "Baggage porters and bellhops" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 173.7m, 11m, 59960m, "Telecommunications equipment installers and repairers, except line installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 385.8m, 24.2m, 63080m, "Training and development specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2851.6m, 178.6m, 34220m, "Stockers and order fillers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.2m, 0.5m, 120880m, "Nurse midwives" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 762.6m, 49.2m, 60240m, "Electricians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 41.3m, 2.7m, 120000m, "Training and development managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 103.0m, 6.7m, 47290m, "Community and social service specialists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 6.2m, 0.4m, 128020m, "Political scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 68.4m, 4.5m, 61420m, "Social workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 78.6m, 5.2m, 66450m, "Dietitians and nutritionists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 168.0m, 11.1m, 44990m, "Health technologists and technicians, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 358.2m, 23.7m, 140040m, "Marketing managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 28.6m, 1.9m, 226880m, "Psychiatrists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 34.5m, 2.3m, 103810m, "Biochemists and biophysicists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 50.8m, 3.4m, 61910m, "Lodging managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 112.1m, 7.5m, 60580m, "Telecommunications line installers and repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 175.3m, 11.7m, 85320m, "Producers and directors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 696.6m, 46.6m, 38500m, "Medical secretaries and administrative assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 53.3m, 3.7m, 79960m, "Technical writers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 59.4m, 4.1m, 48340m, "Tile and stone setters" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 99.9m, 6.9m, 88790m, "Business teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 371.0m, 25.7m, 44820m, "Dental assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 12.9m, 0.9m, 30210m, "Locker room, coatroom, and dressing room attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 63.1m, 4.4m, 34990m, "Barbers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 85.2m, 6m, 99890m, "Database administrators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 98.2m, 6.9m, 67780m, "Compensation, benefits, and job analysis specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 177.9m, 12.5m, 68050m, "Computer network support specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 60.4m, 4.4m, 59990m, "Health education specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 110.9m, 7.9m, 108170m, "Electronics engineers, except computer" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 27.8m, 2m, 59990m, "Set and exhibit designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 30.2m, 2.2m, 48870m, "Floor layers, except carpet, wood, and hard tiles" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1.6m, 0.1m, 49330m, "Farm labor contractors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 29.5m, 2.2m, 45610m, "Septic tank servicers and sewer pipe cleaners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 219.4m, 16.3m, 81400m, "Dental hygienists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 482.2m, 35.6m, 67480m, "Securities, commodities, and financial services sales agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 15.3m, 1.1m, 79860m, "Food scientists and technologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 132.0m, 9.9m, 52560m, "Meeting, convention, and event planners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 826.3m, 62.4m, 135740m, "Lawyers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 317.2m, 24.2m, 95080m, "Financial and investment analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 41.4m, 3.2m, 80090m, "Magnetic resonance imaging technologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 114.6m, 8.8m, 44660m, "First-line supervisors of entertainment and recreation workers, except gambling services" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 139.4m, 10.8m, 38530m, "Phlebotomists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 541.0m, 41.9m, 32690m, "Driver/sales workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 555.8m, 42.8m, 33290m, "Hairdressers, hairstylists, and cosmetologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 171.5m, 13.4m, 36580m, "Food batchmakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 68.3m, 5.4m, 33210m, "Motor vehicle operators, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 151.2m, 12m, 44930m, "Highway maintenance workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 536.8m, 42.5m, 57860m, "Insurance sales agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 24.6m, 2m, 44690m, "Semiconductor processing technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 218.4m, 17.5m, 32800m, "Shuttle drivers and chauffeurs" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 20.8m, 1.7m, 106260m, "Chemical engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 45.6m, 3.7m, 48010m, "Farm equipment mechanics and service technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 53.6m, 4.3m, 34440m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.4m, 0.8m, 58640m, "Archivists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 19.9m, 1.6m, 82530m, "Agents and business managers of artists, performers, and athletes" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 26.5m, 2.2m, 0m, "Entertainers and performers, sports and related workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 58.9m, 4.8m, 102120m, "Financial risk specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 89.3m, 7.4m, 98950m, "Special effects artists and animators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 177.7m, 14.6m, 98560m, "Transportation, storage, and distribution managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.2m, 0.8m, 74410m, "Aerospace engineering and operations technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 26.4m, 2.2m, 67220m, "Entertainment and recreation managers, except gambling" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 159.0m, 13.1m, 43680m, "First-line supervisors of personal service workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 194.3m, 16.5m, 47180m, "Medical records specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 4.6m, 0.4m, 96370m, "Makeup artists, theatrical and performance" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 8.0m, 0.7m, 53490m, "Aircraft cargo handling supervisors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 62.4m, 5.3m, 81650m, "Biological science teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 64.0m, 5.5m, 37780m, "Agricultural equipment operators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 415.1m, 35.6m, 38520m, "Social and human service assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 196.9m, 17.1m, 31130m, "Manicurists and pedicurists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 43.4m, 3.8m, 125590m, "Optometrists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 55.0m, 4.9m, 75380m, "Chiropractors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 49.4m, 4.5m, 203090m, "Nurse anesthetists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.0m, 1.3m, 94270m, "Athletes and sports competitors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 82.0m, 7.5m, 38060m, "Skincare specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 178.4m, 16.2m, 74240m, "Social and community service managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 275.2m, 25.3m, 44890m, "Coaches and scouts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 45.5m, 4.2m, 103550m, "Engineering teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 51.0m, 4.8m, 63520m, "Film and video editors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 28.0m, 2.7m, 47010m, "Mechanical door repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 191.4m, 18.4m, 60280m, "Healthcare social workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 531.4m, 51.1m, 102240m, "Computer systems analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 20.4m, 2m, 36010m, "Umpires, referees, and other sports officials" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 95.9m, 9.3m, 46860m, "Cargo and freight agents" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 107.1m, 10.4m, 37380m, "Psychiatric technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 449.4m, 43.8m, 98740m, "Computer occupations, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 987.6m, 95.7m, 95290m, "Management analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 17.7m, 1.7m, 45030m, "Recreational vehicle service technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 119.0m, 11.6m, 99930m, "Medical scientists, except epidemiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.4m, 1.4m, 47270m, "Museum technicians and conservators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 64.0m, 6.4m, 134870m, "Database architects" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 286.1m, 28.5m, 96310m, "Mechanical engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 24.7m, 2.5m, 57970m, "Occupational health and safety technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 16.5m, 1.7m, 51350m, "Exercise physiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 14.4m, 1.5m, 82680m, "Audiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 113.5m, 12m, 51240m, "Mental health and substance abuse social workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 13.9m, 1.5m, 60380m, "Curators" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.3m, 1.3m, 27860m, "Shampooers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 67.5m, 7.7m, 90130m, "Clinical and counseling psychologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 111.1m, 12.6m, 63760m, "Flight attendants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 139.6m, 16.1m, 93180m, "Occupational therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1164.6m, 133.8m, 40410m, "Light truck drivers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 327.3m, 38.4m, 96350m, "Industrial engineers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 42.3m, 5.2m, 60800m, "Therapists, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 133.1m, 16.7m, 70540m, "Respiratory therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 18.5m, 2.3m, 63740m, "Forensic science technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 66.5m, 8.4m, 38860m, "Ophthalmic medical technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 327.6m, 42m, 95390m, "Personal financial advisors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 66.4m, 8.8m, 57860m, "Medical equipment repairers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 113.8m, 15.2m, 78570m, "Occupational health and safety specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 868.6m, 116.6m, 68230m, "Market research analysts and marketing specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 329.5m, 45.2m, 45380m, "Exercise trainers and group fitness instructors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 764.4m, 105.9m, 38270m, "Medical assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 33.8m, 4.8m, 53840m, "Athletic trainers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 67.2m, 9.4m, 46190m, "Community health workers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 83.8m, 12m, 81350m, "Diagnostic medical sonographers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.2m, 1.5m, 59020m, "Hearing aid specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 2.4m, 0.4m, 48110m, "Forest fire inspectors and prevention specialists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 71.2m, 10.6m, 56570m, "Marriage and family therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 402.2m, 59.9m, 59830m, "Industrial machinery mechanics" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 246.8m, 37.3m, 97720m, "Physical therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 117.9m, 17.9m, 83240m, "Web and digital interface designers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 9.5m, 1.5m, 77070m, "Orthotists and prosthetists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 557.4m, 86m, 164070m, "Computer and information systems managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 339.0m, 52.5m, 29530m, "Animal caretakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 28.5m, 4.6m, 60800m, "Computer numerically controlled tool programmers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 54.1m, 8.7m, 35620m, "Animal trainers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 792.6m, 126.6m, 139790m, "Financial managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 3.5m, 0.6m, 89990m, "Genetic counselors" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 37.9m, 6.2m, 58250m, "Health information technologists and medical registrars" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 98.8m, 16.7m, 78580m, "Web developers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 68.2m, 11.7m, 43390m, "Counselors, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 85.9m, 15.6m, 78580m, "Nursing instructors and teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 134.3m, 24.6m, 49860m, "Massage therapists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 208.7m, 38.3m, 77520m, "Logisticians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 388.2m, 71.5m, 49710m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 262.8m, 50.2m, 100300m, "Health specialties teachers, postsecondary" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 171.4m, 33.1m, 84140m, "Speech-language pathologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 65.6m, 12.8m, 82210m, "Financial examiners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 89.5m, 17.7m, 103260m, "Veterinarians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 200.8m, 40.8m, 99620m, "Software quality assurance analysts and testers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1361.2m, 277.6m, 34110m, "Cooks, restaurant" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 87.0m, 17.9m, 34670m, "Personal care and service workers, all other" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 114.8m, 23.5m, 34740m, "Veterinary assistants and laboratory animal caretakers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 122.9m, 25.2m, 38240m, "Veterinary technologists and technicians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 177.3m, 36.4m, 30670m, "Taxi drivers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage" },
                values: new object[] { 3715.5m, 804.6m, 30180m });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 29.4m, 6.6m, 45230m, "Solar photovoltaic installers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 109.9m, 24.7m, 85720m, "Operations research analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 36.5m, 8.3m, 136620m, "Computer and information research scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 30.0m, 7m, 113990m, "Actuaries" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 45.1m, 10.8m, 64250m, "Occupational therapy assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 1594.5m, 410.4m, 127260m, "Software developers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 100.7m, 26.3m, 62770m, "Physical therapist assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 148.0m, 39.3m, 126010m, "Physician assistants" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 10.0m, 2.7m, 78520m, "Epidemiologists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 509.5m, 144.7m, 104830m, "Medical and health services managers" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 168.9m, 53.2m, 112000m, "Information security analysts" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 33.3m, 10.5m, 98920m, "Statisticians" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 168.9m, 59.4m, 103500m, "Data scientists" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 266.3m, 118.6m, 121610m, "Nurse practitioners" });

            migrationBuilder.UpdateData(
                table: "Occupations",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "currently_employed", "decade_change_percentage", "median_annual_wage", "title" },
                values: new object[] { 11.2m, 5m, 57320m, "Wind turbine service technicians" });
        }
    }
}
