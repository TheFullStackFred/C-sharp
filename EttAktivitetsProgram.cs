using System;

namespace EttAktivitetsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to enter age and saving age in variabel age.
            Console.WriteLine("Enter age");
            byte age = Convert.ToByte(Console.ReadLine());
            //Sets money to 15000.
            int money = 15000;

            //Runs until money exceed 20000 and age exceed 65.
            do
            {
                if (money > 20000 || age < 60)
                {
                    Console.WriteLine("You are saving little");
                    //Add 500 to current value of money 
                    money = money + 500;
                }
                else
                {
                    Console.WriteLine("You are saving alot");
                    money = money + 1000;

                }
                //Adding 1 year.
                age++;

            }
            while (money < 20000 && age < 65);

            Console.WriteLine("You are retired by the age of " + age);
            Console.WriteLine("You are saved dollars: " + money);
            Console.ReadKey();



        }
    }
}
