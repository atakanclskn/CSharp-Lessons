using System;
// Koleksiyonlar için kütüphane
using System.Collections.Generic;
// LINQ işlemleri için kütüphane
using System.Linq;
// Metin işlemleri için kütüphane
using System.Text;
// Çoklu görevler için kütüphane
using System.Threading.Tasks;

// AtamaOperatoru adında bir ad alanı tanımlar
namespace AtamaOperatoru
{
    // Program sınıfı
    internal class Program
    {
        // Programın başlangıç noktası
        static void Main(string[] args)
        {
            // Atama operatörü (=): Sağdaki değeri soldaki değişkene atar
            // Örnek: değişken = değer şeklinde kullanılır
            
            int yas = 21; // yas değişkenine 21 değeri atanır
            
            // Diğer atama operatörleri:
            // += : Değişkene sağdaki değeri ekler ve sonucu değişkene atar (x += 5 demek x = x + 5 demektir)
            // -= : Değişkenden sağdaki değeri çıkarır ve sonucu değişkene atar
            // *= : Değişkeni sağdaki değerle çarpar ve sonucu değişkene atar
            // /= : Değişkeni sağdaki değere böler ve sonucu değişkene atar
            // %= : Değişkenin sağdaki değere bölümünden kalanı değişkene atar
        }
    }
}
