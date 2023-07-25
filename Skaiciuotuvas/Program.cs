using System;

namespace Skaiciuotuvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skaicius1 = 2;
            int skaicius2 = 7;
            int atsakymas = 9;

            if (Skaiciuotuvas.Suma(skaicius1, skaicius2) == atsakymas)
            {
                Console.WriteLine("Teisingai");
            }
            else
            {
                Console.WriteLine("Programos klaida");
            }
            
        }
    }
}
