using System;
using System.Collections.Generic;

namespace Generics
{
    public class Mainclass
    {
        private static void Main()
        {
            bool Equal = Calculator.AreEqual<string>("AB", "CD");
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

        public class Calculator
        {
            public static bool AreEqual<T>(T Value1, T Value2)
            {
                return Value1.Equals(Value2);
            }
        }
    }
}


