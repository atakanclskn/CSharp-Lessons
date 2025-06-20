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

// EsitDegildirOperatoru adında bir ad alanı tanımlar
namespace EsitDegildirOperatoru
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Eşit değildir operatörü (!=): İki değerin birbirine eşit olup olmadığını kontrol eder.
            // Eğer değerler eşit değilse true (doğru), eşitse false (yanlış) döner.

            int sayi1 = 1; // Birinci sayı
            int sayi2 = 0; // İkinci sayı

            bool kontrolEt = sayi1 != sayi2; // sayi1 ve sayi2 eşit değil mi? Sonuç: true
            Console.WriteLine(kontrolEt); // Sonucu ekrana yazdırır (true)
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
