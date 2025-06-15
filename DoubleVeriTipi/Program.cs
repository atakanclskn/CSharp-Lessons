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

// DoubleVeriTipi adında bir ad alanı tanımlar
namespace DoubleVeriTipi
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // double 8 byte yer kaplar, 15 basamaklı ondalıklı sayılar tutabilir.

            double a = 32.989402312321888838383873737373636366363; // a değişkenine değer atanır
            double b = 4.56575757556433; // b değişkenine değer atanır

            double max = double.MaxValue; // double tipinin alabileceği en büyük değer
            double min = double.MinValue; // double tipinin alabileceği en küçük değer

            Console.WriteLine(a); // a değerini ekrana yazdırır
            Console.WriteLine(b); // b değerini ekrana yazdırır
            Console.WriteLine(min); // min değerini ekrana yazdırır
            Console.WriteLine(max); // max değerini ekrana yazdırır

            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
