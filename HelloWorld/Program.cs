// Gerekli sistem kütüphanelerini ekler
using System;
// Koleksiyonlar için kütüphane
using System.Collections.Generic;
// LINQ sorguları için kütüphane
using System.Linq;
// Metin işlemleri için kütüphane
using System.Text;
// Çoklu görevler için kütüphane
using System.Threading.Tasks;

// HelloWorld adında bir ad alanı (namespace) tanımlar
namespace HelloWorld
{
    // Program sınıfı, uygulamanın ana sınıfıdır
    internal class Program
    {
        // Programın başlangıç noktası olan Main metodu
        static void Main(string[] args)
        {
            // Konsola "HELLO WORLD!" yazdırır ve alt satıra geçer
            Console.WriteLine("HELLO WORLD!");

            // Konsola "Atakan" yazdırır, alt satıra geçmez
            Console.Write("Atakan");
            // Konsola "Çalışkan" yazdırır, alt satıra geçmez
            Console.Write("Çalışkan");

            // Kullanıcıdan bir giriş bekler, program hemen kapanmaz
            Console.ReadLine();
        }
    }
}
