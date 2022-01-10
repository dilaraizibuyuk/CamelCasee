using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CamelCasee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One123Two987".SplitCamelCase());
            Console.WriteLine("aComputer".SplitCamelCase());
            Console.WriteLine("casedWordHTTPWriter".SplitCamelCase());
            Console.WriteLine("AppleComputer".SplitCamelCase());
            Console.WriteLine("anIBM".SplitCamelCase());
            Console.ReadKey();
        }
    }
}
