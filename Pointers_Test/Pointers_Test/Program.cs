using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointers_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] TAB = { 1, 2, 3, 4, 5, };
            float F = Convert.ToSingle(TAB[3]);
            Console.WriteLine("SREDNIA: " + IX(F, TAB.Length));
            Console.ReadKey();
        }

        unsafe float IX(float* T, int HOW_MUCH)
        {

            float SUM = 0;

            for (int i = 0; i < HOW_MUCH; i++)
            {

                SUM += *T;
                T++;
            }

            float FINAL = SUM / HOW_MUCH;
            return FINAL;
        }
    }
}
