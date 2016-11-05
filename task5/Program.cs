using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Regex regex = new Regex(@"\b([A-Za-z0-9][-_\.]?)+@([A-Za-z0-9][-\.]?)+\.[A-Za-z0-9]+\b");
            Match match = regex.Match(str);
            while (match.Success)
            {
                Console.WriteLine(match.Groups[0].Value);
                match = match.NextMatch();
            }
            Console.ReadKey();

        }
    }
}
