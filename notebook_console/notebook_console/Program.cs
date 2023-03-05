using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notebook_console
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            Console.Clear();
            var start = DateTime.Now;

            string path = @"Notebook.txt"; // @ - sciesszka do pliku
            StreamWriter streamWriter;

            if (!File.Exists(path))
            {
                streamWriter = File.CreateText(path); // tworzymy plik
                Console.WriteLine("\n File have created...");
            }
            else
            {
                streamWriter = new StreamWriter(path, true); // append = true - dołacz, faalse != append = zapisuje na nowo
                Console.WriteLine("\n File have opened...");
            }

            Console.Write(start + "> "); var note = Console.ReadLine();

            streamWriter.WriteLine(start + " | " + note); // zapisujemy do pliku
            streamWriter.Close(); // zamykamy plik

            goto start;
        }
    }
}
