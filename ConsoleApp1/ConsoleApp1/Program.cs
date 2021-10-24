using System;

namespace surface_sp
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.14f;
            float radius, surface,volume;
            Console.WriteLine("surface_sp");
            Console.WriteLine("enter radius");
            radius = Convert.ToSingle(Console.ReadLine());
            volume = (4 / 3) * pi *radius*radius*radius;
            surface = 4 * pi * radius * radius;
            Console.WriteLine("volume:"+volume);
            Console.WriteLine("surface:"+surface);


        }
    }
}
