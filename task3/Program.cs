using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string pattern = @"(\</?)b(\>)";
            str = Regex.Replace(str, pattern, @"$1strong$2");
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
