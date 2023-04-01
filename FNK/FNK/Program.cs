using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FNK
{

    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Podaj a i b funkcji liniowej: ");
            Console.Write("a: ");
            var av = Console.ReadLine();
            int a = int.Parse(av);

            Console.Write("b: ");
            var bv = Console.ReadLine();
            int b = int.Parse(bv);

            Console.Clear();


            Console.WriteLine("Podaj ponkt x i y do zaznaczenia: ");
            Console.Write("x: ");
            var xv = Console.ReadLine();
            int p_x = int.Parse(xv);

            Console.Write("y: ");
            var yv = Console.ReadLine();
            int p_y = int.Parse(yv);

            Console.Clear();

            int x = 9, y = 9;

            int m0x = 0;
            int m0y = 0;

            int fx0 = 0;
            int fx1 = 1;
            int fx2 = 2;
            int fx3 = 3;
            int fx4 = 4;
            int fx5 = 5;
            int fx6 = 6;
            int fx7 = 7;
            int fx8 = 8;
            int fx9 = 9;

            int fxm0 = -fx0;
            int fxm1 = -fx1;
            int fxm2 = -fx2;
            int fxm3 = -fx3;
            int fxm4 = -fx4;
            int fxm5 = -fx5;
            int fxm6 = -fx6;
            int fxm7 = -fx7;
            int fxm8 = -fx8;
            int fxm9 = -fx9;


            int fy0 = a * fx0 + b;
            int fy1 = a * fx1 + b;
            int fy2 = a * fx2 + b;
            int fy3 = a * fx3 + b;
            int fy4 = a * fx4 + b;
            int fy5 = a * fx5 + b;
            int fy6 = a * fx6 + b;
            int fy7 = a * fx7 + b;
            int fy8 = a * fx8 + b;
            int fy9 = a * fx9 + b;

            if(a == 1 && b == 1 || b == 0)
            {
                fy0 = fy0 - 1;
                fy1 = fy1 - 1;
                fy2 = fy2 - 1;
                fy3 = fy3 - 1;
                fy4 = fy4 - 1;
                fy5 = fy5 - 1;
                fy6 = fy6 - 1;
                fy7 = fy7 - 1;
                fy8 = fy8 - 1;
                fy9 = fy9 - 1;
            }

            int fym0 = -fy0;
            int fym1 = -fy1;
            int fym2 = -fy2;
            int fym3 = -fy3;
            int fym4 = -fy4;
            int fym5 = -fy5;
            int fym6 = -fy6;
            int fym7 = -fy7;
            int fym8 = -fy8;
            int fym9 = -fy9;


            Console.WriteLine("y = " + a + "x + " + b);

            Console.WriteLine("x : " + fx0 + ": y : " + fy0);
            Console.WriteLine("x : " + fx1 + ": y : " + fy1);
            Console.WriteLine("x : " + fx2 + ": y : " + fy2);
            Console.WriteLine("x : " + fx3 + ": y : " + fy3);
            Console.WriteLine("x : " + fx4 + ": y : " + fy4);
            Console.WriteLine("x : " + fx5 + ": y : " + fy5);
            Console.WriteLine("x : " + fx6 + ": y : " + fy6);
            Console.WriteLine("x : " + fx7 + ": y : " + fy7);
            Console.WriteLine("x : " + fx8 + ": y : " + fy8);
            Console.WriteLine("x : " + fx9 + ": y : " + fy9);

            Console.WriteLine("x : " + fxm0 + ": y : " + fym0);
            Console.WriteLine("x : " + fxm1 + ": y : " + fym1);
            Console.WriteLine("x : " + fxm2 + ": y : " + fym2);
            Console.WriteLine("x : " + fxm3 + ": y : " + fym3);
            Console.WriteLine("x : " + fxm4 + ": y : " + fym4);
            Console.WriteLine("x : " + fxm5 + ": y : " + fym5);
            Console.WriteLine("x : " + fxm6 + ": y : " + fym6);
            Console.WriteLine("x : " + fxm7 + ": y : " + fym7);
            Console.WriteLine("x : " + fxm8 + ": y : " + fym8);
            Console.WriteLine("x : " + fxm9 + ": y : " + fym9);

            funkcja_punkt(x, y, p_x, p_y);
            Console.WriteLine();

            x = y;

            if (a < 0)
            {
                Console.WriteLine("Malejaca.");
            }
            else
            {
                Console.WriteLine("Rosnaca.");
            }

            for (int i = y; i >= -y; i--)
            {

                if (i < 0) { Console.Write(i + " "); }
                else { Console.Write(i + "  "); }

                for (int k = -x; k <= x; k++)
                {

                    if(k == fx0 && i == 0)
                    {
                        m0x = k;
                        m0y = y;
                    }

                    if (i == 0 && k == 0)
                    {

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(" 0");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if ((i == fy0 && k == fx0) || (i == fy1 && k == fx1) || (i == fy2 && k == fx2) || (i == fy3 && k == fx3) || (i == fy4 && k == fx4) || (i == fy5 && k == fx5) || (i == fy6 && k == fx6) || (i == fy7 && k == fx7) || (i == fy8 && k == fx8) || (i == fy9 && k == fx9))
                    {

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(" F");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else if ((a == 1 && b == 1 || b == 0) && ((i == fym0 && k == fxm0) || (i == fym1 && k == fxm1) || (i == fym2 && k == fxm2) || (i == fym3 && k == fxm3) || (i == fym4 && k == fxm4) || (i == fym5 && k == fxm5) || (i == fym6 && k == fxm6) || (i == fym7 && k == fxm7) || (i == fym8 && k == fxm8) || (i == fym9 && k == fxm9)))
                    {

                        Console.ForegroundColor = ConsoleColor.Magenta;
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
                Thread.Sleep(50);
            }

            // Console.WriteLine("Miejsce zerowe: " + m0x + " : " + m0y); in dev
            Console.ReadKey();
        }

        public static void funkcja_punkt(int x, int y, int p_x, int p_y)
        {

            x = y;

            for (int i = y; i >= -y; i--)
            {

                if (i < 0) { Console.Write(i + " "); }
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
                Thread.Sleep(50);
            }
        }
    }
}