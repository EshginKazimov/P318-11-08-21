using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAbstract
{
    //Instance almaq olmur, inheritance almaq olmur
    public static class Helper
    {
        public static int Test { get; set; }

        static Helper()
        {
            Console.WriteLine("Helper called");
        }

        public static void Print(string text)
        {
            Console.WriteLine("Text: " + text);
        }
    }

    //static class Test : Helper
    //{

    //}
}
