﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ResizeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and initialize a new string array.
            String[] myArr = {"The", "quick", "brown", "fox", "jumps","over", "the", "lazy", "dog"};

            // Display the values of the array.
            Console.WriteLine("The string array initially contains the following values:");
            Method(myArr);

            // Resize the array to a bigger size (five elements larger).
            Array.Resize(ref myArr, myArr.Length + 5);

            // Display the values of the array.
            Console.WriteLine("After resizing to a larger size, ");
            Console.WriteLine("the string array contains the following values:");
            Method(myArr);

            // Resize the array to a smaller size (four elements).
            Array.Resize(ref myArr, 4);

            // Display the values of the array.
            Console.WriteLine("After resizing to a smaller size, ");
            Console.WriteLine("the string array contains the following values:");
            Method(myArr);
        }

        public static void Method(String[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.WriteLine("   [{0}] : {1}", i, myArr[i]);
            }
            Console.WriteLine();
        }
    }
}
