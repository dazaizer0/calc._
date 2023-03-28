using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunkcjeMatematyczne
{

    internal class Program
    {

        static void Main(string[] args)
        {

            #region start
            int x = 9;
            int y = 9;

            Console.Write("[p - punkt] [fl - funkcja liniowa]: ");
            var choice = Console.ReadLine();
            #endregion

            switch (choice)
            {

                case "p":

                    #region punkt
                    Console.Write("x: ");
                    var p_x_v = Console.ReadLine();

                    Console.Write("y: ");
                    var p_y_v = Console.ReadLine();
                    Console.Clear();

                    int p_x = int.Parse(p_x_v);
                    int p_y = int.Parse(p_y_v);

                    while (true)
                    {

                        for (int i = y; i >= -y; i--)
                        {

                            if ( i < 0) { Console.Write(i + " "); }
                            else { Console.Write(i + "  "); }

                            for (int k = -x; k <= x; k++)
                            {

                                if (i == p_y && k == p_x)
                                {

                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write(" P");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (i == 0 && k == 0)
                                {

                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write(" 0");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                                else if (i <= 10 && k == 0)
                                { Console.Write(" Y"); }

                                else if (i == 0 && k <= 10)
                                { Console.Write(" X"); }

                                else
                                { Console.Write(" *"); }
                            }

                            Console.WriteLine();
                        }

                        Thread.Sleep(1080);
                        Console.Clear();
                    }
                #endregion

                case "fl":

                    #region funkcja liniowa
                    Console.WriteLine("y = ax + b");

                    // a = wsp.kierunkowy
                    // b = mj.przeciecia sie z osia y
                    // y = ax + b >> na wykres

                    Console.Write("a: ");
                    var a_v = Console.ReadLine();

                    Console.Write("b: ");
                    var b_v = Console.ReadLine();
                    Console.Clear();

                    int a = int.Parse(a_v);
                    int b = int.Parse(b_v);

                    while (true)
                    {

                        int x_f = 0;

                        for (int j = 0; j <= 9; j++)
                        {
                            x_f = j;

                            Console.WriteLine("funkcja: y = " + a + "x" + " + " + b);
                            int y_f = a * x_f + b;
                            Console.WriteLine("y = " + y_f + " | x = " + x_f);

                            for (int i = y; i >= -y; i--)
                            {

                                if (i < 0) { Console.Write(i + " "); }
                                else { Console.Write(i + "  "); }

                                for (int k = -x; k <= x; k++)
                                {

                                    if (i == y_f && k == x_f)
                                    {

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(" F");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                    else if (i <= 10 && k == 0)
                                    { Console.Write(" Y"); }

                                    else if (i == 0 && k <= 10)
                                    { Console.Write(" X"); }

                                    else
                                    { Console.Write(" *"); }
                                }

                                Console.WriteLine();
                            }
                        }

                        

                        Thread.Sleep(50000);
                        Console.Clear();
                    }
                #endregion

                default:

                    break;
            }
        }
    }
}