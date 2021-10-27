using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linklist_Data_Struct
{
    class Uc10LinkedList
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

        /* This is the main function that sorts 
   the linked list.*/
       /* Node newNode(int key)
        { 
            return new Node(key);
        }*/
       public  void sort()
        {
           

            /* Create 2 dummy nodes and initialise as 
            heads of linked lists */
            Node Ahead = new Node(0), Dhead = new Node(0);

           
            // Split the list into lists
            splitList(Ahead, Dhead);

            Ahead = Ahead.next;
            Dhead = Dhead.next;

            // reverse the descending list
            Dhead = reverseList(Dhead);

            // merge the 2 linked lists
            head = mergeList(Ahead, Dhead);
        }

        /* Function to reverse the linked list */
       Node reverseList(Node Dhead)
        {
            Node current = Dhead;
            Node prev = null;
            Node next;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            Dhead = prev;
            return Dhead;
        }

        /* Function to print linked list */
      /*public void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }*/

        // A utility function to merge two sorted linked lists
        Node mergeList(Node head1, Node head2)
        {
            // Base cases
            if (head1 == null)
                return head2;
            if (head2 == null)
                return head1;

            Node temp = null;
            if (head1.data < head2.data)
            {
                temp = head1;
                head1.next = mergeList(head1.next, head2);
            }
            else
            {
                temp = head2;
                head2.next = mergeList(head1, head2.next);
            }
            return temp;
        }

        // This function alternatively splits a linked list with head
        void splitList(Node Ahead, Node Dhead)
        {
            Node ascending = Ahead;        // "Ahead" is reference to head of ascending linked list
            Node dscn = Dhead;        // "Dhead" is reference to head of descending linked list
            Node curr = head;

            // Link alternate nodes

            while (curr != null)
            {
                // Link alternate nodes in ascending order
                ascending.next = curr;
                ascending = ascending.next;
                curr = curr.next;

                if (curr != null)
                {
                    dscn.next = curr;
                    dscn = dscn.next;
                    curr = curr.next;
                }
            }

            ascending.next = null;
            dscn.next = null;
        }

    }
}
