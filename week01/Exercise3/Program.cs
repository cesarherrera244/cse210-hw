using System;

class Program
{
    static void Main(string[] args)
    {
        //generating a ramdon number from 1 to 100
        Random random = new Random();
        int magicNumber = random.Next(1, 100);
        int guess = 0;

        //guess until guesses the magic number
        while (guess != magicNumber)
        {
            //Ask the user for guess
            Console.Write("What is your guess?? ");
            guess = int.Parse(Console.ReadLine());

            //Determine if needs to guess higher, lower or guessed the number
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        }
    }
}