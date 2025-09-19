using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erettsegi_kozep25majus
{
    internal class Program
    {
        static string Beolvas()
        {
            string szoveg = Console.ReadLine();

            return szoveg;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat");
            Console.Write("Adja meg az aktivitását: ");

            string szoveg = Beolvas();

            bool u = false;
            bool g = false;
            bool f = false;
            bool k = false;

            Console.WriteLine("2. feladat");
            Console.Write("Az elért távolság: ");

            int tavolsag = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] == 'U')
                {
                    tavolsag += 1;
                    if (!u)
                        u = true;
                }
                else if (szoveg[i] == 'G')
                {
                    tavolsag += 1;
                    if (!g)
                        g = true;
                }
                else if (szoveg[i] == 'F')
                {
                    tavolsag += 2;
                    if (!f)
                        f = true;
                }
                else if (szoveg[i] == 'K')
                {
                    tavolsag += 10;
                    if (!k)
                        k = true;
                }
            }
            Console.WriteLine(tavolsag + " km");

            Console.WriteLine("3. feladat");

            if (u && g && f && k)
            {
                Console.WriteLine("Az induló minden mozgásformát kipróbált. Plusz 10km!");
                tavolsag += 10;
            }
            else
                Console.WriteLine("Az induló nem próbált ki minden mozgásformát.");

            Console.WriteLine("4. feladat");
            if (tavolsag >= 40)
            {
                Console.WriteLine("Összes távod: " + tavolsag + "km.  Kihívás teljesítve!");
            }
            else
            {
                Console.WriteLine("Összes távod: " + tavolsag + " km. Kihívás nem sikerült!");
            }
        }
    }
}