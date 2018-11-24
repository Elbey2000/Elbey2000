using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP_3
{
    class Program
    {
        static void Main(string[] args)
        {
        BASADON:
            Console.Clear();
            int a1, a2, a3,sec;
            Console.WriteLine("Qiymet 1 i daxil edin");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qiymet 2 i daxil edin");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qiymet 3 u daxil edin");
            a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Davam etmek isteyirsinizmi?" );
            Console.WriteLine("1-HE 2-YOX");
            sec = Convert.ToInt32(Console.ReadLine());
            if (sec==1)
            {
                goto BASADON;
            }
            else
            {
                Console.WriteLine("Sagliqla qalin");
            }
            Console.ReadKey();




        }
    }
}
