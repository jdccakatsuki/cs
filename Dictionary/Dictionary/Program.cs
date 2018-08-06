using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("cat", 2);
            dictionary.Add("dog", 1);
            dictionary.Add("llama", 0);
            dictionary.Add("iguana", -1);
            dictionary.Remove("cat");

            if (dictionary.ContainsKey("cat"))
            {
                int value = dictionary["cat"];
                Console.WriteLine(value);
            }

            if (dictionary.ContainsKey("dog"))
            {
                int value = dictionary["dog"];
                Console.WriteLine(value);
            }
        }


    }
}
