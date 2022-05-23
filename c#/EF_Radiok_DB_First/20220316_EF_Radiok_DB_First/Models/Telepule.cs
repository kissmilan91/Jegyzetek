using System;
using System.Collections.Generic;

#nullable disable

namespace _20220316_EF_Radiok_DB_First.Models
{
    public partial class Telepule
    {
        public Telepule()
        {
            Kioszta = new HashSet<Kioszta>();
        }
        
        public string Nev { get; set; }
        public string Megye { get; set; }

        public virtual Regio MegyeNavigation { get; set; }
        public virtual ICollection<Kioszta> Kioszta { get; set; }
    }
}
