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
            MultiplyNums();
            TaskB.taskB();
            Math.taskC();
        }
        static void MultiplyNums()
        {
            int num1 = 0;
            int num2 = 0;
            int total = 0;

            Console.WriteLine("Enter a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            num2 = int.Parse(Console.ReadLine());

            total = num1 * num2;
            Console.WriteLine($"{num1} x {num2} = {total}");
            Console.ReadLine();
        }
    }
    public class TaskB
    {
        public static void taskB()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Enter a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} x {1} = {2}", num1, num2, MultiplyNumsAgain(num1, num2));
            Console.ReadLine();
        }
        public static int MultiplyNumsAgain(int _num1, int _num2)
        {
            return _num1 * _num2;
        }
    }
    class Math
    {
        public static void taskC()
        {
            int num1 = 0;
            int num2 = 0;
            int total = 0;

            Console.WriteLine("Enter a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            num2 = int.Parse(Console.ReadLine());

            total = num1 * num2;
            Console.WriteLine($"{num1} x {num2} = {total}");
            Console.ReadLine();
        }
    }
}
