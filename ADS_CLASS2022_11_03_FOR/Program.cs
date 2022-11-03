using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        try
        {
            var x = 10;

            for (int i = 0; i < x; i++) 
            {
                Console.WriteLine("i = " + i) ;

                if (i == 8)
                {
                    break;
                }
            }

            Console.ReadKey();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while running the application" + ex);

        }
    }
}