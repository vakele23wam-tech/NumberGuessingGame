using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingGame
{
    internal class NumberGuessing
    {
        private int numberToGuess = 0;
        private int minimum = 0;
        private int maximum = 0;


        
        public NumberGuessing(int minimum, int maximum) // Constructor: same name as the class, no return type, called when object is created
        {
            GenerateRandomNumber(minimum, maximum);
        }
        public void GenerateRandomNumber(int minimum, int maximum)
        {
            Random rand = new Random();
           numberToGuess = rand.Next(minimum, maximum);

            this.minimum = minimum;
            this.maximum = maximum;
        }

       public GuessResult MakeGuess(int guess)
        {
            if (guess > maximum)
            {
                return GuessResult.OutofLimits;
            }
            else if (guess < minimum)
            {
                return GuessResult.OutofLimits;
                    }
            else
            if (guess == numberToGuess)
            {
                
                return GuessResult.Correct;
            }
            else if (guess < numberToGuess)
            {
                return GuessResult.TooLow;
            }
            else
            {
                return GuessResult.TooHigh;
            }

    }

}
}

