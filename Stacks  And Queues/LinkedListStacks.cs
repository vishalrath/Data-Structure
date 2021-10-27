using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks__And_Queues
{
    class LinkedListStacks
    {
        public Node top;
        public void push(int newData)
        {
            // creating link between newNode and where top the pointing
            // then pointing top towords the new node
            //new node is inserted on top
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;   // new hold the address of top element
            }
            this.top = newNode;     // top will point to new element
            Console.WriteLine("new node {0} is added", newNode.data);
        }

        // displaying the value in the stack
        public void Display()
        {
            // checking if stack is not empty
            //printing the value till temp to point towords null and end of the stack
            Node temp = this.top;
            if(temp == null)
            {
                Console.WriteLine("no value to display, empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("value in the Stack:"+ temp.data);
                temp = temp.next;
            }
        }
    }
}
