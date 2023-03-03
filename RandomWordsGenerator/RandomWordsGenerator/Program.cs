using System;
using System.Collections.Generic;

namespace RandomWordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;

            Random random = new Random();

            while (true)
            {
                int wers_len = random.Next(15, 30);

                for (int i = 0; i < wers_len; i++)
                {

                    int los_ = los(random);
                    Console.Write(words(los_));
                }

                Console.WriteLine(); ;
            }
        }


        static int los(Random random)
        {

            int los = random.Next(1, 11);
            return los;
        }


        static string words(int los)
        {

            Dictionary<int, string> dwords = new Dictionary<int, string>();

            // words collection
            dwords.Add(1, " dupa");
            dwords.Add(2, " kerbal");
            dwords.Add(3, " nani");
            dwords.Add(4, " DIO!");
            dwords.Add(5, " kokoko");
            dwords.Add(6, " NIGERUNDAIO");
            dwords.Add(7, " no kiss before marige");
            dwords.Add(8, " c#");
            dwords.Add(9, " calc");
            dwords.Add(10, " .______.");

            return dwords[los];
        }
    }
}
