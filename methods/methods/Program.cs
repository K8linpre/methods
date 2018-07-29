using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int total = 0;

            Console.WriteLine("Enter a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            num2 = int.Parse(Console.ReadLine());

            total = num1 * num2;
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
