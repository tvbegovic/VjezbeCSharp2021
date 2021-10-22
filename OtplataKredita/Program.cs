using System;

namespace OtplataKredita
{
    class Program
    {
        public static void IzracunParametara(double iznos, double stopa, 
            int brojGodina, out double anuitet, out double iznosKamata)
        {
            if(iznos < 0 || stopa < 0 || brojGodina < 0)
            {
                throw new ArgumentException("Parametri moraju biti pozitivni brojevi");
            }
            var r = Kamatnjak(stopa);
            var n = brojGodina * 12;
            anuitet = iznos * Math.Pow(r, n) * (r - 1) / (Math.Pow(r, n) - 1);
            iznosKamata = anuitet * n - iznos;
        }

        public static double Kamatnjak(double stopa)
        {
            return 1 + stopa / 100 / 12;
        }



        static void Main(string[] args)
        {
            var nastavi = true;
            do
            {
                Console.Write("Glavnica: ");
                var unos = Console.ReadLine();
                if(string.IsNullOrEmpty(unos))
                {
                    nastavi = false;
                }
                else
                {
                    var ok = double.TryParse(unos, out double glavnica);
                    if (!ok)
                    {
                        Console.WriteLine("Pogrešan format");
                        continue;
                    }
                    Console.Write("Stopa: ");
                    unos = Console.ReadLine();
                    ok = double.TryParse(unos, out double stopa);
                    if (!ok)
                    {
                        Console.WriteLine("Pogrešan format");
                        continue;
                    }
                    Console.Write("Broj godina: ");
                    unos = Console.ReadLine();
                    ok = int.TryParse(unos, out int brojGodina);
                    if (!ok)
                    {
                        Console.WriteLine("Pogrešan format");
                        continue;
                    }
                    try
                    {
                        IzracunParametara(glavnica, stopa, brojGodina,
                            out double anuitet, out double kamate);
                        Console.WriteLine(@"Za zadani iznos kredita {0:N2}, 
                            godišnju kamatnu stopu {1:N2} i broj godina otplate {2} 
                             anuitet je {3:N2} a ukupno plaćena kamata {4:N2}",
                             glavnica, stopa, brojGodina, anuitet, kamate);
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
