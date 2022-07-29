using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something
{
    [DebuggerDisplay("{rt_id} {rt_Nazwa}")]
    public class Rabat
    {
        public Rabat() 
        {
            Towary = new List<Towar>();
        }
        [Key]
        public int rt_id { get; set; }
        public string rt_Nazwa { get; set; }
        public int rt_Rodzaj { get; set; }
        public decimal rt_Procent { get; set; }

        public List<Towar> Towary { get; set; }
    }
}
