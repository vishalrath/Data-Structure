using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks__And_Queues
{
    class Uc4LinkedListDequeue
    {
        Node head;
        public void Equeue(int item)
        {
            Node new_node = new Node(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("insert into list" + new_node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
        }
        public void Dequeue()
        {
          // if queue is empty return null
          if(this.head == null)
            {
                Console.WriteLine("the Queue is empty");
                return;
            }
            // store the previous head and move head pointer one step ahed to deletthe current elemnt
            Node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine(" insert into list" + this.head.data);
        }
    }
}
