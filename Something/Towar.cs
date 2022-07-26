using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something
{
    public class Towar
    {
        public Towar() { }
        [Key]
        public int tw_Id { get; set; }
        public int tw_Zablokowany { get; set; }
        public int tw_Rodzaj { get; set; }
        public string tw_Symbol { get; set; }
        public string tw_Nazwa { get; set; }
        public string tw_Opis { get; set; }
        public int tw_IdVatSp { get; set; }
        public int tw_IdVatZak { get; set; }
        public int tw_JakPrzySp { get; set; }
        public string tw_JednMiary { get; set; }
        public string tw_PKWiU { get; set; }
        public string tw_SWW { get; set; }
        public int tw_IdRabat { get; set; }
        public int tw_IdOpakowanie { get; set; }
        public int tw_PrzezWartosc { get; set; }
        public int tw_IdPodstDostawca { get; set; }
        public string tw_DostSymbol { get; set; }
        public int tw_CzasDostawy { get; set; }
        public string tw_UrzNazwa { get; set; }
        public int tw_PLU { get; set; }
        public string tw_PodstKodKresk { get; set; }
        public int tw_IdTypKodu { get; set; }
        public int tw_CenaOtwarta { get; set; }
        public int tw_WagaEtykiet { get; set; }
        public int tw_KontrolaTW { get; set; }
        public decimal tw_StanMin { get; set; }
        public string tw_JednStanMin { get; set; }
        public int tw_DniWaznosc { get; set; }
        public int tw_IdGrupa { get; set; }
        public string tw_WWW { get; set; }
        public int tw_SklepInternet { get; set; }
        public string tw_Pole1 { get; set; }
        public string tw_Pole2 { get; set; }
        public string tw_Pole3 { get; set; }
        public string tw_Pole4 { get; set; }
        public string tw_Pole5 { get; set; }
        public string tw_Pole6 { get; set; }
        public string tw_Pole7 { get; set; }
        public string tw_Pole8 { get; set; }
        public string tw_Uwagi { get; set; }
        public int tw_Logo { get; set; }
        public int tw_Usuniety { get; set; }
        public decimal tw_Objetosc { get; set; }
        public decimal tw_Masa { get; set; }
        public string tw_Charakter { get; set; }
        public string tw_JednMiaryZak { get; set; }
        public int tw_JMZakInna { get; set; }
        public string tw_KodTowaru { get; set; }
        public int tw_IdKrajuPochodzenia { get; set; }
        public int tw_IdUJM { get; set; }
        public string tw_JednMiarySprz { get; set; }
        public int tw_JMSprzInna { get; set; }
        public int tw_SerwisAukcyjny { get; set; }
        public int tw_IdProducenta { get; set; }
        public int tw_SprzedazMobilna { get; set; }
        public int tw_IsFundPromocji { get; set; }
        public int tw_IdFundPromocji { get; set; }
        public int tw_DomyslnaKategoria { get; set; }
        public decimal tw_Wysokosc { get; set; }
        public decimal tw_Szerokosc { get; set; }
        public decimal tw_Glebokosc { get; set; }
        public decimal tw_StanMaks { get; set; }
        public int tw_Akcyza { get; set; }
        public int tw_AkcyzaZaznacz { get; set; }
        public decimal tw_AkcyzaKwota { get; set; }
        public int tw_ObrotMarza { get; set; }
        public int tw_OdwrotneObciazenie { get; set; }
        public int tw_ProgKwotowyOO { get; set; }
        public int tw_DodawalnyDoZW { get; set; }
        public string tw_isbn { get; set; }
        public string tw_bloz_7 { get; set; }
        public string tw_bloz_12 { get; set; }
        public string tw_KodUProducenta { get; set; }
        public string tw_Komunikat { get; set; }
        public DateTime tw_KomunikatOd { get; set; }
        public int tw_KomunikatDokumenty { get; set; }
        public int tw_MechanizmPodzielonejPlatnosci { get; set; }
        public int tw_GrupaJpkVat { get; set; }
        public int tw_OplCukrowaPodlega { get; set; }
        public decimal tw_OplCukrowaObj { get; set; }
        public decimal tw_OplCukrowaZawartoscCukru { get; set; }
        public int tw_OplCukrowaInneSlodzace { get; set; }
        public int tw_OplCukrowaSok { get; set; }
        public decimal tw_OplCukrowaKwota { get; set; }
        public int tw_OplCukrowaKofeinaPodlega { get; set; }
        public decimal tw_OplCukrowaKofeinaKwota { get; set; }
        public int tw_OplCukrowaNapojWeglElektr { get; set; }
        public decimal tw_OplCukrowaKwotaPowyzej { get; set; }
        public decimal tw_MasaNetto { get; set; }
        public int tw_IdKoduWyrobuAkcyzowego { get; set; }
        public string tw_AkcyzaMarkaWyrobow { get; set; }
        public string tw_AkcyzaWielkoscProducenta { get; set; }
        public int tw_ZnakiAkcyzy { get; set; }
        public DateTime tw_DataZmianyVatSprzedazy { get; set; }
        public int tw_WegielPodlegaOswiadczeniu { get; set; }
        public string tw_WegielOpisPochodzenia { get; set; }

        public int rt_id { get; set; }
        public Rabat Rabat { get; set; }
    }
}
