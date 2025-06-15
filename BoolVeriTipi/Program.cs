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

// BoolVeriTipi adında bir ad alanı tanımlar
namespace BoolVeriTipi
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // bool: Doğru (true) veya yanlış (false) değerlerini tutan veri tipidir, genellikle koşul ve karşılaştırmalarda kullanılır

            bool cevap = false; // cevap değişkenine false değeri atanır
            bool cevap2 = true; // cevap2 değişkenine true değeri atanır

            Console.WriteLine("...Bugun okula gitti mi?"); // Soru ekrana yazdırılır
            Console.WriteLine(cevap); // cevap değişkeninin değeri ekrana yazdırılır

            bool sonuc = 10 > 5; // 10 > 5 ifadesinin sonucu true olur ve sonuc değişkenine atanır
            Console.WriteLine(sonuc); // sonuc değişkeninin değeri ekrana yazdırılır
            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
