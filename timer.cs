using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Kaifarik
{
   public static class timer
   {





        public static Timer aTimer;
        public static int sec = 0;
        public static ConsoleKeyInfo kyu = Console.ReadKey();
        public static string sim;
        public static void timing()
        {
           


                aTimer = new System.Timers.Timer();
                aTimer.Interval = 1000;


                aTimer.Elapsed += OnTimedEvent;


                aTimer.AutoReset = true;


                aTimer.Enabled = true;
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("|------------------------------------------------------------------------------------|");
                Console.WriteLine("Жмакните Enter что бы остановить таймер , F5 что бы сохранить резу ");
                Console.WriteLine("|____________________________________________________________________________________|");
                Console.ReadLine();
            
        }


        public static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            sec++;
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("|---------|");
            Console.WriteLine(" 00:{0}", sec);
            Console.WriteLine("|_________|");

            if (sec >= 60)
            {
                aTimer.Stop();
                Console.WriteLine("Время закончилось");
                Console.WriteLine(sec);

            }
        }

        public static void simi()
        {


            if (kyu.Key == ConsoleKey.F5)
            {

                aTimer.Stop();
                sim = "кол во символом в минуту" + sec / 60;
                Console.ReadKey();
            }
        }



        


    }
}

