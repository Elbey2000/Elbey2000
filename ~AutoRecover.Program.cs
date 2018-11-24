using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_BEST_APPLICATION
{
    class Program
    {
        static void Main(string[] args)
        {
            int texmin;
            Random a = new Random();
            int s1 = a.Next(1, 20);
            Console.WriteLine("Random secilmis reqem: {0}", s1);
            int haqq = 3;
            BASADON:
            Console.WriteLine("Bir reqem daxil edin");
            texmin =Convert.ToInt32(Console.ReadLine());
            
            if(texmin == s1)
            {
                Console.WriteLine("Tebrikler size bu qeder xal verildi: {0}", haqq*10);
                
            }

            else if (texmin <s1)
            {
                haqq--;
                if (haqq==0)
                {
                    Console.WriteLine("Siz oyunnan xaric oldunuz");

                }
                else
                {
                    Console.WriteLine("Rerqemi boyudun");
                    goto BASADON;
                }
                
            }
            else if ( texmin > s1)
            {
                haqq--;
                if (haqq==0)
                {
                    Console.WriteLine("proqram bitti");
                }
                else
                {
                    Console.WriteLine("Reqemi kicildin");
                    goto BASADON;
                }
            }
            Console.ReadKey();
        }
    }
}
