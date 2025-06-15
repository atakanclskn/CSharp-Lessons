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

// ShortVeriTipi adında bir ad alanı (namespace) tanımlar
namespace ShortVeriTipi
{
    // Program sınıfı, uygulamanın ana sınıfıdır
    internal class Program
    {
        // Programın başlangıç noktası olan Main metodu
        static void Main(string[] args)
        {
            // short değişkeni -32768 ile 32767 arasında değer depolayabilmektedir.
            short a = -50; // a değişkenine -50 değeri atanır
            short b = 25550; // b değişkenine 25550 değeri atanır
            short c = 32000; // c değişkenine 32000 değeri atanır

            // short tipinin alabileceği en büyük değer
            short max = short.MaxValue;
            // short tipinin alabileceği en küçük değer
            short min = short.MinValue;

            // a değişkeninin değerini ekrana yazdırır
            Console.WriteLine(a);
            // b değişkeninin değerini ekrana yazdırır
            Console.WriteLine(b);
            // c değişkeninin değerini ekrana yazdırır
            Console.WriteLine(c);
            // max değişkeninin değerini ekrana yazdırır
            Console.WriteLine(max);
            // min değişkeninin değerini ekrana yazdırır
            Console.WriteLine(min);

            // Programın hemen kapanmaması için kullanıcıdan bir giriş bekler
            Console.ReadLine();
        }
    }
}
