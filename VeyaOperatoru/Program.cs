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

// VeyaOperatoru adında bir ad alanı tanımlar
namespace VeyaOperatoru
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // VEYA (||) operatörü: İki veya daha fazla koşuldan en az biri doğruysa (true) sonuç true olur.
            // Sadece tüm koşullar yanlışsa (false) sonuç false olur.

            int sayi = 0; // Birinci sayı
            int sayi1 = 0; // İkinci sayı
            int sayi2 = 0; // Üçüncü sayı

            // sayi == sayi1 VEYA sayi1 < sayi2 koşullarından en az biri doğruysa kontrolEt true olur
            bool kontrolEt = sayi == sayi1 || sayi1 < sayi2;
            Console.WriteLine(kontrolEt); // Sonucu ekrana yazdırır (true)
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
