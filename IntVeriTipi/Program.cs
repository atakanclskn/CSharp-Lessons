using System;
// Koleksiyonlar için kütüphane
using System.Collections.Generic;
// LINQ işlemleri için kütüphane
using System.Linq;
// Metin işlemleri için kütüphane
using System.Text;
// Çoklu görevler için kütüphane
using System.Threading.Tasks;

// IntVeriTipi adında bir ad alanı tanımlar
namespace IntVeriTipi
{
    // Program sınıfı, uygulamanın ana sınıfıdır
    internal class Program
    {
        // Programın başlangıç noktası olan Main metodu
        static void Main(string[] args)
        {
            // int veri tipi -2.147.483.648 ile 2.147.483.647 arasında değer alabilir

            int birinciDegisken = 150000; // birinciDegisken'e 150000 değeri atanır

            int ikinciDegisken = -500000; // ikinciDegisken'e -500000 değeri atanır

            int max = int.MaxValue; // int tipinin alabileceği en büyük değer
            int min = int.MinValue; // int tipinin alabileceği en küçük değer

            Console.WriteLine(birinciDegisken); // birinciDegisken'i ekrana yazdırır
            Console.WriteLine(ikinciDegisken); // ikinciDegisken'i ekrana yazdırır

            Console.WriteLine(max); // max değerini ekrana yazdırır
            Console.WriteLine(min); // min değerini ekrana yazdırır

            Console.ReadLine(); // Programın hemen kapanmaması için kullanıcıdan giriş bekler
        }
    }
}
