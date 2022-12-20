using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaifarik
{
    public static class login
    {
        public static string[] bibla;
        public static string bamboo;

        public static void reg()
        {
            Console.WriteLine("Введите ваше имя");
            bamboo = Console.ReadLine();
           if (bamboo == "")
            {
               
                bibla.Append(bamboo);
                bibla.Append(timer.sim);
                Console.WriteLine(bibla);
                Console.ReadKey();


            }
           
        }
    }
}
