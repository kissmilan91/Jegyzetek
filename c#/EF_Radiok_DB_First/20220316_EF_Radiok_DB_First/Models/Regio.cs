using System;
using System.Collections.Generic;

#nullable disable

namespace _20220316_EF_Radiok_DB_First.Models
{
    public partial class Regio
    {
        public Regio()
        {
            Telepules = new HashSet<Telepule>();
        }

        public string Nev { get; set; }
        public string Megye { get; set; }

        public virtual ICollection<Telepule> Telepules { get; set; }
    }
}
