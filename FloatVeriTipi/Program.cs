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

// FloatVeriTipi adında bir ad alanı tanımlar
namespace FloatVeriTipi
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // float ondalıklı sayılar için kullanılır, 4 byte yer kaplar

            float ondalikliSayi = 35.56f; // ondalikliSayi'ya değer atanır

            float ondalikliSayi2 = 12.5f; // ondalikliSayi2'ye değer atanır

            Console.WriteLine(ondalikliSayi); // ilk sayıyı ekrana yazdırır
            Console.WriteLine(ondalikliSayi2); // ikinci sayıyı ekrana yazdırır

            float max = float.MaxValue; // float tipinin alabileceği en büyük değer
            Console.WriteLine(max); // max değeri ekrana yazdırır

            float min = float.MinValue; // float tipinin alabileceği en küçük değer
            Console.WriteLine(min); // min değeri ekrana yazdırır

            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
