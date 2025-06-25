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

// Metotlar adında bir ad alanı tanımlar
namespace Metotlar
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Metot çağrısı: SelamVer metodunu çalıştırır
            SelamVer();
            // Metot çağrısı: AdYaz metodunu çalıştırır
            AdYaz();
        }

        // Metot (Method) nedir?
        // Metotlar, belirli bir görevi yerine getiren ve gerektiğinde tekrar tekrar çağrılabilen kod bloklarıdır.
        // Kodun tekrarını önler, okunabilirliği ve bakımı kolaylaştırır.

        static void SelamVer()
        {
            // Bu metot ekrana "SELAM" yazar
            Console.WriteLine("SELAM");
            Console.ReadLine();
        }

        static void AdYaz()
        {
            // Bu metot ekrana "Atakan" yazar
            Console.WriteLine("Atakan");
        }

    }
}
