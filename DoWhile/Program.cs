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

// DoWhile adında bir ad alanı tanımlar
namespace DoWhile
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // do-while döngüsü: Döngü bloğu önce bir kez çalışır, sonra koşul kontrol edilir.
            // Koşul sağlandığı sürece döngü devam eder.
            // En az bir kez çalışması garanti edilir.

            // 1'den 10'a kadar sayıları do-while ile yazdırma
            int a = 1;
            do
            {
                Console.WriteLine(a); // a değerini ekrana yazdırır
                a++; // a'yı 1 artırır
            }
            while (a <= 10); // a 10'dan küçük veya eşit olduğu sürece devam eder

            Console.WriteLine(""); // Boş satır

            // while döngüsü: Önce koşul kontrol edilir, koşul doğruysa döngü bloğu çalışır.
            // Koşul baştan sağlanmazsa döngü hiç çalışmayabilir.

            // 1'den 10'a kadar sayıları while ile yazdırma
            int b = 1;
            while (b <= 10)
            {
                Console.WriteLine(b); // b değerini ekrana yazdırır
                b++; // b'yi 1 artırır
            }
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
