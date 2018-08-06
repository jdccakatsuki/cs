using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StaticMembers
{
    //a static class cannot be instantiated
    //you cannot use the new keyword to create a variable of the class type
    //you access the members of a static class by using the class name itself.
    // STATIC CLASS
    public static class StaticClass
    {
        // STATIC METHOD
        public static double Method1(string Parameter1)
        {
            // Convert argument to double for calculations.
            double argument1 = Double.Parse(Parameter1);

            // Convert to argument 2.
            double argument2 = (argument1 * 9 / 5) + 32;

            return argument2;
        }

        //STATIC METHOD
        public static double Method2(string ParameterMethod2)
        {
            // Convert argument to double for calculations.
            double argument1 = Double.Parse(ParameterMethod2);

            // Convert argument to argument 2.
            double argument2 = (argument1 - 32) * 5 / 9;

            return argument2;
        }
    }

    class Method3
    {
        static void Main()
        {
            Console.WriteLine("Please select the convertor direction");
            Console.WriteLine("1. From Celsius to Fahrenheit.");
            Console.WriteLine("2. From Fahrenheit to Celsius.");
            Console.Write(":");

            string selection = Console.ReadLine();
            double F, C = 0;

            switch (selection)
            {
                case "1":
                    Console.Write("Please enter the Celsius temperature: ");
                    // STATIC IMPLEMENTATION
                    F = StaticClass.Method1(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                    break;

                case "2":
                    Console.Write("Please enter the Fahrenheit temperature: ");
                    // STATIC IMPLEMENTATION
                    C = StaticClass.Method2(Console.ReadLine());
                    Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                    break;

                default:
                    Console.WriteLine("Please select a convertor.");
                    break;
            }
        }
    }
}
