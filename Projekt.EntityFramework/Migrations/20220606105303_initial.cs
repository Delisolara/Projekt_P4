using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt.EntityFramework.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pracownik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nr_telefonu = table.Column<int>(type: "int", nullable: false),
                    Pensja = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pracownik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sprzet_sportowy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rodzaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firma = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprzet_sportowy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wypozyczalnia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PracownikId = table.Column<int>(type: "int", nullable: false),
                    Data_wypozyczenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_zwrotu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cena = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wypozyczalnia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wypozyczalnia_Pracownik_PracownikId",
                        column: x => x.PracownikId,
                        principalTable: "Pracownik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Klient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Haslo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nr_telefonu = table.Column<int>(type: "int", nullable: false),
                    WypozyczenieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Klient_Wypozyczalnia_WypozyczenieId",
                        column: x => x.WypozyczenieId,
                        principalTable: "Wypozyczalnia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sprzent_sportowyId = table.Column<int>(type: "int", nullable: false),
                    WypozyczalniaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lista_Sprzet_sportowy_Sprzent_sportowyId",
                        column: x => x.Sprzent_sportowyId,
                        principalTable: "Sprzet_sportowy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lista_Wypozyczalnia_WypozyczalniaId",
                        column: x => x.WypozyczalniaId,
                        principalTable: "Wypozyczalnia",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Klient_WypozyczenieId",
                table: "Klient",
                column: "WypozyczenieId");

            migrationBuilder.CreateIndex(
                name: "IX_Lista_Sprzent_sportowyId",
                table: "Lista",
                column: "Sprzent_sportowyId");

            migrationBuilder.CreateIndex(
                name: "IX_Lista_WypozyczalniaId",
                table: "Lista",
                column: "WypozyczalniaId");

            migrationBuilder.CreateIndex(
                name: "IX_Wypozyczalnia_PracownikId",
                table: "Wypozyczalnia",
                column: "PracownikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Klient");

            migrationBuilder.DropTable(
                name: "Lista");

            migrationBuilder.DropTable(
                name: "Sprzet_sportowy");

            migrationBuilder.DropTable(
                name: "Wypozyczalnia");

            migrationBuilder.DropTable(
                name: "Pracownik");
        }
    }
}
