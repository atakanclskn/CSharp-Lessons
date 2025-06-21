// Gerekli sistem kütüphanelerini ekler
using System;
// Koleksiyonlar için kütüphane
using System.Collections.Generic;
// LINQ işlemleri için kütüphane
using System.Linq;
// Metin işlemleri için kütüphane
using System.Text;
// Çoklu görevler için kütüphane
using System.Threading.Tasks;

// TurDonusumleri adında bir ad alanı tanımlar
namespace TurDonusumleri
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Tür dönüşümleri: Bir veri tipini başka bir veri tipine çevirmek için kullanılır.
            // Tür dönüşümleri ikiye ayrılır: Açık (explicit) ve kapalı (implicit) dönüşüm.

            int a = 500; // int tipinde bir değişken
            byte b = (byte)a; // Açık (explicit) dönüşüm: int -> byte (veri kaybı olabilir)
            Console.WriteLine(b.GetType()); // b'nin tipini ekrana yazdırır
            Console.WriteLine(b); // b'nin değerini ekrana yazdırır (500, byte sınırını aştığı için veri kaybı olur)

            //=====================

            string say1 = "1"; // string tipinde bir sayı
            string say2 = "2"; // string tipinde bir sayı

            int x = int.Parse(say1); // string -> int dönüşümü (Parse metodu ile)
            int y = int.Parse(say2); // string -> int dönüşümü
            Console.WriteLine(x + y); // Toplama işlemi (1 + 2 = 3)

            //=====================

            int z = Convert.ToInt32(say1); // string -> int dönüşümü (Convert sınıfı ile)
            int w = Convert.ToInt32(say2); // string -> int dönüşümü
            Console.WriteLine(z + w); // Toplama işlemi (1 + 2 = 3)

            //=====================

            int sayi1 = 5;
            int sayi2 = 10;
            string yazdir = (Convert.ToString(sayi1) + Convert.ToString(sayi2)); // int -> string dönüşümü ve birleştirme
            Console.WriteLine(yazdir); // "510" olarak ekrana yazdırılır

            //=====================

            // Diğer tür dönüşümleri örnekleri:

            double d = 12.34; // double tipinde bir sayı
            int dToInt = (int)d; // Açık (explicit) dönüşüm: double -> int (ondalık kısmı kaybolur)
            Console.WriteLine(dToInt); // 12

            float f = 7.89f; // float tipinde bir sayı
            double fToDouble = f; // Kapalı (implicit) dönüşüm: float -> double (veri kaybı olmaz)
            Console.WriteLine(fToDouble); // 7.89

            bool boolDeger = true; // bool tipinde bir değer
            string boolToString = boolDeger.ToString(); // bool -> string dönüşümü
            Console.WriteLine(boolToString); // "True"

            string strSayi = "123";
            bool parseBasarili = int.TryParse(strSayi, out int sonuc); // TryParse ile güvenli dönüşüm (hata vermez)
            Console.WriteLine(parseBasarili); // true
            Console.WriteLine(sonuc); // 123

            //=====================

            // Kapalı (implicit) dönüşüm örneği: küçük tipten büyük tipe
            byte kucukSayi = 100;
            int buyukSayi = kucukSayi; // byte -> int (kapalı dönüşüm, veri kaybı olmaz)
            Console.WriteLine(buyukSayi); // 100

            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
