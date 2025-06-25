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

// PublicPrivateErisimBelirleyiciler adında bir ad alanı tanımlar
namespace PublicPrivateErisimBelirleyiciler
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // public ve private erişim belirleyicileri nedir?
            // public: Sınıfın dışından erişilebilen alan, metot veya özelliklerdir.
            // private: Sadece tanımlandığı sınıf içinde erişilebilen alan, metot veya özelliklerdir.

            Musteri musteri1 = new Musteri(); // Musteri sınıfından bir nesne oluşturulur

            musteri1.isim = "Atakan";      // public alan: dışarıdan erişilebilir
            musteri1.surname = "Caliskan"; // public alan: dışarıdan erişilebilir
            musteri1.maas = 6636;          // public alan: dışarıdan erişilebilir
            musteri1.sex = "E";            // public alan: dışarıdan erişilebilir
            // musteri1.yas;               // private alan: dışarıdan erişilemez (hata verir)
        }
    }
}