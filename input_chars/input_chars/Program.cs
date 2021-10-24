using System;

namespace input_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input chars and output in reverse order");
            string chars;
            char chars1,chars2;
            int i;
            Console.WriteLine("enter a character");
            chars1= char.Parse( Console.ReadLine());
            Console.WriteLine("enter second char");
            chars2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("chars2:"+chars2);
            Console.WriteLine("chars1:"+chars1);
            Console.WriteLine("enter a string");
            chars = Console.ReadLine();
            for ( i = chars.Length-1; i>=0; i--)
            {
                Console.WriteLine($"chars{i}:"+chars[i]);
              
            }
        }
    }
}
