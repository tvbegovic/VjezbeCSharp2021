using System;

namespace DaniMjeseca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Redni broj mjeseca (1-12): ");
            var unos = Console.ReadLine();
            var ok = int.TryParse(unos, out int redniBrojMjeseca);
            if(!ok)
            {
                Console.WriteLine("Pogrešan format");
                return;
            }
            if(redniBrojMjeseca < 1 || redniBrojMjeseca > 12)
            {
                Console.WriteLine("Broj je izvan raspona 1 - 12");
                return;
            }
            int brojDana;
            switch(redniBrojMjeseca)
            {
                case 2:
                    if(DateTime.IsLeapYear(DateTime.Now.Year))
                    {
                        brojDana = 29;
                    }
                    else
                    {
                        brojDana = 28;
                    }                    
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    brojDana = 30;
                    break;
                default:
                    brojDana = 31;
                    break;
            }
            Console.WriteLine("{0}. mjesec ima {1} dana", redniBrojMjeseca, brojDana);
        }
    }
}
