using System;
using System.Collections.Generic;

#nullable disable

namespace _20220316_EF_Radiok_DB_First.Models
{
    public partial class Kioszta
    {
        public int Azon { get; set; }
        public double Frekvencia { get; set; }
        public double Teljesitmeny { get; set; }
        public string Csatorna { get; set; }
        public string Adohely { get; set; }
        public string Cim { get; set; }

        public virtual Telepule AdohelyNavigation { get; set; }

        public string TeljesitmenyKategoria
        {
            get
            {
                if (Teljesitmeny < 0.1) return "Helyi";
                else if (Teljesitmeny < 1) return "Térségi";
                else return "Országos";
            }
        }
    }
}
