using System;

namespace Avrundraren
{
    class Avrundaren
    {
        static void Main(string[] args)
        {
            //Ber användaren skriva in ett tal med decimaler och sparar det i en float variabel.
            Console.WriteLine("Skriv in ett tal med decimaler");
            float decimaltal = float.Parse(Console.ReadLine());

            //Frågar användaren hur många decimaler som skall visas.
            Console.WriteLine("Hur många decimaler skall visas?");
            int antalDecimaler = int.Parse(Console.ReadLine());

            //Avrundar antalet önskade decimaler och till bestämt antal.
            double önskatantaldecimaler = Math.Round(decimaltal,antalDecimaler);
            double bestämtantaldecimaler = Math.Round(decimaltal, 3);

            //Skriver ut värdena av dom avrundade talen.
            Console.WriteLine("Tal med önskat antal decimaler: " + önskatantaldecimaler);
            Console.WriteLine("Tal med förbestämt antal decimaler: " + bestämtantaldecimaler);

            Console.ReadKey();

        }
    }
}
