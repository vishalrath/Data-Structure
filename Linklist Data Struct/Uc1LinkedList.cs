using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linklist_Data_Struct
{
    class Uc1LinkedList
    {
        public Node head;   //defining the head possition of link list
        public void Add(int deta)  // create add method in this class
        {
            Node node = new Node(deta);    // defining and creating object of node class and push the data of node class
            if (this.head == null)
            {
                this.head = node;          // is null then push the node deta that have add into the head
            }
            else
            {
                Node temp = head;             // creating temp veriable of node
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;       
            }
            Console.WriteLine("inserted into the link list:{0}", node.data);
        }
           public void Display()
        {
            Console.WriteLine("Display Nodes");
            Node temp = this.head;               // initializethe temp veriable in the node class
            if(temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + "");
                    temp = temp.next;
                }
            }
        }
    }
}
