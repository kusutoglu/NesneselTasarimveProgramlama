using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    public class Ev
    {

        public string sokakAdi;

        public void sokak_ismi_ne(string a)
        {
            sokakAdi = a;
        }

        public int kapiNo;

        public void kapi_numarasi_ne(int b)
        {
            kapiNo = b;

        }
        public void ekrana_yaz()
        {
            Console.WriteLine("Adres: " + sokakAdi);
            Console.WriteLine("NO: " + kapiNo);
        }
    }
        class Program
    {
        static void Main(string[] args)
        {

                Ev ilkev = new Ev();
                Ev ikinciev = new Ev();
                Ev ucuncuev = new Ev();

                ilkev.sokak_ismi_ne("Menekşe Sokak");
                ilkev.kapi_numarasi_ne(123);
                ilkev.ekrana_yaz();

                ikinciev.sokak_ismi_ne("Yasemin Sokak");
                ikinciev.kapi_numarasi_ne(456);
                ikinciev.ekrana_yaz();

                ucuncuev.sokak_ismi_ne("Menekşe Sokak");
                ucuncuev.kapi_numarasi_ne(123);
                ucuncuev.ekrana_yaz();

                Console.ReadKey();




            }
    }
}
