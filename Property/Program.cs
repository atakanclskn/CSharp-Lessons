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

// Property adında bir ad alanı tanımlar
namespace Property
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Musteri sınıfından bir nesne oluşturulur
            Musteri musteri1 = new Musteri();

            // Property (özellik) üzerinden değer ataması yapılır
            musteri1.KILO = 88; // set bloğu çalışır
            Console.WriteLine(musteri1.KILO); // get bloğu çalışır ve ekrana yazdırılır
        }
    }
}
