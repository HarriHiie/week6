using System;

namespace CharecterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab, mitu 'a' tähte kasutaja eesnimes ja perekonnanimes kokku on

            //char a = 'a';

            Console.WriteLine("sisesta oma eesnimi");
            string userfirstname = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi");
            string userlastname = Console.ReadLine();

            string fullname = $"{userfirstname}{userlastname}";

            int counter = 0;

            foreach (char character in fullname)
            {
                if (character == 'a');
            }
            counter++;
            {
                Console.WriteLine($"Sinu Nimes On {counter} a tähte");


                int counter = 0
                int i = fullname.Length - 1;

                while (1 >= 0)
                {
                    Console.WriteLine(fullname[i]);
                    if (fullname[i] == 'a') ;
                }
                counter = 0;




            }

        }
    }
}
