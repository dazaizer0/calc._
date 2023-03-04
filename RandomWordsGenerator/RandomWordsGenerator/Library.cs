using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomWordsGenerator
{
    class Library
    {
        public static List<string> dwords = new List<string>()
        {
            " dupa", " kerbal", " nani", " DIO!", " kokoko", " NIGERUNDAIO",
            " no kiss before marige", " c#", " calc", " .__."
        };

        private static int llen = dwords.Count;

        public static int LLen
        {
            get { return llen; }
            set { llen = value; }
        }
    }
}
