using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Abstract_classes_and_members
{
    //This class cant create instances
    public abstract class A
    {
        // Class  members here.
        //Pourpose : provide a common definition of a base class that multiple derived classes can share
        //abstract = key word
        // Abstract methods have no implementation, so the method definition is followed by a semicolon instead of a normal method block
        //Abstract classes may also define abstract methods. This is accomplished by adding the keyword abstract before the return type of the method.
        public abstract void AbstractMethod(int i);
    }

    //Derived classes of the abstract class must implement all abstract methods

    public class B
    {
        public virtual void virtualMethod(int i)
        {
            //Original implementation
        }
    }

    public abstract class C : B
    {
        // this abstract class can dfine atributes
        //SUB CLASS OF class b , this class can define
        // this abstract class can define methods
        // abstract members can be called in the class tha declare it , beause is obvious tha the object(class) that uses it has to have implement it
        //Abstract memebers cannot be (deffined) for the class tha declare it , this has to do the subclass
        public abstract override void virtualMethod(int i);
    }

    public abstract class D : C
    {
        public override void virtualMethod(int i)
        {
            //a abstrac class cannot be instantiate
            //cannot defined the method in the class B
            //cannot call virtualMethod on class C
            //A class inheriting an abstract method cannot access the original implementation of the method
            // New Implementation
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
