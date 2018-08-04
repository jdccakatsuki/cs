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
        private static int currentID;

        //Properties.
        protected int Data1 { get; set; }
        protected string Title { get; set; }
        protected string Description { get; set; }
        protected TimeSpan jobLength { get; set; }

        //Constructor.
        public Inheritor()
        {
            Data1 = 0;
            Title = "Default title";
            Description = "Default description.";
            jobLength = new TimeSpan();
        }

        // Instance constructor that has three parameters.
        public Inheritor(string title, string desc, TimeSpan joblen)
        {
            this.Data1 = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = joblen;
        }

        // Static constructor to initialize the static member, currentID. This
        // constructor is called one time, automatically, before any instance
        // of WorkItem or ChangeRequest is created, or currentID is referenced.
        static Inheritor()
        {
            currentID = 0;
        }

        protected int GetNextID()
        {
            // currentID is a static field. It is incremented each time a new
            // instance of WorkItem is created.
            return ++currentID;
        }

        // Method Update enables you to update the title and job length of an
        // existing WorkItem object.
        public void Update(string title, TimeSpan joblen)
        {
            this.Title = title;
            this.jobLength = joblen;
        }

        // Virtual method override of the ToString method that is inherited
        // from System.Object.
        public override string ToString()
        {
            return String.Format("{0} - {1}", this.Data1, this.Title);
        }
    }

    public class Inheritor2 : Inheritor
    {
        protected int originalItemID { get; set; }

        // Constructors. Because neither constructor calls a base-class 
        // constructor explicitly, the default constructor in the base class
        // is called implicitly. The base class must contain a default 
        // constructor.

        // Default constructor for the derived class.
        public Inheritor2() { }

        // Instance constructor that has four parameters.
        public Inheritor2(string title, string desc, TimeSpan jobLen,
                             int originalID)
        {
            // The following properties and the GetNexID method are inherited 
            // from WorkItem.
            this.Data1 = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = jobLen;

            // Property originalItemId is a member of ChangeRequest, but not 
            // of WorkItem.
            this.originalItemID = originalID;
        }
    }

    class Program
        {
            static void Main(string[] args)
            {
            // Create an instance of WorkItem by using the constructor in the 
            // base class that takes three arguments.
            Inheritor item = new Inheritor("Fix Bugs","Fix all bugs in my code branch", new TimeSpan(3, 4, 0, 0));
            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.
            Inheritor2 change = new Inheritor2("Change Base Class Design","Add members to the class",new TimeSpan(4, 0, 0),1);
            // Use the ToString method defined in WorkItem.
            Console.WriteLine(item.ToString());
            // Use the inherited Update method to change the title of the 
            // ChangeRequest object.
            change.Update("Change the Design of the Base Class",new TimeSpan(4, 0, 0));      
            // ChangeRequest inherits WorkItem's override of ToString.
            Console.WriteLine(change.ToString());
            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
      }
 }

