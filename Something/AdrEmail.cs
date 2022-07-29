using System;
using System.Collections.Generic;

namespace Something
{
    public class AdrEmail
    {
        public AdrEmail() { }
        public int am_Id { get; set; }
        public int am_IdAdres { get; set; }
        public string am_Email { get; set; }
        public int am_Rodzaj { get; set; }
        public bool am_Podstawowy { get; set; }

        public int FK_adr_Email_adr__Ewid { get; set; }
        public AdrEwid AdrEwid { get; set; }
    }
}
