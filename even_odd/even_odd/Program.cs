using System;

namespace even_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("enter number1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number2");
            number2 = Convert.ToInt32(Console.ReadLine());

            if ((number1 % 2) ==0  && (number2 % 2) == 0)
            {
                Console.WriteLine("both are even");
            } 
            else
            {
                if ((number1 % 2)!= 0 && (number2 % 2) != 0){

                    Console.WriteLine("both are  odd");
                }
                else
                {
                    Console.WriteLine("one of them is odd");
                }
            }
        }
    }
}
