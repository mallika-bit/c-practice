using System;

namespace practice_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string ");
            string s = Console.ReadLine();
            for(int i = 0; i < s.Length; i++)
             {
                 Console.Write(s[i]+"    ");
             }
            Console.WriteLine();
            
            //reverse order
           // Console.WriteLine(s.Length);
           
            for(int i = s.Length-1; i >= 0; i--)
            {
                Console.Write(s[i]+ "   ");
            }
        }
    }
}
