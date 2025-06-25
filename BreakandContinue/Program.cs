using System;
// Koleksiyonlar için kütüphane
using System.Collections.Generic;
// LINQ işlemleri için kütüphane
using System.Linq;
// Metin işlemleri için kütüphane
using System.Text;
// Çoklu görevler için kütüphane
using System.Threading.Tasks;

// BreakandContinue adında bir ad alanı tanımlar
namespace BreakandContinue
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // break: Döngüyü tamamen sonlandırır ve döngüden çıkar.
            // continue: Döngüde o anki adımı atlar, bir sonraki adıma geçer.

            // 0'dan 10'a kadar olan sayıları yazdırır, i 5 olduğunda o adımı atlar (continue)
            for (int i = 0; i <= 10; i++) 
            {
                if (i == 5)
                { 
                    continue; // i 5 olduğunda bu adımı atla, döngünün başına dön
                }
                Console.WriteLine("i'nin degeri:" + i); // i'nin değerini ekrana yazdır
            }

            Console.WriteLine(""); // Boş satır

            // 0'dan 10'a kadar olan sayıları yazdırır, a 8 olduğunda döngüyü tamamen bitirir (break)
            for (int a = 0; a <= 10; a++)
            {
                if (a == 8)
                { 
                    break; // a 8 olduğunda döngüden çık
                }
                Console.WriteLine("i'nin degeri:" + a); // a'nın değerini ekrana yazdır
            }
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
