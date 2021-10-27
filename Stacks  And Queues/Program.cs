using System;

namespace Stacks__And_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Stacks Opertion  !");
             LinkedListStacks stack = new LinkedListStacks();
             stack.push(56);
             stack.push(30);
             stack.push(70);
             stack.Display();
             Console.WriteLine("Is your Stack is empty: "+ stack.Isempty());
             stack.Display();*/

            Console.WriteLine("Queue Opertion !");
            Uc3_LinklistQueue uc3queue = new Uc3_LinklistQueue();
            uc3queue.Equeue(56);
            uc3queue.Equeue(30);
            uc3queue.Equeue(70);
            uc3queue.Display();
            

            Console.WriteLine("Dequeue Opertion !");
            Uc4LinkedListDequeue uc4dequeue = new Uc4LinkedListDequeue();
            uc4dequeue.Equeue(56);
            uc4dequeue.Equeue(30);
            uc4dequeue.Equeue(70);
            uc4dequeue.Display();
            uc4dequeue.Dequeue();
            uc4dequeue.Display();
            Console.ReadLine();
        }
    }
}
