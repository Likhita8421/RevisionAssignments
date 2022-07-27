using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public interface IInterface1
    {
        void animalSound(); // interface method (does not have a body)
    }

    // cat "implements" the IInterface1 interface
    class Cat : IInterface1
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The cat say : meow meow");
        }
    }
}
