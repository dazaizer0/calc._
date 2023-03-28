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

            int x = 9;
            int y = 9;

            Console.Write("[p - punkt] [fl - funkcja liniowa]: ");
            var choice = Console.ReadLine();

            switch (choice)
            {

                case "p":

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

                case "fl":

                    Console.WriteLine("y = ax + b");

                    // a = wsp.kierunkowy
                    // b = mj.przeciecia sie z osia y
                    // y = ax + b >> na wykres

                    Thread.Sleep(1080);

                    break;

                default:

                    break;
            }
        }
    }
}