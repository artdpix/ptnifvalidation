using System;

namespace ValidarNif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool wait = false;
            do
            {
                Console.Write("Nif: ");

                string nif = Console.ReadLine();

                if (nif == "") { wait = true; }

                Console.WriteLine(PtNifValidation.Nif(nif));
                
            } while (!wait);

        }
    }
}
