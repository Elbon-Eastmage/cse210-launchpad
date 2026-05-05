using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;
        
        do
        {
            Random random = new();
            int magicNumber = random.Next(1, 101);
            int attempts = 0;
            int guess;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                attempts++;

            } while (guess != magicNumber);

            if (attempts == 1)
            {
                Console.WriteLine("You made 1 guess.");
            }
            else
            {
                Console.WriteLine($"You made {attempts} guesses.");
            }

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();

        } while (playAgain == "yes");
    }
}