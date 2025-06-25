using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while döngüsü: Belirli bir koşul doğru olduğu sürece kod bloğunu tekrar tekrar çalıştırır.
            // Kullanıcıdan sayı alıp, sayı çift olduğu sürece "Sayi cift" mesajı yazdırır.

            Console.WriteLine("Sayı giriniz:");
            string k = Console.ReadLine(); // Kullanıcıdan giriş alınır
            int sayi = Convert.ToInt32(k); // Girilen değer int'e dönüştürülür

            // while döngüsü: Koşul doğru olduğu sürece döngü devam eder
            while (sayi % 2 == 0) // sayı çift olduğu sürece
            {
                Console.WriteLine("Sayi cift"); // Ekrana mesaj yazdırılır
                Console.WriteLine("Yeni bir sayı giriniz:");
                k = Console.ReadLine(); // Yeni giriş alınır
                sayi = Convert.ToInt32(k); // Yeni değer int'e dönüştürülür
            }

            // Döngüden çıkınca program biter
        }
    }
}
