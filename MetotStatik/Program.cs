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
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Normal (instance) metot çağrısı için önce bir nesne oluşturmak gerekir
            personel p1 = new personel();
            p1.isimSoyisimYazdir(); // Nesne üzerinden çağrılır

            // Statik metot ise doğrudan sınıf adı ile çağrılır, nesne oluşturmaya gerek yoktur
            personel.staticisimsoyisim();
        }
    }
}
