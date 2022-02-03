using System;

namespace Pension
{
    class Program
    {
        static void Main(string[] args)

        {   //Frågar användaren efter namn och sparar detta i variabeln name.
            Console.WriteLine("Ange ditt för och efternamn:");
            string name = Console.ReadLine();

            //Frågar användaren efter ålder och omvandlar detta till en int och sparar detta i variabeln ålder.
            Console.WriteLine("Ange din ålder");
            int ålder = int.Parse(Console.ReadLine());

            //Beräknar hur många år användaren har till pension.
            Console.WriteLine(name + " du har nu " + (65 - ålder) + " år kvar till pension");

            //Förhindrar programet att avsluta sig själv.
            Console.ReadKey();


        }
    }
}
