using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Encapsulation
{
    
    //Encapsulate is Restrict access to members of an object
    //three levels of access to the members of an object
    //Public: Any object with access to the desired object can call the method or read and write the attribute that it accesses.

    //Only the desired object can call its methods or read and write its attributes
    //-Private:Objects of its subclasses can NOT access those members
    //-Protected:protected members can be accessed by objects of the subclasses.
    class ClassEncapsule
    {
        
        //Attributes
        public int data1 { get; set; }
        private int data2 { get; set; }
        protected int data3 { get; set; }

        //Methods -  The ideal practice of OOP suggests trying to write software with high cohesion - defining concise classes and methods.
        //cohesion :
        //determines how closely related system components are in solving specific problems
        //is strong when program components access and implement logic strictly related to their purpose and interact with other components to solve a specific problem.
        //is weak when its components access or implement logic that does not correspond to its nature or design purpose.
        public int Method(int Parameter)
        {
            Parameter = data1;
            return Parameter * Parameter;
        }

        private int Method2(int Parameter)
        {
            Parameter = data2;
            return Parameter * Parameter;
        }

        protected int Method3(int Parameter)
        {
            Parameter = data3;
            return Parameter * Parameter;
        }

        //Instance constructor
        public ClassEncapsule()
        {
            data1 = 0;
            data2 = 0;
            data3 = 0;
        }
    }

    class Encapsulate2 : ClassEncapsule
    {
        //Constructor
        public Encapsulate2()
        {

        }
        //Instance of constructor
        public Encapsulate2(int p)
        {
            this.data3 = p;
            Console.WriteLine("Print of the property 3 of type protected in the sub class of ClassEncapsule");
            Console.WriteLine(p);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Encapsulate2 clas = new Encapsulate2(3);
            clas.data1 = 2;
            int result = clas.Method(2);
            Console.WriteLine("Print of the property 1 of type public in other class");
            Console.WriteLine(result);
        }
    }
}
