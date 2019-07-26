using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private List<char> SpecialChars = new List<char>(){'!','.',',','"','?',':',';'};
        public static int occur {get; set;}
        public static int countRepeats(string sentence, string word) //sentence needs to be "cleaned" of special characters before using this method
        {
            occur = 0;
            
            string[] separated = sentence.ToLower().Split(" ");
            Console.WriteLine($"Word: {word}");
            for(int i = 0; i < separated.Length; i++)
            {
                Console.WriteLine($"Separated: {separated[i]}");
                if (separated[i] == word.ToLower())
                {
                    occur++;
                    Console.WriteLine($"Occur: {occur}");
                }
            }
            return occur;
        }
        public static string sentenceCleaner(string sentence)
        {
            string[] cleaner = sentence.ToLower().Split();
            for (int i = 0; i < cleaner.Length; i++)
            {
                
            }
            return  sentence; 
        }
    }
}