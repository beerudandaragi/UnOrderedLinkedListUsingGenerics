using System;
using System.Collections;
using System.Collections.Generic;

namespace UnOrderedLinkedList
{
    class GFG
    {

       
        public static void Main()
        {
            
            LinkedList<int> myList = new LinkedList<int>();

           
            myList.AddLast(30);
            myList.AddLast(56);
            myList.AddLast(70);
            
            Console.WriteLine("Total nodes in myList are : " + myList.Count);

            
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            myList.AddFirst(70);
            myList.AddFirst(30);
            myList.AddFirst(56);
            Console.WriteLine("Total nodes in myList are : " + myList.Count);

            
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}