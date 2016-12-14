using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararAğacı
{
    class SayıSütunlar
    {
        public string isim = "";
        public int konum = 0;
        public List<SayıSınıf> SınıfList = new List<SayıSınıf>();
        public SayıSütunlar(string isi,int kon)
        {
            isim = isi;
            konum = kon;
        }
        public string başlık()
        {
            string başlıkS = "";
            for (int i=0; i< SınıfList.Count;i++)
            {
                var item = SınıfList[i];
                başlıkS += item.isim + ":" + (item.ToplamDeğer / (double)item.sayı).ToString();
                if (i != (SınıfList.Count - 1))
                {
                    başlıkS += "-";
                }
            }
            return "("+başlıkS+")";
        }
        public void DiziyeEkle(string sınıf,double değer)
        {
            foreach (var item in SınıfList)
            {
                if (item.isim==sınıf)
                {
                    item.ToplamDeğer += değer;
                    item.sayı += 1;
                    return;
                }
            }
            SınıfList.Add(new SayıSınıf(sınıf, 1, değer));
        }
        public string enYakın(double num)
        {
            double fark = Math.Abs((SınıfList[0].ToplamDeğer / (double)SınıfList[0].sayı) - num);
            string değer = SınıfList[0].isim;
            foreach (var item in SınıfList)
            {
                double arafark = Math.Abs((item.ToplamDeğer / (double)item.sayı) - num);
                if(arafark < fark)
                {
                    fark = arafark;
                    değer = item.isim;
                }
            }
            return değer;
        }
    }
}
