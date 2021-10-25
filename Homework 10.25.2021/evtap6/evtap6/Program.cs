using System;

namespace evtap6
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            int loginAttemps = 0;

            for (int i = 0; i < 3; i++)
            {


// LOGIN: zeyn4l PAROL: z12345678



                Console.Write("Input UserID:  ");
                username = Console.ReadLine();
                Console.Write("Input password:  ");
                password = Console.ReadLine();

                if (username == "zeyn4l" && password == "z12345678")
                {
                    Console.WriteLine("You are sign in your account");
                    break;


                }
                else
                {


                    loginAttemps++;

                }
            }


         
                

           

            
        }
    }
}
