using System;
using System.Collections.Generic;

namespace Something
{
    public partial class AdrEmail
    {
        public int AmId { get; set; }
        public int AmIdAdres { get; set; }
        public string AmEmail { get; set; }
        public int AmRodzaj { get; set; }
        public bool AmPodstawowy { get; set; }

        public virtual AdrEwid AmIdAdresNavigation { get; set; }
    }
}
