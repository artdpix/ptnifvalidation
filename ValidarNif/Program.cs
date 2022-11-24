using System;

namespace ValidarNif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool wait = true;
            do
            {
                Console.Write("Nif: ");

                string nif = Console.ReadLine();

                if (nif == "") { wait = false; }

                Console.WriteLine(PtNifValidation.Nif(nif));
                
            } while (wait);

        }
    }
}
