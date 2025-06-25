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

// MetotStatik adında bir ad alanı tanımlar
namespace MetotStatik
{
    // personel sınıfı
    internal class personel
    {
        // Normal (instance) metot: Sadece nesne üzerinden çağrılabilir
        public void isimSoyisimYazdir()
        {
            Console.WriteLine("Atakan Caliskan");
        }

        // Statik (static) metot: Sınıf adı üzerinden doğrudan çağrılabilir, nesne oluşturmaya gerek yoktur
        public static void staticisimsoyisim()
        {
            Console.WriteLine("Atakan Statik");
        }
    }
}
