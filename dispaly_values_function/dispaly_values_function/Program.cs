using System;

namespace dispaly_values_function
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("x= y^2+2y+1");
            for( y=-5; y<=5; y++)
            {
                Console.WriteLine($"x={y}^2+2{y}+1:"+(Math.Pow(y,2)+(2*y)+1));
            }
        }
    }
}
