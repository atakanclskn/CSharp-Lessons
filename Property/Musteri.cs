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

// Property adında bir ad alanı tanımlar
namespace Property
{
    // Musteri sınıfı
    public class Musteri
    {
        // Alan (field) genellikle private olarak tanımlanır
        private int kilo;

        // Property (özellik): Alanlara kontrollü erişim sağlar
        // get: Değeri okumak için kullanılır
        // set: Değeri değiştirmek için kullanılır
        public int KILO
        {
            get
            {
                return kilo; // kilo değerini döndürür
            }
            set
            {
                // Değer negatifse 0 olarak ayarlanır, değilse gelen değer atanır
                if (value < 0)
                    kilo = 0;
                else
                    kilo = value;
            }
        }
    }
}
