using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        private List<char> SpecialChars = new List<char>(){'!','.',',','"','?',':',';'};
        public static int occur {get; set;}
        public static int countRepeats(string sentence, string word)
        {
            
            occur = 0;
            string[] separated = sentence.ToLower().Split(" ");
            for(int i = 0; i < separated.Length; i++)
            {
                string wordCheck = separated[i].Substring(0,separated[i].Length-1);
                if (wordCheck == word.ToLower())
                {
                    occur++;
                } else if (separated[i] == word.ToLower())
                {
                    occur++;
                }
            }
            return occur;
        }
    //Method for "cleaning" the sentence of special chars (does not work yet)
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