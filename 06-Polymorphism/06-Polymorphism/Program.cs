using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Polymorphism
{
    class Program
    {
        class ClassPolymorph
        {
            //Propierties declaring the atributes 
            public int atribute1;
            public int atribute2;

            //Methods with polymorphism implementation- each one has a different behaviour but its name are the same with diferent args
            //methods with the same identifier, but their list of parameters changes
            public int Method(int p)
            {
                return atribute1 + p;
            }

            public int Method(int p, int p1)
            {
                return atribute1 - p -p1;
            }

            //Constructor class defining the atributes

            public ClassPolymorph()
            {
                atribute1 = 0;
                atribute2 = 0;
            }


        }

        class program
        {
            static void Main(string[] args)
            {
                ClassPolymorph polyInstance = new ClassPolymorph();
                polyInstance.atribute1 = 1;
                int resulMethod = polyInstance.Method(4);
                Console.WriteLine("The result of method behaviour with one parameter is:");
                Console.WriteLine(resulMethod);
                ClassPolymorph polyInstance2 = new ClassPolymorph();
                polyInstance2.atribute2 = 10;
                int resultMethod2 = polyInstance2.Method(6, 5);
                Console.WriteLine("The result of method behaviour with two parameter is:");
                Console.WriteLine(resultMethod2);
            }
        }
    }
}
