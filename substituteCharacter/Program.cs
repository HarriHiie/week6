using System;

namespace substituteCharacter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("sisesta oma eesnimi");
            string userfirstname = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi");
            string userlastname = Console.ReadLine();

            string fullname = $"{userfirstname}{userlastname}".ToLower();

            fullname = fullname.Replace('a', '*');
            Console.WriteLine(fullname);



        }
    }
}
