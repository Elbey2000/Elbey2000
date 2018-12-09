using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace CONSOLE_APP_3
{

    public class Program
    {
        public static void Main(string[] args)
        {
            BAWADON:
            Console.WriteLine("Birinci ededi daxil edin");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci  ededi daxil edin");
            int r2 = Convert.ToInt32(Console.ReadLine());

        

            Console.WriteLine("Zehmet olmasa secim edin");
            Console.WriteLine("1-Toplama, 2-Cixma, 3-Vurma 4-Bolme");
            char secim = Convert.ToChar(Console.ReadLine());
            
            switch (secim)
            {
                case '1':
                    double cem = hesablama.toplama(r1, r2);
                    Console.WriteLine("Cavab: {0}", cem);
                    break;
                case '2':
                    double cem1 = hesablama.cixma(r1, r2);
                   
                    Console.WriteLine("Cavab: {0}", cem1);
                    break;
                case '3':
                    
                    double cem2 = hesablama.vurma(r1, r2);
                    Console.WriteLine("Cavab: {0}", cem2);
                    break;

                case '4':
                    double cem4 = hesablama.bolme(r1, r2);
         
                    Console.WriteLine("Cavab: {0}", cem4);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Secim duzgun deyil yeniden secim edin");
                    goto BAWADON;
                    break;
 }
            Console.ReadKey();         
            int sec;
            Console.WriteLine("Davam etmek isteyirsiniz");
            Console.WriteLine("1-he , 2-yox");
            sec = Convert.ToInt32(Console.ReadLine());
            if (sec == 1)
            {
                goto BAWADON;   
            }
            else
           {
                Console.WriteLine("Xidmetden istifade etdiyiniz ucun tewekkurler");
           }

            Console.ReadKey();
        }
    }
    public class hesablama
    {
        public static int toplama(int a, int b)
        {
            int cavab = (a + b);
            return (cavab);
        }
        public static int cixma(int a, int b)
        {
            int cavab = (a - b);
            return (cavab);
        }
        public static int vurma(int a, int b)
        {
            int cavab = (a * b);
            return (cavab);
        }
        public static int bolme(int a, int b)
        {
            int cavab = (a / b);
            return (cavab);
        }


    }
                              
    
}
    
    

