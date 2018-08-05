using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Interfaces
{
    //Declaration Interface
    interface IInterface
    {
        //Methods for the class implemation
        float Method1();
        float Method2();
    }

    class ClassI : IInterface
    {
        //Properties
        float Property1;
        float Property2;

        //Constructor instantiate
        ClassI(float p1, float p2)
        {
            Property1 = p1;
            Property2 = p2;
        }
        // Explicit interface member implementation: - access to the member with the interface
        float IInterface.Method1()
        {
            return Property1;
        }
        // Explicit interface member implementation: - acces to the second member with the interface
        float IInterface.Method2()
        {
            return Property2;
        }


        class Program
        {
            static void Main(string[] args)
            {
                // Declare a class instance box1:
                ClassI clasInstance = new ClassI(20.0f, 20.0f);

                // Declare an interface instance dimensions:
                IInterface interfaceInstance = (IInterface)clasInstance;

                // The following commented lines would produce compilation 
                // errors because they try to access an explicitly implemented
                // interface member from a class instance:                   
                //System.Console.WriteLine("Length: {0}", box1.getLength());
                //System.Console.WriteLine("Width: {0}", box1.getWidth());

                // Print out the dimensions of the box by calling the methods 
                // from an instance of the interface:
                System.Console.WriteLine("Property1: {0}", interfaceInstance.Method1());
                System.Console.WriteLine("Property2: {0}", interfaceInstance.Method2());
            }
        }
    }
}
