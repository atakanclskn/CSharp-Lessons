using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cevap = toplamaYap(6, 7);
            Console.WriteLine(cevap);
        }

        static int toplamaYap(int sayi1, int sayi2)
        {
            int sonuc = sayi1+sayi2;
            return sonuc;
        }
    }
}
