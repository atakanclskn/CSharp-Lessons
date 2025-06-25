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

// Inheritance adında bir ad alanı tanımlar
namespace Inheritance
{
    // Hayvan adında bir temel (base) sınıf tanımlanır
    public class Hayvan
    {
        // Hayvanın adı
        public string isim { get; set; }
        // Hayvanın yaşı
        public int yas { get; set; }

        // Hayvanın ses çıkarma metodu
        public void SesCikar()
        {
            Console.WriteLine("Hayvan ses çıkarıyor.");
        }
    }
}