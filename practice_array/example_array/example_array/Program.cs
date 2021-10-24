using System;

namespace example_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] number3_array = new int[100];
           Console.WriteLine("Enter the number of elements in the array");
           var number = Convert.ToInt32(Console.ReadLine());
           int[] number_array = new int[number];
           int[] n1;
           int i,duplicate=0,match=0;
           for (i = 0; i < number_array.Length; i++)
           {
               Console.WriteLine("enter number");
               number_array[i] = Convert.ToInt32(Console.ReadLine());
           }
          // Console.WriteLine("duplicate:"+duplicate);

           //foreach(int n in number_array)
           for(int j=0; j<number_array.Length; j++)
           {
               for (i = 0; i < number_array.Length; i++)
               {

                   if (number_array[j] == number_array[i])
                       {
                           match++;
                       }

                   } 
               if (match >=2)
               {
                   duplicate++;

               }
               match = 0;

           }
           Console.WriteLine("d:"+(duplicate)); 
        }
    }
}
