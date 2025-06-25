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

// MetotReturn adında bir ad alanı tanımlar
namespace MetotReturn
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // toplamaYap metodu çağrılır, sonucu cevap değişkenine atanır
            int cevap = toplamaYap(6, 7);
            Console.WriteLine(cevap); // Sonucu ekrana yazdırır

            // stringIsimYaz metodu çağrılır, sonucu isimSonuc değişkenine atanır
            string isimSonuc = stringIsimYaz("Atakan");
            Console.WriteLine(isimSonuc); // Sonucu ekrana yazdırır
        }

        // Parametre alan ve return ile geri dönüş yapan metotlar nedir?
        // Bu tür metotlar, dışarıdan aldığı parametrelerle işlem yapar ve bir değer döndürür.
        // return anahtar kelimesi ile işlem sonucu geri gönderilir.

        // İki int parametre alır, toplar ve sonucu döndürür
        static int toplamaYap(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2; // Toplama işlemi
            return sonuc; // Sonucu geri döndürür
        }

        // Bir string parametre alır, işleyip string olarak geri döndürür
        static string stringIsimYaz(string isim)
        {
            // İsmi büyük harfe çevirip özel bir mesajla döndürür
            string sonuc = "Merhaba, " + isim.ToUpper() + "!";
            return sonuc; // Sonucu geri döndürür
        }
    }
}
