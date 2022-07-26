using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Something.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sl_Rabat",
                columns: table => new
                {
                    rt_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rt_Nazwa = table.Column<string>(nullable: true),
                    rt_Rodzaj = table.Column<int>(nullable: false),
                    rt_Procent = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sl_Rabat", x => x.rt_id);
                });

            migrationBuilder.CreateTable(
                name: "tw_Towar",
                columns: table => new
                {
                    tw_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tw_Zablokowany = table.Column<int>(nullable: false),
                    tw_Rodzaj = table.Column<int>(nullable: false),
                    tw_Symbol = table.Column<string>(nullable: true),
                    tw_Nazwa = table.Column<string>(nullable: true),
                    tw_Opis = table.Column<string>(nullable: true),
                    tw_IdVatSp = table.Column<int>(nullable: false),
                    tw_IdVatZak = table.Column<int>(nullable: false),
                    tw_JakPrzySp = table.Column<int>(nullable: false),
                    tw_JednMiary = table.Column<string>(nullable: true),
                    tw_PKWiU = table.Column<string>(nullable: true),
                    tw_SWW = table.Column<string>(nullable: true),
                    tw_IdRabat = table.Column<int>(nullable: false),
                    tw_IdOpakowanie = table.Column<int>(nullable: false),
                    tw_PrzezWartosc = table.Column<int>(nullable: false),
                    tw_IdPodstDostawca = table.Column<int>(nullable: false),
                    tw_DostSymbol = table.Column<string>(nullable: true),
                    tw_CzasDostawy = table.Column<int>(nullable: false),
                    tw_UrzNazwa = table.Column<string>(nullable: true),
                    tw_PLU = table.Column<int>(nullable: false),
                    tw_PodstKodKresk = table.Column<string>(nullable: true),
                    tw_IdTypKodu = table.Column<int>(nullable: false),
                    tw_CenaOtwarta = table.Column<int>(nullable: false),
                    tw_WagaEtykiet = table.Column<int>(nullable: false),
                    tw_KontrolaTW = table.Column<int>(nullable: false),
                    tw_StanMin = table.Column<decimal>(nullable: false),
                    tw_JednStanMin = table.Column<string>(nullable: true),
                    tw_DniWaznosc = table.Column<int>(nullable: false),
                    tw_IdGrupa = table.Column<int>(nullable: false),
                    tw_WWW = table.Column<string>(nullable: true),
                    tw_SklepInternet = table.Column<int>(nullable: false),
                    tw_Pole1 = table.Column<string>(nullable: true),
                    tw_Pole2 = table.Column<string>(nullable: true),
                    tw_Pole3 = table.Column<string>(nullable: true),
                    tw_Pole4 = table.Column<string>(nullable: true),
                    tw_Pole5 = table.Column<string>(nullable: true),
                    tw_Pole6 = table.Column<string>(nullable: true),
                    tw_Pole7 = table.Column<string>(nullable: true),
                    tw_Pole8 = table.Column<string>(nullable: true),
                    tw_Uwagi = table.Column<string>(nullable: true),
                    tw_Logo = table.Column<int>(nullable: false),
                    tw_Usuniety = table.Column<int>(nullable: false),
                    tw_Objetosc = table.Column<decimal>(nullable: false),
                    tw_Masa = table.Column<decimal>(nullable: false),
                    tw_Charakter = table.Column<string>(nullable: true),
                    tw_JednMiaryZak = table.Column<string>(nullable: true),
                    tw_JMZakInna = table.Column<int>(nullable: false),
                    tw_KodTowaru = table.Column<string>(nullable: true),
                    tw_IdKrajuPochodzenia = table.Column<int>(nullable: false),
                    tw_IdUJM = table.Column<int>(nullable: false),
                    tw_JednMiarySprz = table.Column<string>(nullable: true),
                    tw_JMSprzInna = table.Column<int>(nullable: false),
                    tw_SerwisAukcyjny = table.Column<int>(nullable: false),
                    tw_IdProducenta = table.Column<int>(nullable: false),
                    tw_SprzedazMobilna = table.Column<int>(nullable: false),
                    tw_IsFundPromocji = table.Column<int>(nullable: false),
                    tw_IdFundPromocji = table.Column<int>(nullable: false),
                    tw_DomyslnaKategoria = table.Column<int>(nullable: false),
                    tw_Wysokosc = table.Column<decimal>(nullable: false),
                    tw_Szerokosc = table.Column<decimal>(nullable: false),
                    tw_Glebokosc = table.Column<decimal>(nullable: false),
                    tw_StanMaks = table.Column<decimal>(nullable: false),
                    tw_Akcyza = table.Column<int>(nullable: false),
                    tw_AkcyzaZaznacz = table.Column<int>(nullable: false),
                    tw_AkcyzaKwota = table.Column<decimal>(nullable: false),
                    tw_ObrotMarza = table.Column<int>(nullable: false),
                    tw_OdwrotneObciazenie = table.Column<int>(nullable: false),
                    tw_ProgKwotowyOO = table.Column<int>(nullable: false),
                    tw_DodawalnyDoZW = table.Column<int>(nullable: false),
                    tw_isbn = table.Column<string>(nullable: true),
                    tw_bloz_7 = table.Column<string>(nullable: true),
                    tw_bloz_12 = table.Column<string>(nullable: true),
                    tw_KodUProducenta = table.Column<string>(nullable: true),
                    tw_Komunikat = table.Column<string>(nullable: true),
                    tw_KomunikatOd = table.Column<DateTime>(nullable: false),
                    tw_KomunikatDokumenty = table.Column<int>(nullable: false),
                    tw_MechanizmPodzielonejPlatnosci = table.Column<int>(nullable: false),
                    tw_GrupaJpkVat = table.Column<int>(nullable: false),
                    tw_OplCukrowaPodlega = table.Column<int>(nullable: false),
                    tw_OplCukrowaObj = table.Column<decimal>(nullable: false),
                    tw_OplCukrowaZawartoscCukru = table.Column<decimal>(nullable: false),
                    tw_OplCukrowaInneSlodzace = table.Column<int>(nullable: false),
                    tw_OplCukrowaSok = table.Column<int>(nullable: false),
                    tw_OplCukrowaKwota = table.Column<decimal>(nullable: false),
                    tw_OplCukrowaKofeinaPodlega = table.Column<int>(nullable: false),
                    tw_OplCukrowaKofeinaKwota = table.Column<decimal>(nullable: false),
                    tw_OplCukrowaNapojWeglElektr = table.Column<int>(nullable: false),
                    tw_OplCukrowaKwotaPowyzej = table.Column<decimal>(nullable: false),
                    tw_MasaNetto = table.Column<decimal>(nullable: false),
                    tw_IdKoduWyrobuAkcyzowego = table.Column<int>(nullable: false),
                    tw_AkcyzaMarkaWyrobow = table.Column<string>(nullable: true),
                    tw_AkcyzaWielkoscProducenta = table.Column<string>(nullable: true),
                    tw_ZnakiAkcyzy = table.Column<int>(nullable: false),
                    tw_DataZmianyVatSprzedazy = table.Column<DateTime>(nullable: false),
                    tw_WegielPodlegaOswiadczeniu = table.Column<int>(nullable: false),
                    tw_WegielOpisPochodzenia = table.Column<string>(nullable: true),
                    rt_id = table.Column<int>(nullable: false),
                    Rabatrt_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tw_Towar", x => x.tw_Id);
                    table.ForeignKey(
                        name: "FK_tw_Towar_sl_Rabat_Rabatrt_id",
                        column: x => x.Rabatrt_id,
                        principalTable: "sl_Rabat",
                        principalColumn: "rt_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tw_Towar_Rabatrt_id",
                table: "tw_Towar",
                column: "Rabatrt_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tw_Towar");

            migrationBuilder.DropTable(
                name: "sl_Rabat");
        }
    }
}
