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

            Console.WriteLine("10 haneli sayı giriniz: ");
            
            int s = Convert.ToInt32(Console.ReadLine());
            
            int sayac = 0;


            if (sayac>11)
            {
                Console.WriteLine("Fazla sayı girdiniz");
                Console.WriteLine("10 haneli sayı giriniz: ");
            }


            else
            {
        

                while (s > 0)
                {
                    s /= 10;
                    sayac++;
                }

                Console.WriteLine("Girilen sayıda  " + sayac + " hane vardır.");
            }

            Console.ReadKey();

        }
        
    }
}
