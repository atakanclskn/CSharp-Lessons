using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicPrivateErisimBelirleyiciler
{
    internal class Musteri
    {
        public string isim;
        public string surname;
        public int maas;
        public string sex;
        private string yas;

        public Musteri()
        {
            Console.WriteLine("Musteri sinifinin constructor yapisi calisti!");
        }

        public void musterininBilgileriniGoster()
        {
            Console.WriteLine("Isim Soyisim"+surname+isim);
            Console.WriteLine("Maas:"+maas);
            Console.WriteLine("Cinsiyet:"+sex);
            Console.WriteLine("Yas degeri:"+yas);
        }

        public void isimSoyisimYazdir(string musteriisim,string musteriSoyisim)
        {
            Console.WriteLine("Musterinin Isim Soyismi:"+musteriisim+" "+musteriSoyisim);
        }
    }
}

    
