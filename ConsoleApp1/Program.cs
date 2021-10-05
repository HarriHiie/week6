using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string Hellowrold = "Hello World";
            string partToLookFor = "Hello";

            bool isthere;

            isthere = Hellowrold.ToLower().Contains(partToLookFor);

            if (isthere)
            {
                Console.WriteLine($"Leidsin {partToLookFor} üles!");
            }
            else
            {
                Console.WriteLine($"Ei Leidnud{partToLookFor}");
            }








        }
    }
}
