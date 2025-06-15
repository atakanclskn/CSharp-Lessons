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

// StringVeriTipi adında bir ad alanı tanımlar
namespace StringVeriTipi
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // string: Metin veya karakter dizilerini tutmak için kullanılır

            string isim = "Atakan"; // isim değişkenine "Atakan" değeri atanır

            Console.WriteLine(isim); // isim değişkenini ekrana yazdırır
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
