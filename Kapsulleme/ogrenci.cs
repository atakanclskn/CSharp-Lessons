using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    internal class ogrenci
    {
        private string isim;   // Öğrencinin ismi
        private int yas;       // Öğrencinin yaşı
        private double not;    // Öğrencinin notu

        public string Isim
        {
            get { return isim; }      // ismi döndürür
            set { isim = value; }     // ismi değiştirir
        }

        public int Yas
        {
            get { return yas; }       // yaşı döndürür
            set { yas = value; }      // yaşı değiştirir
        }

        public double Not
        {
            get { return not; }       // notu döndürür
            set { not = value; }      // notu değiştirir
        }
    }
}
