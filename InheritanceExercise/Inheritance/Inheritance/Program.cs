using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Inheritor implicitly inherits from the Object class.
    public class Inheritor
    {
        // Static field stores the property1 of the last Inheritor that has been created.
        private static int Data;

        //Properties.
        protected int Property1 { get; set; }
        protected string Property2 { get; set; }
        protected string Property3 { get; set; }
        protected TimeSpan Property4 { get; set; }

        //Constructor.
        public Inheritor()
        {
            Property1 = 0;
            Property2 = "Default";
            Property3 = "Default.";
            Property4 = new TimeSpan();
        }

        // Instance constructor - has three parameters.
        public Inheritor(string p2, string p3, TimeSpan p4)
        {
            this.Property1 = GetNext();
            this.Property2 = p2;
            this.Property3 = p3;
            this.Property4 = p4;
        }

        // Static constructor to initialize the static member, currentID. This
        // constructor is called one time, automatically, before any instance
        // of WorkItem or ChangeRequest is created, or currentID is referenced.
        static Inheritor()
        {
            Data = 0;
        }

        protected int GetNext()
        {
            // Data is a static field. It is incremented each time a new instance of Inheritor is created.
            return ++Data;
        }

        // Method Update enables you to update the property2 and property4 length of an existing Inheritor object.
        public void Update(string p2, TimeSpan p4)
        {
            this.Property2 = p2;
            this.Property4 = p4;
        }

        //( Virtual method override) of the( ToString method that is inheritedfrom System.Object).
        public override string ToString()
        {
            return String.Format("{0} - {1}", this.Property1, this.Property2);
        }
    }

    public class Inheritor2 : Inheritor
    {
        protected int originalProperty1 { get; set; }

        // Constructors. Because neither constructor calls a base-class 

        // constructor explicitly, the default constructor in the base class is called implicitly. The base class must contain a default constructor.
        
        // Default constructor for the derived class.
        public Inheritor2()
        {

        }

        // Instance constructor that has parameters.
        public Inheritor2(string p2, string p3, TimeSpan p4, int op)
        {
            // The following properties and the GetNexID method are inherited 
            // from WorkItem.
            this.Property1 = GetNext();
            this.Property2 = p2;
            this.Property3 = p3;
            this.Property4 = p4;

            // Property original is a member of Inheritor2, but not of Inheritor1.
            this.originalProperty1 = op;
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
            // Create an instance of Inheritor by using the constructor in the base class that takes three arguments.
            Inheritor inheritor = new Inheritor("Parameter Hineritor","Parameter", new TimeSpan(3, 4, 0, 0));
            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.
            Inheritor2 inheritor2 = new Inheritor2("Parameter","Parameter",new TimeSpan(4, 0, 0),1);
            // Use the ToString method defined in Inheritor1.
            Console.WriteLine(inheritor.ToString());
            // Use the inherited Update method to change the title of the Inheritor2 object.
            inheritor2.Update("Parameter Hineritor 2",new TimeSpan(4, 0, 0));      
            // Inheritor2 inherits Inheritor override of ToString.
            Console.WriteLine(inheritor2.ToString());
            // Keep the console open in debug mode.
            Console.WriteLine("Press key to exit.");
            Console.ReadKey();
        }
      }
 }

