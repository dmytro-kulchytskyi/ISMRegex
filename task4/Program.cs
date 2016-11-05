using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Regex regex = new Regex(@"[^1-9]+");
            Match match = regex.Match(str);
            if (match.Success)
                Console.WriteLine("Строка - не число.");
            else Console.WriteLine("Строка - число.");


            Console.ReadKey();

        }
    }
}
