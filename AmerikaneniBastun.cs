using System;

namespace AmerikaneniBastun
{
    class Program
    {

        static int FahrToCels(int fahr)
        {
            //Convert Fahrenheit to Celsius and return Celsius value.
            double cel = (fahr - 32) * 5 / 9;
            double celsius = Convert.ToDouble(cel);
            return (int)celsius;

        }


        static void Main(string[] args)
        {
            int lowestTempCelsius = 73;
            int higestTempCelsius = 77;
            int optimalTempCelsius = 75;

            //Declare Boolean for use in do-loop
            Boolean enteredDoLoop = false;
            double celsius;

            Console.WriteLine("Enter temp in Fahrenheit");
            //Runs til user enter a acceptable temperature.
            do
            {
                //Check if enteredDoLoop is set to true.
                if(enteredDoLoop)
                {
                    Console.WriteLine("Acceptable temperature is between 73 - 77 celsius. Enter a new temperature in fahrenheit");

                }
                int fahrenheit = int.Parse(Console.ReadLine());

                celsius = FahrToCels(fahrenheit);
                if (celsius < lowestTempCelsius)
                {
                    Console.WriteLine("Enter a higher temp");
                }
                else if (celsius > higestTempCelsius)
                {
                    Console.WriteLine("Enter a lower temp");
                }
                else if (celsius == optimalTempCelsius)
                {
                    Console.WriteLine("You have the perfect temp");
                }
                //Change Boolean to true.
                enteredDoLoop = true;


            }
            while (celsius! > higestTempCelsius || celsius !< lowestTempCelsius);

            Console.WriteLine("Enjoy the sauna with entered celsius temperature: " + celsius);
            Console.ReadKey();
            

            

        }
    }
}
