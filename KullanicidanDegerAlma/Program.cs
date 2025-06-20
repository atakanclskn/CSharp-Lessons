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

// KullanicidanDegerAlma adında bir ad alanı tanımlar
namespace KullanicidanDegerAlma
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Kullanıcıdan değer almak için Console.ReadLine() metodu kullanılır.
            // Kullanıcıdan alınan değerler string (metin) olarak saklanır.

            Console.WriteLine("Lütfen adınızı giriniz:"); // Kullanıcıya adını sormak için mesaj gösterilir
            string isim = Console.ReadLine(); // Kullanıcıdan alınan ad, isim değişkenine atanır

            Console.WriteLine("Lütfen soyisim giriniz:"); // Kullanıcıya soyadını sormak için mesaj gösterilir
            string soyisim = Console.ReadLine(); // Kullanıcıdan alınan soyad, soyisim değişkenine atanır

            Console.WriteLine("Kullanıcının ismi: " + isim); // Girilen isim ekrana yazdırılır
            Console.WriteLine("Kullanıcının soyismi: " + soyisim); // Girilen soyisim ekrana yazdırılır
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
