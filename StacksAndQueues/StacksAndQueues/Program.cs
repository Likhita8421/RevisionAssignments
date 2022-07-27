using System;

    namespace StacksAndQueues
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Concept of stack(push and pop operation)--------------");
            LinkedListStack value = new LinkedListStack();
            value.push(10);
            value.push(3);
            value.push(7);
            value.DisPlay();
            value.Peek();
            value.Pop();
            value.IsEmpty();


            Console.WriteLine("-----------------Concept of Queue(enque&dequeue)---------------");
            StacksAndQueues.LinkedListQueue Queue = new StacksAndQueues.LinkedListQueue();
            Queue.Enqueue(4);
            Queue.Enqueue(3);
            Queue.Enqueue(7);  
            Queue.DisPlay();
            Queue.Dequeue();




        }
    }
}