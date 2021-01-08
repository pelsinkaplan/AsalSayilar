using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int kacAsalSayiVar = 0;
            for (int sayi = 2; sayi < 10000; sayi++)
            {
                bool asalMi = true;
                for (int i = 2; i < sayi; i++)
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                if (asalMi == true)
                {
                    Console.Write(sayi + " ");
                    kacAsalSayiVar++;
                }
            }
            Console.WriteLine("\n2 ile 10000 arasında " + kacAsalSayiVar + " tane asal sayı var.");
            Console.ReadKey();
        }
    }
}
