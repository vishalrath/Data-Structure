using System;

namespace Linklist_Data_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Welcome to the Linked list opration");
            Uc1LinkedList list = new Uc1LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();

            Console.WriteLine("\n \nWelcome to the Linked list InsertFront opration");
            Uc2LinkedList uc2list = new Uc2LinkedList();
            uc2list.InsertFront(70);
            uc2list.InsertFront(30);
            uc2list.InsertFront(56);
            list.Display();*/


            /* Console.WriteLine("\n \nWelcome to the Linked list Apending  opration");
             Uc3LinkedList uc3list = new Uc3LinkedList();
             uc3list.InsertFront(70);
            // uc3list.InsertFront(30);
             uc3list.InsertFront(56);
             uc3list.Display();
            // uc3list.Append(56);
             uc3list.Append(30);
             //uc3list.Append(70);
             uc3list.Display();*/


            /* Console.WriteLine("\n \nInsert the middle node 56 and70 between 30  opration");
             Uc4LinkedList uc4list = new Uc4LinkedList();
             uc4list.InsertFront(56);
             uc4list.InsertFront(70);
             uc4list.MidInsert(30);
             uc4list.Display();*/


            /*Console.WriteLine("\n \nDelete first Node  opration");
            Uc5LinkedList uc5list = new Uc5LinkedList();
            uc5list.InserLast(56);
            uc5list.InserLast(30);
            uc5list.InserLast(70);
            uc5list.Display();
            Console.WriteLine(" \nDeleted first node valus is:" + uc5list.DeleteFirstNode());
            uc5list.DeleteFirstNode();*/


            /* Console.WriteLine("\n \nDelete Last Node  opration");
             Uc6LinkedList uc6list = new Uc6LinkedList();
             uc6list.InserLast(56);
             uc6list.InserLast(30);
             uc6list.InserLast(70);
             uc6list.Display();
              Console.WriteLine(" \nDeleted Last node valus is:" + uc6list.DeleteLastNode());
              uc6list.Display();*/

            /* Console.WriteLine("\n \nSearch  Node  opration");
             Uc7LinkedList uc7list = new Uc7LinkedList();
             uc7list.InserLast(56);
             uc7list.InserLast(30);
             uc7list.InserLast(70);
             uc7list.Display();
             Console.WriteLine(" \nSearch  node valus is:" + uc7list.search(30));
             uc7list.Display();*/

            /*  Console.WriteLine("\n \nAddAfter  Node  opration");
                 Uc8LinkedList uc8add = new Uc8LinkedList();
             uc8add.Add(56);
             uc8add.Add(30);
             uc8add.Add(70);
             uc8add.Display();
             uc8add.AddAfter(40);
             uc8add.Display();*/

           /* Console.WriteLine("\n \nSpecific delete  Node  opration");
            Uc9LinkedList uc9list = new Uc9LinkedList();
            uc9list.Add(56);
            uc9list.Add(30);
            uc9list.Add(70);
            uc9list.AddAfter(40);
            uc9list.Display();
            uc9list.DeleteNode(40);
            uc9list.Display();*/
            

            Console.WriteLine("\n \nSAscending Order of  Node  opration");
            Uc10LinkedList uc10list = new Uc10LinkedList();
            uc10list.Add(60);
            uc10list.Add(56);
            uc10list.Add(30);
            uc10list.Add(70);
            uc10list.Display();
            uc10list.sort();
            
            uc10list.Display();
           Console.ReadLine();

        }
    }
}
