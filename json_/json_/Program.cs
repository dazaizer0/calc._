using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
// NuGet: Newtonsoft.Json

namespace json_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"save.json";

            // WRITE
            
            /*var OBJECT = new OBJECT()
            {

                NAME = "K_OBJECT",
                ID = 1002,

                STATISTICS_ = new List<STATISTICS>()
                {

                    new STATISTICS()
                    {

                        INI = "K_",
                        EXP = 1125234
                    }
                }
            };

            string SERIALIZED = JsonConvert.SerializeObject(OBJECT);
            File.WriteAllText(path, SERIALIZED);

            Console.WriteLine("saved...");
            Console.ReadKey();  */

            // READ

            string SERIALIZED_READ = File.ReadAllText(path);
            OBJECT OBJ = JsonConvert.DeserializeObject<OBJECT>(SERIALIZED_READ);

            Console.WriteLine(OBJ.NAME + " " + OBJ.ID);
            Console.ReadKey();
        }
    }

    public class OBJECT
    {

        public string NAME { get; set; }
        public int ID { get; set; }
        public List<STATISTICS> STATISTICS_ { get; set; }
    }

    public class STATISTICS
    {

        public string INI { get; set; }
        public int EXP { get; set; }
    }
}

