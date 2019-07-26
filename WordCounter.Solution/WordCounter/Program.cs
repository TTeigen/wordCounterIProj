using System;

namespace WordCounter
{
    class Program
    {
        public static void Main()
        {
            bool runProgram = true;
            do {
                Console.WriteLine("Enter a sentence:\n");
                string sentence = Console.ReadLine();
                Console.WriteLine("Enter a word, and we will tell you if that word is in the sentence and how many times!");
                string word = Console.ReadLine();
                int occur = RepeatCounter.countRepeats(sentence,word);
                if (occur > 0)
                {
                    Console.WriteLine($"Your word '{word}' repeats in the sentence you supplied {occur} time(s).");
                } else
                {
                    Console.WriteLine($"Looks like {word} does not exist in your sentence or there was a typo.");
                }
                Console.WriteLine("\n Would you like to try again?");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "no")
                {
                    runProgram = false;
                }
            } while (runProgram == true);
        }
    }
}