using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{ 
    //------------Inheritance----------//

    class Animal //base class
    {
        public string? dogName;
        public void display()
        {
            Console.WriteLine("I have a pet Dog");
        }
    }

    class Dog : Animal  // derived class of Animal 
    {

        public void getName()
        {
            Console.WriteLine("Her name is " + dogName);
        }
    }
}
