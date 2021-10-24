using System;

namespace circle_perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.14f;
            double area, perimeter, r;
            Console.WriteLine("Circle perimeter");
            Console.WriteLine("enter radius r:");
            r = Convert.ToDouble(Console.ReadLine());
            area = pi * r * r;
            perimeter = 2 * pi * r;
            Console.WriteLine("Area:"+area);
            Console.WriteLine("perimeter:"+perimeter);

        }
    }
}
