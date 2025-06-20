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

// KucukturVeKucukesittirOperatoru adında bir ad alanı tanımlar
namespace KucukturVeKucukesittirOperatoru
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Küçüktür operatörü (<): Soldaki değerin sağdakinden küçük olup olmadığını kontrol eder.
            // Küçük eşit operatörü (<=): Soldaki değerin sağdakine eşit veya küçük olup olmadığını kontrol eder.
            // Her iki operatör de karşılaştırma sonucunda true (doğru) veya false (yanlış) döner.

            int yas = 18; // yas değişkenine 18 değeri atanır

            bool sonuc = yas < 18; // yas 18'den küçük mü? Sonuç: false
            bool sonuc2 = yas <= 18; // yas 18'e eşit veya küçük mü? Sonuç: true

            Console.WriteLine(sonuc); // sonuc değerini ekrana yazdırır (false)
            Console.WriteLine(sonuc2); // sonuc2 değerini ekrana yazdırır (true)
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
