using System;

namespace Inicijali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ime: ");
            var ime = Console.ReadLine();
            Console.Write("Prezime: ");
            var prezime = Console.ReadLine();
            Console.WriteLine("Vaši inicijali su: {0}.{1}.",
                ime[0], prezime.Substring(0, 1));
        }
    }
}
