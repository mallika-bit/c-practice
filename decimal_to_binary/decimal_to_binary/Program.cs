using System;

namespace decimal_to_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string remainder =" ";
            Console.WriteLine("Decimal to binary");
            number = Convert.ToInt32(Console.ReadLine());
           
            while (number>= 1)
            {
                if ((number % 2) != 0)
                {
                    remainder += 1;
                   
                    number = number / 2;
                    //Console.WriteLine("number:" + number);
                }
                else
                {
                    remainder += 0;
                    number = number / 2;
                   // Console.WriteLine("number:"+number);
                    //Console.WriteLine(remainder);
                }


            }
            Console.WriteLine(remainder);
            Console.WriteLine("binary form is ");
            for(int i=remainder.Length-1; i>0;i--)
            {
                Console.Write(remainder[i]);
            }
        }
    }
}
