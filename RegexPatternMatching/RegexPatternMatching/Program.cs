using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPatternMatching
{
    class Program
    {   
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.validatePinCode("abc123"));
            Console.WriteLine(patterns.validatePinCode("400123"));

        }

    }
}
