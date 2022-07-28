using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void StringDelegate(string text);  // created delegate
    public class Program
    {
        static void Main(string[] args)
        {
            StringDelegate stringDelegate = ToUpperCase;
            WriteOutput("this is a lowerCase String", stringDelegate);
        }

        static void ToUpperCase(string text)
        {
            Console.WriteLine(text.ToUpper());
        }

        //pass function as a parameter to another function 
        //create a function which takes as a parameter to delegate
        private static void WriteOutput(string text, StringDelegate stringDelegate)
        {
            Console.WriteLine($"Before: {text}");
            stringDelegate(text);
             
        }

    }
}
