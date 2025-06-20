using System;
// Koleksiyonlar için kütüphane
using System.Collections.Generic;
// LINQ işlemleri için kütüphane
using System.Linq;
// Metin işlemleri için kütüphane
using System.Text;
// Çoklu görevler için kütüphane
using System.Threading.Tasks;

// BuyukturVeBuyukesitOperatorleri adında bir ad alanı tanımlar
namespace BuyukturVeBuyukesitOperatorleri
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Büyüktür operatörü (>): Soldaki değerin sağdakinden büyük olup olmadığını kontrol eder.
            // Büyük eşit operatörü (>=): Soldaki değerin sağdakine eşit veya büyük olup olmadığını kontrol eder.
            // Her iki operatör de karşılaştırma sonucunda true (doğru) veya false (yanlış) döner.

            int yas = 12; // yas değişkenine 12 değeri atanır

            bool kontrolEt = yas > 12; // yas 12'den büyük mü? Sonuç: false
            Console.WriteLine(kontrolEt); // Sonucu ekrana yazdırır (false)

            bool kontrolEt2 = yas >= 12; // yas 12'ye eşit veya büyük mü? Sonuç: true
            Console.WriteLine(kontrolEt2); // Sonucu ekrana yazdırır (true)

            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
