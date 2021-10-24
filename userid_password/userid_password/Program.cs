using System;

namespace userid_password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check with user id and password");
            string name = "mallika";
            string password = "Mallika01aug$";
            int i = 1;
          
                 Console.WriteLine("enter name:");
                 string name_input = Console.ReadLine();
                 Console.WriteLine("enter password:");
                 string password_input = Convert.ToString(Console.ReadLine());


                if (name == name_input && password == password_input)
                {
                    Console.WriteLine("Sucessful login");
                   
                }
                else
                {
                    while (i <= 2)
                    {
                        Console.WriteLine("try again");
                        Console.WriteLine("enter name:");
                        name_input = Console.ReadLine();
                        Console.WriteLine("enter password:");
                        password_input = Convert.ToString(Console.ReadLine());

                    
                         i++;
                    }
                Console.WriteLine("3 attemps are over , please try again later");
                 }

        }
    }
}
