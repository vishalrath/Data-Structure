using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks__And_Queues
{
    class Uc3_LinklistQueue
    {
        Node head;
        public void Equeue(int item)
        {
            Node new_node = new Node(item);
            if(this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while(temp.next != null)
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

    }
}
