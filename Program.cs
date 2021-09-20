using System;

namespace remainder_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to my remainder calculator");
            Console.WriteLine("input number 1");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input number 2");
            int number2 = Int32.Parse(Console.ReadLine());
            int result1 = number1 / number2;
            int result2 = number1 % number2;
            Console.WriteLine("The answer is: {0} remainder {1} ",result1,result2);
            Console.ReadLine();
        }
    }
}
