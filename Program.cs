using System;

namespace GuessingGame {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Guess a number between 1 and 100!");
            Random randomNumber = new Random ();
            int correctNumber = randomNumber.Next (1, 101);
            int guessesMade = 0;

            while (guessesMade < 10) {
                string numberGuessed = Console.ReadLine ();
                int numberGuessedInt = Int32.Parse (numberGuessed);

                if (numberGuessedInt == correctNumber) {
                    Console.WriteLine ("You guessed it! Yay!");
                    break;
                } else if (numberGuessedInt < correctNumber) {
                    Console.WriteLine ("That's a no! Too low!");
                    Console.WriteLine ($"Guesses left: {9 - guessesMade}");
                } else if (numberGuessedInt > correctNumber) {
                    Console.WriteLine ("Nice try, but too high!");
                    Console.WriteLine ($"Guesses left: {9 - guessesMade}");
                }

                guessesMade++;
            }

        }
    }
}