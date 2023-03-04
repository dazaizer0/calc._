using System;
using System.Collections.Generic;

namespace RandomWordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            #region colors
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;
            #endregion

            #region writeing
            while (true)
            {
                int wers_len = random.Next(15, 30);

                for (int i = 0; i < wers_len; i++)
                {

                    int los_ = los(random, Library.LLen);
                    Console.Write(word(los_, Library.dwords));
                }

                Console.WriteLine(); ;
            }
            #endregion
        }

        #region funkcje-losujace
        static int los(Random random, int ListLenght)
        {
            int los = random.Next(0, ListLenght); 
            return los;
        }
        static string word(int los, List<string> dwords)
        {
            return dwords[los];
        }
        #endregion
    }
}
