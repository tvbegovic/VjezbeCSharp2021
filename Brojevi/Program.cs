using System;
using System.Linq;

namespace Brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            var nastavi = true;
            do
            {
                Console.Write("Unesite broj elemenata niza: ");
                var unos = Console.ReadLine();
                if(string.IsNullOrEmpty(unos))
                {
                    nastavi = false;
                }
                else
                {
                    var ok = int.TryParse(unos, out int brojElemenata);
                    if(!ok)
                    {
                        Console.WriteLine("Pogrešan format");
                        continue;
                    }
                    if(brojElemenata < 1)
                    {
                        Console.WriteLine("Broj mora biti >= 1");
                        continue;
                    }
                    int[] brojevi = new int[brojElemenata];
                    var i = 0;
                    while(i<brojElemenata)
                    {
                        Console.Write("Element {0}:", i + 1);
                        unos = Console.ReadLine();
                        ok = int.TryParse(unos, out brojevi[i]);
                        if(!ok)
                        {
                            Console.WriteLine("Pogrešan format");
                            continue;
                        }
                        i++;
                    }
                    var suma = 0;
                    var najmanji = brojevi[0];
                    var najveci = brojevi[0];
                    foreach (var broj in brojevi)
                    {
                        suma += broj;
                        if (broj < najmanji)
                            najmanji = broj;
                        if (broj > najveci)
                            najveci = broj;
                    }
                    var prosjek = suma * 1.0 / brojElemenata;
                    Console.WriteLine("Zbroj elemenata niza je {0:N0}", suma);
                    Console.WriteLine("Prosjek elemenata je {0:N2}", prosjek);
                    Console.WriteLine("Najmanji element je {0}", najmanji);
                    Console.WriteLine("Najveći element je {0}", najveci);

                    //Upotreba extension metoda
                    suma = brojevi.Sum();
                    prosjek = brojevi.Average();
                    najmanji = brojevi.Min();
                    najveci = brojevi.Max();

                    Console.WriteLine("Zbroj elemenata niza je {0:N0}", suma);
                    Console.WriteLine("Prosjek elemenata je {0:N2}", prosjek);
                    Console.WriteLine("Najmanji element je {0}", najmanji);
                    Console.WriteLine("Najveći element je {0}", najveci);
                }
            } while (nastavi);
        }
    }
}
