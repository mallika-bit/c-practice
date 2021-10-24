using System;

namespace speed
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed;
            int distance, hours;
            Console.WriteLine("Calculate velocity");
            Console.WriteLine("enter distance kilometer");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter hours");
            hours = Convert.ToInt32(Console.ReadLine());
            speed = distance / hours;
            Console.WriteLine("speed in kmh:"+speed);
            Console.WriteLine("speed in mph:"+ speed/1.6);

        }
    }
}
