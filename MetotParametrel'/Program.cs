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

// MetotParametrel_ adında bir ad alanı tanımlar
namespace MetotParametreli
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Kullanıcıdan iki sayı alınır
            Console.WriteLine("Lutfen 1. sayiyi giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine()); // 1. sayı alınır
            Console.WriteLine("Lutfen 2. sayiyi giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine()); // 2. sayı alınır

            // Parametreli metot çağrılır ve a, b değerleri gönderilir
            toplamaYap(a, b);
            carpmaYap(a, b);
        }

        // Parametreli metot nedir?
        // Parametreli metotlar, dışarıdan değer alabilen ve bu değerlerle işlem yapabilen metotlardır.
        // Metot tanımında parantez içinde belirtilen değişkenlere "parametre" denir.
        // Çağrılırken bu parametrelere uygun değerler (argümanlar) gönderilir.

        static void toplamaYap(int sayi1, int sayi2)
        {
            // Gönderilen iki sayının toplamını ekrana yazdırır
            Console.WriteLine("Gonderilen sayilarin toplami = " + (sayi1 + sayi2));

        }
        static void carpmaYap(int sayi3, int sayi4)
        {

            Console.WriteLine("Gonderilen sayilarin carpimi = " + (sayi3 * sayi4));
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
