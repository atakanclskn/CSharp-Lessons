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

// LongVeriTipi adında bir ad alanı tanımlar
namespace LongVeriTipi
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // long veri tipi büyük tam sayılar için kullanılır

            long x = 1700505055343; // x değişkenine değer atanır
            long y = 5750000000000000; // y değişkenine değer atanır
            long c = -7655434535; // c değişkenine negatif değer atanır

            long max = long.MaxValue; // long tipinin alabileceği en büyük değer
            long min = long.MinValue; // long tipinin alabileceği en küçük değer

            Console.WriteLine(x); // x değerini ekrana yazdırır
            Console.WriteLine(y); // y değerini ekrana yazdırır
            Console.WriteLine(c); // c değerini ekrana yazdırır
            Console.WriteLine(max); // max değerini ekrana yazdırır
            Console.WriteLine(min); // min değerini ekrana yazdırır
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
