using System;

namespace DjeliteljiDoPetlja
{
    class Program
    {
        static void Main(string[] args)
        {
            var nastavi = true;
            do
            {
                Console.Write("Unesite n (1-100.000): ");
                var unos = Console.ReadLine();
                if(string.IsNullOrEmpty(unos))
                {
                    nastavi = false;
                }
                else
                {
                    var ok = int.TryParse(unos, out int n);
                    if (!ok)
                    {
                        Console.WriteLine("Pogrešan format");
                        continue;
                    }
                    if (n < 1 || n > 100000)
                    {
                        Console.WriteLine("Broj nije u rasponu 1-100.000");
                        continue;
                    }
                    long suma = 0;  //Proglasimo suma da je long da ne ode u overflow
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % 3 == 0 || i % 5 == 0)
                        {
                            // suma = suma + i; //duže
                            suma += i;  //kraće
                        }
                    }
                    

                    Console.WriteLine(
                    "Suma brojeva od 1 do {0} koji su djeljivi sa 3 ili 5 je {1:N0}",
                    n, suma);
                }
            } while (nastavi);
        }
    }
}
