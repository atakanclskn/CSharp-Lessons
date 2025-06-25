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

// ClassKullanim adında bir ad alanı tanımlar
namespace ClassKullanim
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // araba sınıfından (class) bir nesne oluşturulur
            araba doblo = new araba();
            doblo.arabaRenk = "Pembe"; // Nesnenin arabaRenk özelliği atanır
            doblo.arabaModel = "2003"; // Nesnenin arabaModel özelliği atanır
            doblo.kapiSayisi = 5;      // Nesnenin kapiSayisi özelliği atanır

            doblo.kapilariKilitle(); // Nesnenin kapilariKilitle metodu çağrılır
            doblo.motoCalis();       // Nesnenin motoCalis metodu çağrılır

            // Nesnenin özellikleri ekrana yazdırılır
            Console.WriteLine("Araba Model: " + doblo.arabaModel);
            Console.WriteLine("Arabanin rengi: " + doblo.arabaRenk);
            Console.WriteLine("Araba kac kapili: " + doblo.kapiSayisi);

            araba doblo2 = new araba(5, "2003", "Pembe");

        }
    }
}
