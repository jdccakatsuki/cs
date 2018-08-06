using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Arrays
{
    class ArrayClass
    {
        static void Main(string[] args)
        {
            //Data structure lineal and simple
            //Set of contiguous memory spaces to store several data of the SAME type.
            //Asignation of a constant size
            int[] Array = new int[10]; /* Array is an array of 10 integers */
            int i, j;

            /* initialize elements of array Array */
            for (i = 0; i < 10; i++)
            {
                Array[i] = i + 0;
            }

            /* output each array element's value */
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, Array[j]);
            }
            Console.ReadKey();
        }

        public static void PrintIndexAndValues(String[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine("   [{0}] : {1}", i, myArr[i]);
            }
            Console.WriteLine();
        }
    }
}
