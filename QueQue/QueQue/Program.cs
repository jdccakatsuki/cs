using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueQue
{
    class Program
    {
    
        static void Main(string[] args)
        {
            // New Queue of integers.
            Queue<int> Que = new Queue<int>();

            Que.Enqueue(2);   // Add 5 to the end of the Queue.
            Que.Enqueue(22);  // Then add 10. 5 is at the start.
            Que.Enqueue(32);  // Then add 15.
            Que.Enqueue(42);  // Then add 20
            Que.Dequeue();

            foreach (int value in Que)
            {
                Console.WriteLine(value);
            }
        }
    }
}
