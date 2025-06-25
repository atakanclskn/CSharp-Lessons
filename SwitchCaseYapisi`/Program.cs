using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseYapisi_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal bakiye = 1000m; // Başlangıç bakiyesi

            Console.WriteLine("ATM Uygulamasına Hoşgeldiniz!");
            Console.WriteLine("1 - Bakiye Görüntüle");
            Console.WriteLine("2 - Para Çek");
            Console.WriteLine("3 - Para Yatır");
            Console.WriteLine("4 - Çıkış Yap");
            Console.Write("Lütfen bir işlem seçiniz (1-4): ");

            string secim = Console.ReadLine(); // Kullanıcıdan seçim alınır

            // switch-case yapısı: Bir değişkenin değerine göre farklı kod bloklarının çalışmasını sağlar.
            // Her bir 'case' ifadesi, olası bir değeri temsil eder. 'default' ise hiçbir case eşleşmezse çalışır.
            switch (secim)
            {
                case "1":
                    // Bakiye görüntüle
                    Console.WriteLine("Bakiyeniz: " + bakiye + " TL");
                    break;
                case "2":
                    // Para çek
                    Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                    decimal cekilecekTutar;
                    if (decimal.TryParse(Console.ReadLine(), out cekilecekTutar))
                    {
                        if (cekilecekTutar > 0 && cekilecekTutar <= bakiye)
                        {
                            bakiye -= cekilecekTutar;
                            Console.WriteLine("Para çekildi. Yeni bakiyeniz: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz bakiye veya geçersiz tutar!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş!");
                    }
                    break;
                case "3":
                    // Para yatır
                    Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                    decimal yatirilacakTutar;
                    if (decimal.TryParse(Console.ReadLine(), out yatirilacakTutar))
                    {
                        if (yatirilacakTutar > 0)
                        {
                            bakiye += yatirilacakTutar;
                            Console.WriteLine("Para yatırıldı. Yeni bakiyeniz: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz tutar!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş!");
                    }
                    break;
                case "4":
                    // Çıkış yap
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                default:
                    // Hatalı giriş
                    Console.WriteLine("Hatalı seçim yaptınız! Lütfen 1-2-3-4 arasında bir değer giriniz.");
                    break;
            }

            Console.ReadLine(); // Programın hemen kapanmaması için bekler
        }
    }
}
