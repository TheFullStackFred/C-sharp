using System;
using System.Linq;

namespace Vektor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[10];
            int alertNumber = 10;

            for (int i = 0; i < digits.Length; i++)
            {
                Console.WriteLine("Enter 10 numbers, you have entered " + i + " numbers so far");
                string str = Console.ReadLine();
                int fromUser = Convert.ToInt32(str);

                if(digits.Contains(fromUser))
                {
                    Console.WriteLine("number already excist in vektor");
                    i--;
                }
                else
                {   //Placerar talet i vektorn.
                    digits[i] = fromUser;
                }
            }

            for(int i = 0; i < digits.Length; i++)
            {
                if(alertNumber == digits[i])
                {
                    Console.WriteLine("This number are used frequently: " + digits[i]);
                }
                Console.WriteLine("Numbers from vektor: " + digits[i]);
            }

        }
    }
}
