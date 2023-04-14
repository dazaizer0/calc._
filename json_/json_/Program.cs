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

            /* WRITE
            
            var OBJECT = new OBJECT()
            {

                NAME = "O_OBJECT",
                ID = 0001,

                STATISTICS_ = new List<STATISTICS>()
                {

                    new STATISTICS()
                    {

                        INI = "O_",
                        EXP = 3456122
                    }
                }
            };

            string SERIALIZED = JsonConvert.SerializeObject(OBJECT);
            string path = @"data.txt";
            File.WriteAllText(path, SERIALIZED);*/

            // READ

            string path = @"data.txt";
            string SERIALIZED_READ = File.ReadAllText(path);
            OBJECT OBJ = JsonConvert.DeserializeObject<OBJECT>(SERIALIZED_READ);

            Console.WriteLine(OBJ.ID);
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

