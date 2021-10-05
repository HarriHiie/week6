using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm kuvab sõna pikkust lenght omaduse kasutamatta

            //foreach loop
            //foreach(element in string)

            string HelloWorld = "Hello world";

            int counter = 0;

            foreach (char character in HelloWorld)
            {
                counter = counter + 1;
            }
            Console.WriteLine($"{HelloWorld} on {counter} tähte pikk");



        }
    }
}
