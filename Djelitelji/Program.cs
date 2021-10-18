using System;

namespace Djelitelji
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite n (1-100.000): ");
            var unos = Console.ReadLine();
            var ok = int.TryParse(unos, out int n);
            if(!ok)
            {
                Console.WriteLine("Pogrešan format");
                return;
            }
            if(n < 1 || n > 100000)
            {
                Console.WriteLine("Broj nije u rasponu 1-100.000");
                return;
            }
            long suma = 0;  //Proglasimo suma da je long da ne ode u overflow
            for (int i = 1; i <=n ; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    // suma = suma + i; //duže
                    suma += i;  //kraće
                }
            }

            Console.WriteLine(
            "Suma brojeva od 1 do {0} koji su djeljivi sa 3 ili 5 je {1:N0}",
            n, suma);
        }
    }
}
