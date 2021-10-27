using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks__And_Queues
{
    class UC2PopAndPick
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
            if (temp == null)
            {
                Console.WriteLine("no value to display, empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("value in the Stack:" + temp.data);
                temp = temp.next;
            }
        }
        public void Pop()
        {
            // chexking  if top is null
            // oterwise printing the top element and deleting it also
            if (this.top == null)
            {
                Console.WriteLine("no element present the top");
                return;
            }

            int deletNode = this.top.data;
            Peek();

            this.top = this.top.next;
            Console.WriteLine("deleted elent is {0}", deletNode);
        } 
           /* internal void Peek()
            {
              if(this.top == null)
              {
                Console.WriteLine("Stack is empty");
                return;
              }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
            }*/
        public void Isempty()
        {
            while(this.top != null)
            {
                Pop();
                //Peek();
            }
            if(this.top == null)
            {
                return true;
            
            }
            else
                    return false;
        }
        
    }
}
