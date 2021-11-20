using System;
using System.Collections;
using System.Collections.Generic;

namespace UnOrderedLinkedList
{
    class linkedlist
    {

       
        public static void Main()
        {
            
            LinkedList<int> myList = new LinkedList<int>();

           
            myList.AddLast(30);
            myList.AddLast(56);
            myList.AddLast(70);

            LinkedListNode<int> node = myList.Find(30);
            myList.AddBefore(node,70);
            myList.AddAfter(node,56);
            
            Console.WriteLine("Total nodes in myList are : " + myList.Count);


            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            

            Console.ReadKey();
        }
    }
}