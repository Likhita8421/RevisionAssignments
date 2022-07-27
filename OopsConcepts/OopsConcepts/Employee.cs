using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    //--------Polymorphism-------//

    public class Employee     //base class
    {
        public string FirstName = "FN";    //properties
        public string LastName = "LN";

        public virtual void PrintFullName()   //method
        {
            Console.WriteLine(FirstName+ " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee      //derived class
    {
        public override void PrintFullName()   //method
        {
            Console.WriteLine(FirstName + " " + LastName + "- Part Time");
        }
    }

    public class FullTimeEmployee : Employee      //derived class
    {
        public override void PrintFullName()   //method
        {
            Console.WriteLine(FirstName + " " + LastName + "- Full Time");
        }

    }

    public class TemporaryEmployee : Employee      //derived class
    {
        public override void PrintFullName()   //method
        {
            Console.WriteLine(FirstName + " " + LastName + "- Temporary");
        }
    }

}









