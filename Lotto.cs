using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ListOfEnteredNumbers = new int[10];
            // intValue used to check Try.Parse with enter line lottoLine if it's a int
            int intValue;

            Console.WriteLine("Enter 10 numbers between 1 - 25 to start the game");
            // iterates til user succed to enter 10 numbers between 1 - 25
            for (int i = 0; i < ListOfEnteredNumbers.Length; i++)
            {
                string lottoLine = Console.ReadLine();
                // check if lottoLine is an int
                if (int.TryParse(lottoLine, out intValue))
                {
                    // check if lottoLine is a number between 1 and 25
                    if (Convert.ToInt32(lottoLine) < 26 && Convert.ToInt32(lottoLine) > 0)
                    {
                        ListOfEnteredNumbers[i] = Convert.ToInt32(lottoLine);
                    }
                    else
                    {
                        Console.WriteLine("Enter a number between 0 - 25");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Letters aren't valid as a number, enter a number");
                    i--;
                }
            }


            int drawnNumber = new Random().Next(1, 25);
            for (int i = 0; i < ListOfEnteredNumbers.Length; i++)
            {
                // check if drawn number excist in ListOfEnteredNumbers
                if (ListOfEnteredNumbers[i] == drawnNumber)
                {
                    Console.WriteLine("Drawn number match, Bingo. Drawn number: " + drawnNumber);
                    // sets i to length of ListOfEnteredNumbers to exist loop
                    i = ListOfEnteredNumbers.Length;
                }
                else
                {
                    Console.WriteLine("Drawn number does not match any of your numbers. Drawn number: " + drawnNumber);
                }
            }

            Console.WriteLine("Game finished");

        }
    }
}
