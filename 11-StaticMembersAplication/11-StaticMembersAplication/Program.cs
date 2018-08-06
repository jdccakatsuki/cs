using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StaticMembersAplication
{
    public class StaticMemberClass
    {
        public static int Propierty1 = 4;
        public static int Propierty2
        {
            get
            {
                return 15;
            }
        }

        public static void Method() { }
       // public static event EventType Name;
       
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            StaticMemberClass.Method();
            int i = StaticMemberClass.Propierty1;
        }
    }
}
