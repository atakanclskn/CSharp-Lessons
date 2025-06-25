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

// DizilerGiris adında bir ad alanı tanımlar
namespace DizilerGiris
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Dizi (Array) nedir?
            // Dizi, aynı türden birden fazla veriyi tek bir değişkende saklamamıza olanak sağlar.
            // Dizi elemanlarına indeks numarası ile erişilir. (İndeksler 0'dan başlar)

            int[] sayilar = new int[4]; // 4 elemanlı bir int dizisi tanımlanır

            sayilar[0] = 10; // 0. indeks: 10
            sayilar[1] = 20; // 1. indeks: 20
            sayilar[2] = 30; // 2. indeks: 30
            sayilar[3] = 40; // 3. indeks: 40

            // for döngüsü ile dizinin tüm elemanları ekrana yazdırılır
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]); // Her bir elemanı ekrana yazdırır
            }

            // string dizi örneği
            string[] isimler = new string[3]; // 3 elemanlı bir string dizisi
            isimler[0] = "Ali";
            isimler[1] = "Veli";
            isimler[2] = "Ayşe";

            Console.WriteLine("String dizi örneği:");
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]); // Her bir ismi ekrana yazdırır
            }

            // double dizi örneği
            double[] notlar = new double[4]; // 4 elemanlı bir double dizisi
            notlar[0] = 85.5;
            notlar[1] = 90.0;
            notlar[2] = 78.25;
            notlar[3] = 60.75;

            Console.WriteLine("Double dizi örneği:");
            for (int i = 0; i < notlar.Length; i++)
            {
                Console.WriteLine(notlar[i]); // Her bir notu ekrana yazdırır
            }

            // char dizi örneği
            char[] harfler = new char[5]; // 5 elemanlı bir char dizisi
            harfler[0] = 'A';
            harfler[1] = 'B';
            harfler[2] = 'C';
            harfler[3] = 'D';
            harfler[4] = 'E';

            Console.WriteLine("Char dizi örneği:");
            for (int i = 0; i < harfler.Length; i++)
            {
                Console.WriteLine(harfler[i]); // Her bir harfi ekrana yazdırır
            }

            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
