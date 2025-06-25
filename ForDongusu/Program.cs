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

// ForDongusu adında bir ad alanı tanımlar
namespace ForDongusu
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // 1'den 10'a kadar olan sayıları alt alta ekrana yazdıran döngü

            // for döngüsü: Belirli bir koşul sağlandığı sürece kod bloğunu tekrar tekrar çalıştırır.
            // Yapısı: for(başlangıç; koşul; artış)
            // - başlangıç: Döngü değişkeni tanımlanır ve ilk değeri verilir (int x = 1)
            // - koşul: Döngünün devam etme şartı (x <= 10)
            // - artış: Her döngü sonunda değişkenin nasıl değişeceği (x++)
            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(x); // x değerini ekrana yazdırır
            }

            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
