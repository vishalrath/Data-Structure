using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linklist_Data_Struct
{
    class Uc3LinkedList
    {
        internal Node head;   //defining the head possition of link list
        internal void AddLast(int deta)  //  Apending in last and create add method in this class
        {
            Node new_node2 = new Node(deta);    // defining and creating object of node class and push the data of node class
            if (this.head == null)             //checking the head is null or not
            {
                this.head = new_node2;          // is null then push the node deta that have add into the head
            }
            else
            {
                Node temp = head;             // creating temp veriable of node
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node2;
            }
            Console.WriteLine("\ninserted into the link list:{0}", new_node2.data);
        }
        public void Display()  //display the data in linked list
        {
            Console.WriteLine("Display Nodes");
            Node temp = this.head;               // initializethe temp veriable in the node class
            if (temp == null)                  // checking linklist empty or not
            {
                Console.Write("Linked list is Empty");
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
       public void Append( int new_data)
        {
            AddLast(new_data);
        }

        public void InsertFront(int new_data)
        {
            //we will create a new node.the next of the new nde will point to the head of linked list
            Node new_node = new Node(new_data);
            //when we want to add any node at the front we want the head of point
            new_node.next = this.head;
            //the previous head node is  now the second nodeof linked list bcoz the new noded is added at
            this.head = new_node;
            Console.WriteLine("inserted new node into list" + new_node.data);
        }
    }

}
