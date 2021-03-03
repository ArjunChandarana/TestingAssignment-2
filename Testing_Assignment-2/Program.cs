using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string inputString = Console.ReadLine();
            string output;
            Console.WriteLine("Enter operation");
            string operation = Console.ReadLine();

            
            output = ExtensionMethods.StringConvert(inputString, operation);
            Console.WriteLine(output);

          
            Console.WriteLine("Press Enter to Exit");
            inputString = Console.ReadLine();
        }
    }
}
