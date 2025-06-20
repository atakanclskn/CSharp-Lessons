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

// VeOperatoru adında bir ad alanı tanımlar
namespace VeOperatoru
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // VE (&&) operatörü: İki veya daha fazla koşulun hepsi doğruysa (true) sonuç true olur.
            // Eğer koşullardan biri bile yanlışsa (false) sonuç false olur.

            int yas1 = 5; // Birinci yaş
            int yas2 = 5; // İkinci yaş
            int yas3 = 10; // Üçüncü yaş

            // yas1 == yas2 VE yas1 < yas3 koşulları birlikte kontrol edilir
            // Her iki koşul da doğruysa kontrolEt true olur
            bool kontrolEt = yas1 == yas2 && yas1 < yas3;
            Console.WriteLine(kontrolEt); // Sonucu ekrana yazdırır (true)
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
