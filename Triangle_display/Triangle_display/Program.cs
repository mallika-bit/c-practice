using System;

namespace Triangle_display
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number1, width;
            Console.WriteLine("enter number1");
            number1 = Convert.ToInt32( Console.ReadLine());
           
            Console.WriteLine("enter width");
            width = Convert.ToInt32(Console.ReadLine());
            while (width > 0)
            {
                for (int i = width; i > 0; i--)
                {
                    Console.Write(number1);

                }
                width--;
                Console.WriteLine();
            }
        }
    }
}
