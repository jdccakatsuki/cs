using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redimensionar
{
    

    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(6);
            list.Add(2);
            list.Add(9);
            list.Add(0);
            list.Sort();

            // Loop through List with foreach.
            foreach (int parameter in list)
            {
                System.Console.WriteLine(parameter);
            }

            List<int> listInstantiate = new List<int>(new int[] { 2, 3, 7 });
            // Loop with for and use string interpolation to print values.
            for (int i = 0; i < listInstantiate.Count; i++)
            {
                Console.WriteLine($"{i} = {listInstantiate[i]}");
            }

            List<bool> List2 = new List<bool>();
            List2.Add(true);
            List2.Add(false);
            List2.Add(true);
            List2.Remove(true);
            Console.WriteLine(List2.Count);

            List2.Clear();
            Console.WriteLine(List2.Count);

            int[] Array = new int[3];
            Array[0] = 2;
            Array[1] = 22;
            Array[2] = 222;

            List<int> ListArray = new List<int>(Array);
            Console.WriteLine(ListArray.Count);

            LinkedList<string> linked = new LinkedList<string>();
            linked.AddLast("First");
            linked.AddLast("Second");
            linked.AddLast("Third");
            linked.AddFirst("Cero");
            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }

            //
            // Create a new linked list.
            //
            LinkedList<string> linked2 = new LinkedList<string>();
            //
            // First add three elements to the linked list.
            //
            linked2.AddLast("one");
            linked2.AddLast("two");
            linked2.AddLast("three");
            //
            // Insert a node before the second node (after the first node)
            //
            LinkedListNode<string> node = linked2.Find("one");
            linked2.AddAfter(node, "inserted");
            //
            // Loop through the linked list.
            //
            foreach (var value in linked2)
            {
                Console.WriteLine(value);
            }



        }
    }
}
