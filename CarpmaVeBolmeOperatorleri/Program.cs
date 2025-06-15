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

// CarpmaVeBolmeOperatorleri adında bir ad alanı tanımlar
namespace CarpmaVeBolmeOperatorleri
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Çarpma (*) ve bölme (/) operatörleri: Sayısal değerler üzerinde çarpma ve bölme işlemleri yapmak için kullanılır

            int sayi1 = 4; // Birinci sayı
            int sayi2 = 8; // İkinci sayı
            int sayi3 = 5; // Üçüncü sayı
            int sayi4 = 5; // Dördüncü sayı

            int sonuc1 = (sayi1 * sayi2); // Çarpma işlemi: 4 * 8 = 32
            int sonuc2 = (sayi3 / sayi4); // Bölme işlemi: 5 / 5 = 1 (tam sayı bölmesi)

            Console.WriteLine(sonuc1); // Çarpma sonucunu ekrana yazdırır
            Console.WriteLine(sonuc2); // Bölme sonucunu ekrana yazdırır
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
