using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach dongusu...

            string[] isimler = { "Enes", "Aysun", "Sevcan", "Elif", "Eren" };
            foreach (string i in isimler)
            {
                if (i == "Enes")
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        Console.ReadLine();
        }
    }
}
