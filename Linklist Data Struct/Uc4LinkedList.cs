using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linklist_Data_Struct
{
    class Uc4LinkedList
    {
        internal Node head;   //defining the head possition of link list
        internal void MidInsert(int deta)  //  Apending in last and create add method in this class
        {
            Node new_node = new Node(deta);
            Node pos = head;
            int len = 0;
            //calculating the length of link list
            while(pos != null)
            {
                len++;
                pos = pos.next;
            }
            //finding middle possition
            int count = ((len % 2) == 0) ? (len / 2) : (len * 1) / 2;
            pos = head;
            // pos is the pointer to node after which node insert
            while( count -- > 1)
            {
                pos = pos.next;
            }
            new_node.next = pos.next;
            pos.next = new_node;


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
    }
}
