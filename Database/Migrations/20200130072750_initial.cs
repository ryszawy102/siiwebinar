using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(nullable: true),
                    TypeOfRisk = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyId);
                });

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    OfficeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficeName = table.Column<string>(nullable: true),
                    OfficeStreet = table.Column<string>(nullable: true),
                    OfficePostCode = table.Column<string>(nullable: true),
                    OfficeCity = table.Column<string>(nullable: true),
                    OfficeReceptionTelephone = table.Column<string>(nullable: true),
                    OfficeEmail = table.Column<string>(nullable: true),
                    OpenYear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.OfficeId);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    WorkerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerName = table.Column<string>(nullable: true),
                    WorkerSurname = table.Column<string>(nullable: true),
                    OfficeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK_Workers_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkerHobby",
                columns: table => new
                {
                    WorkerId = table.Column<int>(nullable: false),
                    HobbyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerHobby", x => new { x.HobbyId, x.WorkerId });
                    table.ForeignKey(
                        name: "FK_WorkerHobby_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerHobby_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "HobbyName", "TypeOfRisk" },
                values: new object[,]
                {
                    { 1, "Football", null },
                    { 2, "Volleyball", null },
                    { 3, "Basketball", null },
                    { 4, "Fashion", null },
                    { 5, "Reading books", null },
                    { 6, "Book writer", null },
                    { 7, "Shooting", null },
                    { 8, "Traveling", null },
                    { 9, "Speleologist", null },
                    { 10, "Mountain hiker", null }
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "OfficeId", "OfficeCity", "OfficeEmail", "OfficeName", "OfficePostCode", "OfficeReceptionTelephone", "OfficeStreet", "OpenYear" },
                values: new object[,]
                {
                    { 12, "Bydgoszcz", "informacja-bydgoszcz@sii.pl", "Sii Bydgoszcz", "85-033", "+48 52 523 92 67", "Plac Kościeleckich 3", 2018 },
                    { 11, "Piła", "informacja-pila@sii.pl", "Sii Piła", "64-920", null, "Kasztanowa Office, ul. Kossaka 20", 2018 },
                    { 10, "Częstochowa", "informacja-czestochowa@sii.pl", "Sii Częstochowa", "42-217", null, "ul. Jasnogórska 79", 2018 },
                    { 9, "Rzeszów", "informacja-rzeszow@sii.pl", "Sii Rzeszów", "35-310", "+48 17 283 83 15", "ul. Rejtana 20", 2018 },
                    { 8, "Katowice", "informacja-katowice@sii.pl", "Sii Katowice", "40-114", "+48 32 661 41 91", "ul. Ściegiennego 3", 2018 },
                    { 7, "Lublin", "informacja-lublin@sii.pl", "Sii Lublin", "20-883", "+48 81 45 46 888", "ul. Szeligowskiego 6B", 2012 },
                    { 2, "Gdańsk", "informacja-gdansk@sii.pl", "Sii Gdańsk", "80-309", "+48 58 32 17 800", "al. Grunwaldzka 472e", 2008 },
                    { 5, "Kraków", "informacja-krakow@sii.pl", "Sii Kraków", "30-522", "+48 12 390 61 70", "ul. Wielicka 28", 2011 },
                    { 4, "Poznań", "informacja-poznan@sii.pl", "Sii Poznań", "61-872", "+48 61 639 76 80", "ul. Królowej Jadwigi 43", 2010 },
                    { 3, "Wrocław", "informacja-wroclaw@sii.pl", "Sii Wrocław", "53-413", "+48 71 75 82 290", "ul. Gwiaździsta 66", 2009 },
                    { 13, "Gliwice", "informacja-gliwice@sii.pl", "Sii Gliwice", "44-100", null, "Zygmunta Starego 24B", 2019 },
                    { 1, "Warszawa", "informacja@sii.pl", "Sii Warszawa", "02-626", "+48 22 486 37 37", "al. Niepodległości 69", 2006 },
                    { 6, "Łódź", "informacja-lodz@sii.pl", "Sii Łódź", "90-033", "+48 42 239 29 60", "ul. Kopcińskiego 79", 2011 },
                    { 14, "Białystok", "informacja-bialystok@sii.pl", "Sii Białystok", "15-402", null, "Józefa Marjańskiego 3", 2019 }
                });

            migrationBuilder.InsertData(
                table: "Workers",
                columns: new[] { "WorkerId", "OfficeId", "WorkerName", "WorkerSurname" },
                values: new object[,]
                {
                    { 4, 1, "Big", "Boss" },
                    { 5, 1, "Big", "Supervisor" },
                    { 1, 3, "Filip", "Sygula" },
                    { 2, 3, "Katarzyna", "C" },
                    { 3, 3, "Zbigniew", "L" }
                });

            migrationBuilder.InsertData(
                table: "WorkerHobby",
                columns: new[] { "HobbyId", "WorkerId" },
                values: new object[,]
                {
                    { 10, 4 },
                    { 9, 4 },
                    { 1, 5 },
                    { 1, 1 },
                    { 5, 1 },
                    { 7, 1 },
                    { 4, 2 },
                    { 10, 2 },
                    { 9, 2 },
                    { 8, 3 },
                    { 9, 3 },
                    { 1, 3 },
                    { 10, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkerHobby_WorkerId",
                table: "WorkerHobby",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_OfficeId",
                table: "Workers",
                column: "OfficeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkerHobby");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Offices");
        }
    }
}
