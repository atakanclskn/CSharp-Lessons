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

// ByteProjesi adında bir ad alanı (namespace) tanımlar
namespace ByteProjesi
{
    // Program sınıfı, uygulamanın ana sınıfıdır
    internal class Program
    {
        // Programın başlangıç noktası olan Main metodu
        static void Main(string[] args)
        {
            // birinci adında bir byte değişkeni tanımlar ve 5 değerini atar
            byte birinci = 5;

            // ikinci adında bir byte değişkeni tanımlar ve 25 değerini atar
            byte ikinci = 25;

            // ucuncu adında bir byte değişkeni tanımlar ve 255 değerini atar (byte 0-255 arası değer alır)
            byte ucuncu = 255; // 0 - 255

            // byte tipinin alabileceği en büyük değeri maxDeger değişkenine atar
            byte maxDeger = byte.MaxValue;
            // byte tipinin alabileceği en küçük değeri minDeger değişkenine atar
            byte minDeger = byte.MinValue;

            // birinci değişkeninin değerini ekrana yazdırır
            Console.WriteLine(birinci);
            // ikinci değişkeninin değerini ekrana yazdırır
            Console.WriteLine(ikinci);
            // ucuncu değişkeninin değerini ekrana yazdırır
            Console.WriteLine(ucuncu);

            // maxDeger değişkeninin değerini ekrana yazdırır
            Console.WriteLine(maxDeger);
            // minDeger değişkeninin değerini ekrana yazdırır
            Console.WriteLine(minDeger);
            // Programın hemen kapanmaması için kullanıcıdan bir giriş bekler
            Console.ReadLine();
        }
    }
}
