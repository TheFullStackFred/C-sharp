using System;

namespace Vektor2
{
    class Program
    {
        static void Main(string[] args)
        {   //Skrivit ut en vektor med 10 platser//
            int[] digits = new int[10];
            //Körs tills man har fyllt vektorn digits med 10 platser//
            for (int i = 0; i < digits.Length; i++)
            {   
                Console.WriteLine("Enter 10 numbers, you have entered " + i + " numbers so far");
                //Hämtar tal som användaren skriver in//
                string str = Console.ReadLine();
                int fromUser = Convert.ToInt32(str);
                //Lägger talet på rätt plats i vektorn//
                digits[i] = fromUser;

            }//Skriver ut alla tal i vektorn//
            Array.ForEach(digits, Console.WriteLine);

        } 
    }
}
