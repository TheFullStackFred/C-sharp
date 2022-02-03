using System;

namespace DetHemligaTalet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Slumpar ett nummer mellan 1-100.
            Random randomerare = new Random();
            int slump_tal = randomerare.Next(1, 101);

            //Deklarerar valt tal pga while kan hitta och jämföra med slumptal.
            int valttal;
            
            //Kör do-loopen tills dess att while villkoret är sant.
            do
            {
                //Ber användaren skriva in ett tal.
                Console.WriteLine("Skriv in ett tal");
                valttal = int.Parse(Console.ReadLine());
                //Körs ifall slumptal är störra än valt tal.
                if (slump_tal > valttal)
                {
                    Console.WriteLine("Valt tal lägre än slumptal");
                }
                //Körs ifall slumtal är mindre än valt tal.
                else if (slump_tal < valttal)
                {
                    Console.WriteLine("Valt tal högre än slumptal");
                }
                else
                {
                    Console.WriteLine("Rätt gissat");
                }

            } while (slump_tal != valttal);

            Console.ReadKey();


        }
    }
}
