using System;
using System.Collections.Generic;
namespace Uppgift6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimtalEllerInte(79));
            Console.WriteLine(PrimtalEllerInte(51));
            Console.WriteLine(PrimtalEllerInte(80));
            Console.WriteLine(PrimtalEllerInte(49));
        }

        /// <summary>
        /// Undersöker om en int är ett primtal eller inte.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>True/False</returns>
        static bool PrimtalEllerInte(int x)
        {
            x = x < 0 ? Math.Abs(x) : x;

            for (int i = 0; i < x; i++)
            {
                if (i == 0 || i == x - 1) continue;
                else if (x % (i + 1) == 0) return false;
            }
            return true;
        }
    }
}
/*Skapa ett program med en metod som undersöker om ett visst heltal är ett primtal
eller inte. Ett primtal är ett tal som är större än 1 som bara är delbart med sig själv
och 1.
För att undersöka om ett tal är delbart med ett annat så använder man modulo-
operatorn som skrivs som ett procent-tecken. För att undersöka om t.ex. i är delbart
med 3 så ska uttrycket i % 3 == 0 vara sant, och detta kan du undersöka med en if-
sats.*/