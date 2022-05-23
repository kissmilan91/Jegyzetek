using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210407_Uzemanyagarak
{
    class BenzinÁr
    {
        public DateTime Dátum { get; private set; }
        public int Benzinár { get; private set; }

        public BenzinÁr(DateTime dátum, int ár)
        {
            this.Dátum = dátum;
            this.Benzinár = ár;
        }

        public override string ToString()
        {
            return String.Format("{0};{1}", this.Dátum.ToString("yyyy.MM.dd"), this.Benzinár);
        }
    }
}
