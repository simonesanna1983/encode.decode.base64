using System;
using System.Text;

namespace encode.decode.base64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t *** TOOL TO ENCODE/DECODE USERNAME AND PASSWORD ***\n");
        Retry:
            Console.WriteLine("1 Encode\n2 Decode\nPress 1 or 2\n");
            var choose = Console.ReadLine();

            if (Convert.ToInt32(choose) == 1)
            {
                Console.WriteLine("Insert Username:");
                string userName = Console.ReadLine();


                Console.WriteLine("Insert Password:");
                string password = Console.ReadLine();


                string svcCredentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(userName + ":" + password));

                Console.WriteLine();
                Console.WriteLine(svcCredentials);

            }
            else if (Convert.ToInt32(choose) == 2)
            {
                Console.WriteLine("Insert Encoded:");
                string encode = Console.ReadLine();


                var base64EncodedBytes = System.Convert.FromBase64String(encode);
                var result = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);

                Console.WriteLine();
                Console.WriteLine(result);

            }
            else
            {
                Console.WriteLine("\n\n wrong choice! Try again\n\n");
                goto Retry;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();


        }
    }
}
