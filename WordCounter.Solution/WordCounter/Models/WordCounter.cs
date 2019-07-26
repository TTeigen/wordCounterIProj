using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        //list of special characters for use with sentenceCleaner in lieu of regex
        private static List<char> SpecialChars = new List<char>(){'!','.',',','"','?',':',';'};
        // ' not included because it's a rare edge case that it would be used and not in the proper spelling of the word
        //Other special chars not included for a similar reason
        public static int occur {get; set;}
        public static int countRepeats(string sentence, string word)
        {
            occur = 0;
            string[] separated = sentence.ToLower().Split(" ");
            for(int i = 0; i < separated.Length; i++)
            {
                if (separated[i] == word.ToLower())
                {
                    occur++;
                }
            }
            return occur;
        }
    //Method for "cleaning" the sentence of special chars (somewhat unnecessary but cool)
        public static string sentenceCleaner(string sentence)
        {
            string[] cleaner = sentence.ToLower().Split();
            for (int i = 0; i < cleaner.Length; i++)
            {   
                foreach(char special in SpecialChars)
                {  
                    if (cleaner[i].Contains(special))
                    {
                        cleaner[i] = cleaner[i].Replace(special,' ');
                    }
                }
            }
            sentence = string.Join(" ", cleaner);
            return  sentence;
        }
    }
}