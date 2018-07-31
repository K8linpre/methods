using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_continued
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Enter a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            num2 = int.Parse(Console.ReadLine());

            Math numbers = new Math();
            Console.WriteLine("{0} x {1} = {2}", num1, num2, numbers.MultiplyNumbers(num1, num2));
            Console.ReadLine();
        }
    }
    class Math
    {
        public int MultiplyNumbers(int _num1, int _num2)
        {
            return _num1 * _num2;
        }
    }
}
