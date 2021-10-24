using System;

namespace count
{
    class Program
    {
        static void Main(string[] args)
        {
            int al, n, spl;
            al = n = spl = 0;
            Console.WriteLine("Enter a string with mix of alphabets, numbers, special characters");
            string str = Console.ReadLine();
            for(int i=0; i < str.Length; i++)
            {
                if ((str[i] >='a' && str[i] <= 'z')||(str[i] >= 'A' && str[i] <= 'z'))
                {
                    al++;
                }
                else if (str[i] <='9' && str[i] >='0' )
                {
                    n++;
                }
                else
                {
                    spl++;
                }

            }
            Console.WriteLine(@"alphabets:{0}
numbers:{1}
special characters:{2}",al,n,spl); 
        }
    }
}
