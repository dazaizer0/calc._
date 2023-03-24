using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj funkcje: ");
            var func = Console.ReadLine();

            Console.WriteLine("podaj x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(func);

            foreach(object liczba in func)
            { 

                string liczba_str = liczba.ToString();
                Console.WriteLine(liczba);

                if (StringExt.IsNumeric(liczba_str)) 
                {

                    int liczba_int = int.Parse(liczba_str);
                    Console.WriteLine("wynik: " + x * liczba_int);
                }
            }
            Console.ReadKey();
        }
    }

    public static class StringExt
    {
        public static bool IsNumeric(this string text)
        {
            double test;
            return double.TryParse(text, out test);
        }
    }
}