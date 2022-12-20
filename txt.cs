using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kaifarik
{
    public class txt
    {
        public static ConsoleKeyInfo key = Console.ReadKey();

        public static string text = "вдруг потом очень от же думать каждый наш просить главный идти за где для пока еще очень ни уже работать очень работа какой казаться сразу";
        public static string text1 = "должный самый чтобы уже раз ведь работать просто без спросить посмотреть об понять и над голос где о год ответить кто твой понять быть а";
        public static string text2 = "же лишь когда спросить по понять сила слово стоять о ни опять они теперь если тогда есть что бы земля тут главный говорить понять ничто";
        /*     public static Random cazino = new Random();*/
        /*        public static string[] arc = { text, text1, text2 };*/
        public static char[] spliter = text.ToCharArray();
        public static char[] spliter1 = text1.ToCharArray();
        public static char[] spliter2 = text2.ToCharArray();
        public static string[] words;
        public static string selectedText = "";
        public static List<char> green;
        public static List<char> red;
        public static int currentNum = 0;
        public static void kazino()
        {
            /*            Console.WriteLine(arc[new Random().Next(0, arc.Length)]);*/
            Console.WriteLine(spliter);



        }
        public static void pot()
        {
            Thread potok = new Thread(_ =>
            {
                timer.timing();
            });
            potok.Start();
            Console.ReadKey();
        }
        public static void cheacker()

        {
            Console.SetCursorPosition(0, 0);

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.F1)
            {
                
                selectedText = text;
                Console.WriteLine(spliter);
                /*timer.timing();*/



            }
            if (key.Key == ConsoleKey.F2)
            {
                selectedText = text1;
                Console.WriteLine(spliter1);
                /*timer.timing();*/

            }
            if (key.Key == ConsoleKey.F3)
            {
                selectedText = text2;

                Console.WriteLine(spliter2);
                /* timer.timing();*/
            }
            /*            if (key.Key == ConsoleKey.F4)
                        {
                            Console.Clear();
                            login.reg();
                        }*/
          
            
            pot();

            write();
            login.reg();
            timer.simi();

        }
        public static void write()
        {
            Console.SetCursorPosition(0, 0);

            while (key.Key != ConsoleKey.Escape)
            {

                ConsoleKeyInfo knopa = Console.ReadKey(true);
                if (knopa.Key == ConsoleKey.Backspace)
                {
                    currentNum--;

                    /* knopa = knopa.ToCharArray();*/
                }
                if (knopa.KeyChar == selectedText[currentNum])

                {
                    currentNum++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, 0);
                    for (int i = 0; i < currentNum; i++)
                    {
                        Console.Write(selectedText[i]);
                        
                    }

                    Console.ForegroundColor = ConsoleColor.White;

                }
/*                if (key.Key == ConsoleKey.F5)
                {
                    Console.Clear();
                    timer.aTimer.Stop();
                    timer.sim = "кол во символом в минуту" + timer.sec / 60;
                    Console.ReadLine();
                }*/
                /*                if (knopa.KeyChar != selectedText[currentNum])
                                {
                                    login.reg();
                                }*/

                /*  else
                  {

                      Console.ForegroundColor = ConsoleColor.Red;
                  }*/

            }

        }
              




    }
}
