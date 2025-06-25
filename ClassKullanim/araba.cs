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
    // araba adında bir sınıf (class) tanımlanır
    public class araba
    {
        // Sınıfın özellikleri (fields/properties)
        public int kapiSayisi;      // Arabanın kapı sayısı
        public string arabaModel;   // Arabanın modeli
        public string arabaRenk;    // Arabanın rengi

        // Yapıcı metot (constructor): Nesne oluşturulurken ilk değerleri atamak için kullanılır
        public araba(int kapiSayisi, string arabaModel, string arabaRenk)
        {
            this.kapiSayisi = kapiSayisi;
            this.arabaModel = arabaModel;
            this.arabaRenk = arabaRenk;
        }

        // Varsayılan (parametresiz) ctor da eklenebilir
        public araba()
        {
        }

        // Sınıfın metotları (davranışları)
        public void kapilariKilitle()
        {
            Console.WriteLine("Kapilar Kilitlendi!"); // Kapıları kilitleme işlemi
        }
        public void motoCalis()
        {
            Console.WriteLine("Motor Calistirildi!"); // Motoru çalıştırma işlemi
        }
    }
}
