using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DorucovaciSluzba.Migrations
{
    /// <inheritdoc />
    public partial class VsePredelanoNaIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zasilka_Uzivatel_KuryrId",
                table: "Zasilka");

            migrationBuilder.DropForeignKey(
                name: "FK_Zasilka_Uzivatel_OdesilatelId",
                table: "Zasilka");

            migrationBuilder.DropForeignKey(
                name: "FK_Zasilka_Uzivatel_PrijemceId",
                table: "Zasilka");

            migrationBuilder.DropTable(
                name: "Uzivatel");

            migrationBuilder.DropTable(
                name: "TypUzivatel");

            migrationBuilder.DeleteData(
                table: "Zasilka",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Zasilka",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DatumNarozeni = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Telefon = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ulice = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CP = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mesto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Psc = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "9cf14c2c-19e7-40d6-b744-8917505c3106", "Admin", "ADMIN" },
                    { 2, "3ea1f7bc-4de1-5fg9-d4e8-5890e8cdb4ff", "Podpora", "PODPORA" },
                    { 3, "be0efcde-9d0a-461d-8eb6-444b043d6660", "Kurýr", "KURYR" },
                    { 4, "29dafca7-cd20-4cd9-a3dd-4779d7bac3ee", "Uživatel", "UZIVATEL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CP", "ConcurrencyStamp", "DatumNarozeni", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Mesto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Psc", "SecurityStamp", "Telefon", "TwoFactorEnabled", "Ulice", "UserName" },
                values: new object[,]
                {
                    { 1, 0, null, "b09a83ae-cfd3-4ee7-97e6-fbcf0b0fe78c", null, "admin@dorucovacisluzba.cz", true, "Jan", "Novák", true, null, null, "ADMIN@DORUCOVACISLUZBA.CZ", "ADMIN", "AQAAAAEAACcQAAAAEM9O98Suoh2o2JOK1ZOJScgOfQ21odn/k6EYUpGWnrbevCaBFFXrNL7JZxHNczhh/w==", null, false, null, "SEJEPXC646ZBNCDYSM3H5FRK5RWP2TN6", null, false, null, "admin" },
                    { 2, 0, null, "7a8d96fd-5918-441b-b800-cbafa99de97b", null, "kuryr@dorucovacisluzba.cz", true, "Petr", "Svoboda", true, null, null, "KURYR@DORUCOVACISLUZBA.CZ", "KURYR", "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==", "700 123 456", false, null, "MAJXOSATJKOEM4YFF32Y5G2XPR5OFEL6", "700 123 456", false, null, "kuryr" },
                    { 3, 0, null, "d20c95cg-ehg5-6gg9-d0g8-hdfhb21hg90e", null, "kuryr2@dorucovacisluzba.cz", true, "Lukáš", "Černý", true, null, null, "KURYR2@DORUCOVACISLUZBA.CZ", "KURYR2", "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==", "702 456 789", false, null, "KURYR2XC646ZBNCDYSM3H5FRK5RWP2TN6", "702 456 789", false, null, "kuryr2" },
                    { 4, 0, null, "c19b94bf-dgf4-5ff8-c9f7-gcfga10gf89d", null, "podpora@dorucovacisluzba.cz", true, "Marie", "Dvořáková", true, null, null, "PODPORA@DORUCOVACISLUZBA.CZ", "PODPORA", "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==", "777 888 999", false, null, "PODPORAXC646ZBNCDYSM3H5FRK5RWP2TN6", "777 888 999", false, null, "podpora" },
                    { 5, 0, "123", "e31d05dh-fih6-7hh0-e1h9-ieiic32ih01f", null, "karel.prochazka@email.cz", true, "Karel", "Procházka", true, null, "Praha", "KAREL.PROCHAZKA@EMAIL.CZ", "KAREL.PROCHAZKA", "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==", "603 111 222", false, "110 00", "UZIV1XC646ZBNCDYSM3H5FRK5RWP2TN6", "603 111 222", false, "Hlavní", "karel.prochazka" },
                    { 6, 0, "456", "f42e16ei-gji7-8ii1-f2i0-jfjjd43ji12g", null, "eva.malkova@email.cz", true, "Eva", "Málková", true, null, "Brno", "EVA.MALKOVA@EMAIL.CZ", "EVA.MALKOVA", "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==", "604 333 444", false, "602 00", "UZIV2XC646ZBNCDYSM3H5FRK5RWP2TN6", "604 333 444", false, "Nádražní", "eva.malkova" },
                    { 7, 0, "789", "g53f27fj-hkj8-9jj2-g3j1-kgkkf54kj23h", null, "tomas.vesely@email.cz", true, "Tomáš", "Veselý", true, null, "Ostrava", "TOMAS.VESELY@EMAIL.CZ", "TOMAS.VESELY", "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==", "605 555 666", false, "700 30", "UZIV3XC646ZBNCDYSM3H5FRK5RWP2TN6", "605 555 666", false, "Zahradní", "tomas.vesely" },
                    { 8, 0, "321", "h64g38gk-ilk9-0kk3-h4k2-lhllg65lk34i", null, "jana.horakova@email.cz", true, "Jana", "Horáková", true, null, "Plzeň", "JANA.HORAKOVA@EMAIL.CZ", "JANA.HORAKOVA", "AQAAAAEAACcQAAAAEOzeajp5etRMZn7TWj9lhDMJ2GSNTtljLWVIWivadWXNMz8hj6mZ9iDR+alfEUHEMQ==", "606 777 888", false, "301 00", "UZIV4XC646ZBNCDYSM3H5FRK5RWP2TN6", "606 777 888", false, "Školní", "jana.horakova" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 2, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "Zasilka",
                columns: new[] { "Id", "Cislo", "DatumOdeslani", "DestinaceCP", "DestinaceMesto", "DestinacePsc", "DestinaceUlice", "KuryrId", "OdesilatelId", "PrijemceId", "StavId", "UserId" },
                values: new object[,]
                {
                    { 1, "123-45-67", new DateTime(2025, 11, 20, 10, 30, 0, 0, DateTimeKind.Unspecified), "456", "Brno", "602 00", "Nádražní", 2, 5, 6, 3, null },
                    { 2, "234-56-78", new DateTime(2025, 11, 23, 14, 15, 0, 0, DateTimeKind.Unspecified), "789", "Ostrava", "700 30", "Zahradní", 3, 6, 7, 2, null },
                    { 3, "345-67-89", new DateTime(2025, 11, 24, 9, 0, 0, 0, DateTimeKind.Unspecified), "321", "Plzeň", "301 00", "Školní", null, 7, 8, 1, null },
                    { 4, "456-78-90", new DateTime(2025, 11, 22, 16, 45, 0, 0, DateTimeKind.Unspecified), "123", "Praha", "110 00", "Hlavní", 2, 8, 5, 2, null },
                    { 5, "567-89-01", new DateTime(2025, 11, 18, 11, 20, 0, 0, DateTimeKind.Unspecified), "789", "Ostrava", "700 30", "Zahradní", 3, 5, 7, 3, null },
                    { 6, "678-90-12", new DateTime(2025, 11, 15, 8, 30, 0, 0, DateTimeKind.Unspecified), "123", "Praha", "110 00", "Hlavní", 2, 6, 5, 4, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zasilka_UserId",
                table: "Zasilka",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Zasilka_AspNetUsers_KuryrId",
                table: "Zasilka",
                column: "KuryrId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zasilka_AspNetUsers_OdesilatelId",
                table: "Zasilka",
                column: "OdesilatelId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zasilka_AspNetUsers_PrijemceId",
                table: "Zasilka",
                column: "PrijemceId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zasilka_AspNetUsers_UserId",
                table: "Zasilka",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zasilka_AspNetUsers_KuryrId",
                table: "Zasilka");

            migrationBuilder.DropForeignKey(
                name: "FK_Zasilka_AspNetUsers_OdesilatelId",
                table: "Zasilka");

            migrationBuilder.DropForeignKey(
                name: "FK_Zasilka_AspNetUsers_PrijemceId",
                table: "Zasilka");

            migrationBuilder.DropForeignKey(
                name: "FK_Zasilka_AspNetUsers_UserId",
                table: "Zasilka");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Zasilka_UserId",
                table: "Zasilka");

            migrationBuilder.DeleteData(
                table: "Zasilka",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zasilka",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zasilka",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Zasilka",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zasilka",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Zasilka");

            migrationBuilder.CreateTable(
                name: "TypUzivatel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Typ = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypUzivatel", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Uzivatel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypId = table.Column<int>(type: "int", nullable: false),
                    CP = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DatumNarozeni = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Heslo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Jmeno = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mesto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Prijmeni = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Psc = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefon = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ulice = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uzivatel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uzivatel_TypUzivatel_TypId",
                        column: x => x.TypId,
                        principalTable: "TypUzivatel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "TypUzivatel",
                columns: new[] { "Id", "Typ" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Běžný uživatel" },
                    { 3, "Kurýr" },
                    { 4, "Podpora" }
                });

            migrationBuilder.UpdateData(
                table: "Zasilka",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cislo", "DatumOdeslani", "DestinaceCP", "DestinaceMesto", "DestinacePsc", "DestinaceUlice", "KuryrId", "OdesilatelId", "PrijemceId", "StavId" },
                values: new object[] { "532-65-33", new DateTime(2025, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "4653", "Zlín", "760 01", "Kvítková", 4, 3, 2, 2 });

            migrationBuilder.InsertData(
                table: "Uzivatel",
                columns: new[] { "Id", "CP", "DatumNarozeni", "Email", "Heslo", "Jmeno", "Mesto", "Prijmeni", "Psc", "Telefon", "TypId", "Ulice" },
                values: new object[,]
                {
                    { 1, null, null, "admin@web.cz", "admin", "Web", null, "Admin", null, null, 1, null },
                    { 2, "4653", new DateTime(1995, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "novak@web.cz", "test", "Petr", "Zlín", "Novák", "760 01", "700 600 500", 2, "Kvítková" },
                    { 3, "4872", new DateTime(1998, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "buben@web.cz", "test", "Prokop", "Zlín", "Buben", "760 01", "700 600 400", 2, "Družstevní" },
                    { 4, null, null, "novotny@web.cz", "test", "Petr", null, "Novotný", null, "300 600 500", 3, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uzivatel_TypId",
                table: "Uzivatel",
                column: "TypId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zasilka_Uzivatel_KuryrId",
                table: "Zasilka",
                column: "KuryrId",
                principalTable: "Uzivatel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zasilka_Uzivatel_OdesilatelId",
                table: "Zasilka",
                column: "OdesilatelId",
                principalTable: "Uzivatel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zasilka_Uzivatel_PrijemceId",
                table: "Zasilka",
                column: "PrijemceId",
                principalTable: "Uzivatel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
