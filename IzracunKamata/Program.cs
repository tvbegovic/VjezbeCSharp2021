using System;

namespace IzracunKamata
{
    class Program
    {
        static decimal IznosKamata(decimal glavnica, decimal stopa)
        {
            //Provjera parametara (stopa)
            if (stopa < 0 || stopa > 20)
            {
                throw new ArgumentOutOfRangeException("Stopa je izvan raspona");
            }
            return glavnica * stopa / 100;
        }

        static void Main(string[] args)
        {
            var nastavi = true;
            do
            {
                Console.Write("Glavnica: ");
                var unos = Console.ReadLine();
                if (string.IsNullOrEmpty(unos))
                {
                    nastavi = false;
                }
                else
                {
                    var ok = decimal.TryParse(unos, out decimal glavnica);
                    if (!ok)
                    {
                        Console.WriteLine("Pogrešan format");
                        continue;
                    }
                    Console.Write("Stopa (0-20%): ");
                    unos = Console.ReadLine();
                    ok = decimal.TryParse(unos, out decimal stopa);
                    if (!ok)
                    {
                        Console.WriteLine("Pogrešan format");
                        continue;
                    }
                    /*if(stopa < 0 || stopa > 20)
                    {
                        Console.WriteLine("Stopa je izvan raspona");
                        continue;
                    }*/
                    try
                    {
                        var kamata = IznosKamata(glavnica, stopa);
                        Console.WriteLine("Za unesenu glavnicu {0:N2} i kamatnu stopu {1:N2} iznos kamata u jednom obračunskom razdoblju je {2:N2}.",
                        glavnica, stopa, kamata);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Pogreška: {0}", ex.Message);
                    }
                    
                }
            } while (nastavi);
        }
    }
}
