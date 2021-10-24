using System;

namespace check_character
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Enter a character");
            c = Convert.ToChar(Console.ReadLine());
            if ((c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u')){
                Console.WriteLine("it is lower case vowel ");
            }
            else
            {
                if ((c >= '0') && (c <= '9'))
                {
                    Console.WriteLine("it is a digit");
                }
                else
                {
                    Console.WriteLine("it is other");
                }
               

            }
           

        }
    }
}
