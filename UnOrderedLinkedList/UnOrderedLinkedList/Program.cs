using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnOrderedList
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("helloword\n");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(76);
            list.display();
            // Console.WriteLine("Search Element" + list.search(30));
        }
    }
}