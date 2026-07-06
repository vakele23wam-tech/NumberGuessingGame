namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximum = 0;
            Console.WriteLine("What difficulty would you like? (E), (M), (H) ?");
            string difficulty = Console.ReadLine();
            if (difficulty == "E")
            {
                maximum = 10;
            }
            else if (difficulty == "M")
            {
                maximum = 50;
            }
            else
            {
                maximum = 1000;
            }

            NumberGuessing numberGuessing = new NumberGuessing(1, maximum);

            bool guessed = false;
            while (!guessed)
            {
                Console.WriteLine("Please enter your guess");
                string guesss = Console.ReadLine();
                GuessResult result = numberGuessing.MakeGuess(int.Parse(guesss));


                if (result == GuessResult.TooLow)
                {
                    Console.WriteLine("Your guess is too low, please try again.");
                }
                else if (result == GuessResult.TooHigh)
                {
                    Console.WriteLine("Your guess is too high, please try again.");
                }
                else if (result == GuessResult.Correct)
                {
                    Console.WriteLine("Well done, you are correct!");
                    guessed = true;
                }
                else if (result == GuessResult.OutofLimits)
                {
                    Console.WriteLine("Your guess is out of range, are you kidding me? Please try again");

                }
            }
    }
}
}

