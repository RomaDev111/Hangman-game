using System;

class HangmanGame
{
    static void Main(string[] args)
    {
        string secretWord = "hello";
        string guessedWord = "_____";
        int attempts = 5;
        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("Try to guess the secret word.");

        while (attempts > 0 && guessedWord != secretWord) 
        {
            Console.WriteLine("Attempts left: " + attempts);
            Console.WriteLine(" Word: " + guessedWord);
            Console.WriteLine("Enter a letter: ");
            char letter = Console.ReadLine()[0];

            bool letterFound = false;
            for (int i = 0; i < secretWord.Length; i++) 
            {
                if (secretWord[i] == letter) 
                {
                    guessedWord = guessedWord.Remove(i, 1).Insert(i, letter.ToString());
                    letterFound = true;
                }
            }
            if (!letterFound) 
            {
                Console.WriteLine("Incorrect guess!");
                attempts--;
            }

        }
        if (guessedWord == secretWord) 
        {
            Console.WriteLine("Congratulations! You guessed the word: " + secretWord);
        }
        else 
        {
            Console.WriteLine("Sorrry, you have run out of attempts. The word was: " + secretWord);
        }
        Console.WriteLine("Thank you for playing Hangman!");
    }
}