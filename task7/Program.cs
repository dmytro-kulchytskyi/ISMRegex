using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string pattern = @"http:\/\/\w+\.\w+(\.\w+)*(\/\w+(\.\w+)?)*";
            str = Regex.Replace(str, pattern, "<a href=\"$0\">Link</a>"); 
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
