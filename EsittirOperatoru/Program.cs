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

// EsittirOperatoru adında bir ad alanı tanımlar
namespace EsittirOperatoru
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Eşittir operatörü (==): İki değerin birbirine eşit olup olmadığını kontrol eder.
            // Sonuç olarak true (doğru) veya false (yanlış) döner.

            int sayi1 = 5; // Birinci sayı
            int sayi2 = 4; // İkinci sayı

            bool kontrolEt = sayi1 == sayi2; // sayi1 ve sayi2 eşit mi? Sonuç: false
            Console.WriteLine(kontrolEt); // Sonucu ekrana yazdırır (false)
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
