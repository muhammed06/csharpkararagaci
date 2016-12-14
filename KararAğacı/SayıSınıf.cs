using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararAğacı
{
    class SayıSınıf
    {
        public string isim = "";
        public int sayı = 0;
        public double ToplamDeğer=0.0;
        public SayıSınıf(string isi,int say,double ToplamD)
        {
            isim = isi;
            sayı = say;
            ToplamDeğer = ToplamD;
        }
    }
}
