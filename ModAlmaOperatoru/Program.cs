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

// ModAlmaOperatoru adında bir ad alanı tanımlar
namespace ModAlmaOperatoru
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Mod alma operatörü (%) iki sayının bölümünden kalanı bulmak için kullanılır

            int sayi1 = 10; // Birinci sayı
            int sayi2 = 3;  // İkinci sayı

            Console.WriteLine(sayi1 % sayi2); // 10 % 3 işleminin sonucu 1'dir (10'un 3 ile bölümünden kalan)
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
