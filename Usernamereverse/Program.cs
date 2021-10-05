using System;

namespace Usernamereverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonnanime tagurpidi
            //*eesnimi ja perekonnanimi kuvatakse eraldi
            //kasutame for-tsüklit

            Console.WriteLine("sisesta oma eesnimi");
            string userfirstname = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi");
            string userlastname = Console.ReadLine();

            for (int i = userfirstname.Length - 1; i >= 0; i--)

                Console.WriteLine(userfirstname[i]);

            for (int i = userlastname.Length - 1; i >= 0; i--)

                Console.WriteLine(userlastname[i]);






        }
    }
}
