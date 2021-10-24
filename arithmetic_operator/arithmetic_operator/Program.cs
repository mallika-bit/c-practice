using System;

namespace arithmetic_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+,-,*,/");
            Console.WriteLine("enter a number1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition:{0}", number1+number2);
            Console.WriteLine("subtraction:{0}", number1-number2);
            Console.WriteLine("Multiplication:{0}",number1*number2);
            Console.WriteLine("Division:{0}",number1/number2);

        }
    }
}
