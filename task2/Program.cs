using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Regex regex = new Regex(@"\<td\>(.+)\<\/td\>");
            Match match = regex.Match(str);
            while (match.Success)
            {
                Console.WriteLine(match.Groups[1].Value);
                match = match.NextMatch();
            }
            Console.ReadKey();

        }
    }
}
