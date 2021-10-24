using System;

namespace count_words
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            for(int i = 0; i < str.Length; i++)
            {
                if((str[i]==' ')||(str[i])=='.')
                {
                    count++;
                }
            }
            Console.WriteLine("there are {0} words.",count);
        }
    }
}
