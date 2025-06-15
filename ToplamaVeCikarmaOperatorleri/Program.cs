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

// ToplamaVeCikarmaOperatorleri adında bir ad alanı tanımlar
namespace ToplamaVeCikarmaOperatorleri
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Toplama (+) ve çıkarma (-) operatörleri: Sayısal değerler üzerinde toplama ve çıkarma işlemleri yapmak için kullanılır

            int sayi1 = 5; // Birinci sayı
            int sayi2 = 12; // İkinci sayı
            int sayi3 = 13; // Üçüncü sayı

            int sonuc = sayi1 + sayi2; // Toplama işlemi: 5 + 12 = 17

            int sonuc2 = sayi1 - sayi3; // Çıkarma işlemi: 5 - 13 = -8

            Console.WriteLine(sonuc); // Toplama sonucunu ekrana yazdırır
            Console.WriteLine(sonuc2); // Çıkarma sonucunu ekrana yazdırır
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
