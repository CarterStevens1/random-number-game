using System;

namespace random_number_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //create class for random number between 1 - 100
            //ask for a number from user
            //if number = random number then win
            //else repeat
            //
            Random random = new Random();
            int returnValue = random.Next(1, 100);//generates a number between 1 and 100
            int guess = 0; // sets the value at for guess

            Console.WriteLine("guess a number between 1 and 100: ");

            while (guess != returnValue) // while number is not return value iterate through this loop
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < returnValue)
                {
                    Console.WriteLine("Guess higher, you have gone too low!");
                }
                else if (guess > returnValue)
                {
                    Console.WriteLine("Guess Lower, you have gone too high!");
                }


            }
            Console.WriteLine(" well done the correct number was: " + returnValue);
            Console.ReadLine();
        }
    }
}
    
    

