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

// CharVeriTipi adında bir ad alanı tanımlar
namespace CharVeriTipi
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Karakter tutmak için char veri tipi kullanılır
            // Tek tırnak içinde yazılır ''

            char a  = 'a'; // a karakterini tutar
            char t = 't'; // t karakterini tutar
            char k = 'k'; // k karakterini tutar
            char n = 'n'; // n karakterini tutar

            Console.WriteLine(a); // a karakterini ekrana yazdırır
            Console.WriteLine(t); // t karakterini ekrana yazdırır
            Console.WriteLine(a); // a karakterini ekrana yazdırır
            Console.WriteLine(k); // k karakterini ekrana yazdırır
            Console.WriteLine(a); // a karakterini ekrana yazdırır
            Console.WriteLine(n); // n karakterini ekrana yazdırır

            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
