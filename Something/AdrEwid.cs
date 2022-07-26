using System;
using System.Collections.Generic;

namespace Something
{
    public partial class AdrEwid
    {
        public AdrEwid()
        {
            AdrEmail = new HashSet<AdrEmail>();
        }

        public int AdrId { get; set; }
        public int AdrIdObiektu { get; set; }
        public int AdrTypAdresu { get; set; }
        public string AdrNazwa { get; set; }
        public string AdrNazwaPelna { get; set; }
        public string AdrTelefon { get; set; }
        public string AdrFaks { get; set; }
        public string AdrUlica { get; set; }
        public string AdrNrDomu { get; set; }
        public string AdrNrLokalu { get; set; }
        public string AdrAdres { get; set; }
        public string AdrKod { get; set; }
        public string AdrMiejscowosc { get; set; }
        public int? AdrIdWojewodztwo { get; set; }
        public int? AdrIdPanstwo { get; set; }
        public string AdrNip { get; set; }
        public string AdrPoczta { get; set; }
        public string AdrGmina { get; set; }
        public string AdrPowiat { get; set; }
        public string AdrSkrytka { get; set; }
        public string AdrSymbol { get; set; }
        public int? AdrIdGminy { get; set; }
        public int? AdrIdWersja { get; set; }
        public int? AdrIdZmienil { get; set; }
        public DateTime? AdrDataZmiany { get; set; }
        public string AdrNrUrzeduSkarbowego { get; set; }
        public string AdrNrEori { get; set; }

        public virtual ICollection<AdrEmail> AdrEmail { get; set; }
    }
}
