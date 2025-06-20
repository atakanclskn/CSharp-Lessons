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

// DegilOperatoru adında bir ad alanı tanımlar
namespace DegilOperatoru
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Değil operatörü (!) bir boolean değerin tersini (negation) alır.
            // true ise false, false ise true yapar.

            bool a = true; // a değişkenine true değeri atanır
            Console.WriteLine(!a); // !a ifadesi a'nın tersini alır (true ise false yazdırır)
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
