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

// KararYapilariIfElse adında bir ad alanı tanımlar
namespace KararYapilariIfElse
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // if-else: Karar yapısıdır. Belirli bir koşulun doğru (true) olup olmadığına göre kodun farklı bölümlerinin çalışmasını sağlar.
            // if (koşul) { ... } : Koşul doğruysa buradaki kodlar çalışır.
            // else { ... } : Koşul yanlışsa buradaki kodlar çalışır.

            int not = 75; // not değişkenine 75 değeri atanır

            if (not > 50) // Eğer not 50'den büyükse
            {
                Console.WriteLine("Ogrenci Basarılı!"); // Bu satır çalışır
                Console.ReadLine();
            }
            else // Eğer not 50'den büyük değilse
            {
                Console.WriteLine("Ogrenci basarili degil!"); // Bu satır çalışır
                Console.ReadLine();
            }
        }
    }
}
