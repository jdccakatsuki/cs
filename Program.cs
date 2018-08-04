using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    // Class definition. - Abstract representation of an object -Data pack / Representation of an entity of the system/ Abstract reprentation of an object
    public class ObjectEntity
    {
        // Class members:
        //Generalities definition  of the objects from this type
        // STATE-(Defined by Atributes-Propiesties) Property.  
        public int AtributeProperty { get; set; }

        //BEHAEVIOUR Method.
        public int Method(int Parameter)
        {
            return Parameter * AtributeProperty;
        }

        //an Instance Constructor.
        public ObjectEntity()
        {
            AtributeProperty = 0;
        }
    }

    // Another class definition that contains Main, the program entry point.
    
    class Program
    {
        //The Main method in the Program class creates an instance (object) of ObjectEntity, and the object’s method and property are accessed by using dot notation
        
        static void Main(string[] args)
        {
            //Particulas state of the class - This instance is independing of other instance from de same type
            // Create an object/Instance of type CustomClass.
            ObjectEntity Class = new ObjectEntity();

            //Example , Colour , Type 
            // Set the value of the public Atribute / Property .    ACCES TO THE PROPERTY WITH DOT NOTATION
            Class.AtributeProperty = 1;

            // Call the public method , and set the value of the field? ACCES TO THE METHOD WITH DOT NOTATION
            int resultMethod = Class.Method(2);
            // Is important to show the {resultMethod}
            // The  display of the following output:
            Console.WriteLine($"The value of the method  is {resultMethod}.");
        }
    }
}
