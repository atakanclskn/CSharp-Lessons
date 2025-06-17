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

// ArttırmaVe adında bir ad alanı tanımlar
namespace ArttırmaVe
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Arttırma operatörü (++) bir sayının değerini 1 artırır.
            // Azaltma operatörü (--) bir sayının değerini 1 azaltır.

            int sayi1 = 1; // Birinci sayı
            int sayi2 = 2; // İkinci sayı
            int sayi3 = 3; // Üçüncü sayı,
            int sayi4 = 4; // Dördüncü sayı

            sayi1++; // sayi1'in değerini 1 artırır (sayi1 = 2 olur) - Sonra artırma (post-increment)
            sayi2 = ++sayi2; // sayi2'nin değerini önce 1 artırır, sonra atama yapar (sayi2 = 3) - Önce artırma (pre-increment)

            sayi4--; // sayi4'ün değerini 1 azaltır (sayi4 = 3 olur) - Sonra azaltma (post-decrement)
            sayi3 = --sayi3; // sayi3'ün değerini önce 1 azaltır, sonra atama yapar (sayi3 = 2) - Önce azaltma (pre-decrement)

            Console.WriteLine(sayi1); // sayi1'in değerini ekrana yazdırır
            Console.WriteLine(sayi2); // sayi2'nin değerini ekrana yazdırır
            Console.WriteLine(sayi3); // sayi3'ün değerini ekrana yazdırır
            Console.WriteLine(sayi4); // sayi4'ün değerini ekrana yazdırır

            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
