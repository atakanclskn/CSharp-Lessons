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

// IcIceForDongusu adında bir ad alanı tanımlar
namespace IcIceForDongusu
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // İç içe for döngüsü: Bir döngü bloğu içinde başka bir for döngüsü kullanılır.
            // Bu yapı genellikle tablo, matris veya desen oluşturmak için kullanılır.

            // Bu örnekte, her satırda 1'den başlayarak satır numarasına kadar olan sayılar yan yana yazdırılır.
            // Çıktı aşağıdaki gibi olur:
            // 1
            // 12
            // 123
            // 1234
            // 12345
            // 123456
            // 1234567
            // 12345678
            // 123456789
            // 12345678910

            for (int i = 1; i <= 10; i++) // Dış döngü: Satırları kontrol eder (1'den 10'a kadar)
            {
                for (int j = 1; j <= i; j++) // İç döngü: Her satırda 1'den i'ye kadar olan sayıları yazar
                {
                    Console.Write(j); // j değerini ekrana yazdırır (aynı satırda)
                }
                Console.WriteLine(""); // Her iç döngüden sonra bir alt satıra geçer
            }
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
