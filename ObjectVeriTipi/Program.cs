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

// ObjectVeriTipi adında bir ad alanı tanımlar
namespace ObjectVeriTipi
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            int a = 1; // int tipinde bir değişken
            //int b = "enes"; // Hatalı: int değişkenine string atanamaz
            string y = "enes"; // string tipinde bir değişken

            // object: C#'ta tüm veri tiplerinin temelidir (en üstteki tiptir). Her türlü veri tipini tutabilir.
            object x = "enes"; // string değer tutar
            object u = true; // bool değer tutar
            object v = false; // bool değer tutar
            object p = 6.443; // double değer tutar
        }
    }
}
