using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linklist_Data_Struct
{
    class Node
    {
        public int data;
        public Node next;
        internal object prev;

        public Node(int data)  //constructer parameteris
        {
            this.data = data;
            next = null;
        }

    }
}
