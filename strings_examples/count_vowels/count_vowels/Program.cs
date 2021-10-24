using System;

namespace count_vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Enter a string");
             str1 = Console.ReadLine();
            string[] str2 = new string[str1.Length];
            for(int i = 0; i < str2.Length; i++)
            {
                str2[i] = Convert.ToString( str1[i]);
            }
           
                Console.Write(str1);
                Console.WriteLine();
                Console.Write(str2);
            
        }
    }
}
