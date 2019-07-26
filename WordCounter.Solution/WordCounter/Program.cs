using System;

namespace WordCounter
{
    class Program
    {
        public static void Main()
        {
            bool runProgram = true;
            do
            {
                Console.WriteLine("Enter a sentence:\n");
                string sentence = Console.ReadLine();
                Console.WriteLine("Enter a word, and we will tell you if that word is in the sentence and how many times!");
                string word = Console.ReadLine();
                //runs results method
                resultPrinter(sentence,word);
                //check to keep running program
                Console.WriteLine("\n Would you like to try again? [no or n to stop]");
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "no" || userInput == "n")
                {
                    runProgram = false;
                }
            } while (runProgram == true);
        }
        //Method that combines the cleaner with the counter from the backend
        public static void resultPrinter(string sentence, string word)
        {
            string cleaned = RepeatCounter.sentenceCleaner(sentence);
            int occur = RepeatCounter.countRepeats(cleaned, word);
            if (occur > 0)
            {
                Console.WriteLine($"Your word '{word}' repeats in the sentence you supplied {occur} time(s).");
            }
            else
            {
                Console.WriteLine($"Looks like {word} does not exist in your sentence or there was a typo.");
            }
        }
    }
}