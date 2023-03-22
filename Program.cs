using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            a1:
            Console.WriteLine("10 haneli sayı giriniz: ");
            UInt64 s = Convert.ToUInt64(Console.ReadLine());
            int sayac = 0;
            if (sayac < 11)
            {
                while (s > 0)
                {
                    s /= 10;
                    sayac++;
                }

                Console.WriteLine("Girilen sayıda  " + sayac + " hane vardır.");
            }
            if (sayac > 10)
            {
                Console.WriteLine("Fazla sayı girdiniz");
                Console.WriteLine("10 haneli sayı giriniz: ");
                goto a1;
            }
        }

    }
}
