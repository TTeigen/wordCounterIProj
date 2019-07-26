using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace CounterTests
{
    [TestClass]
    public class RepeatCounterTests
    {
        // [TestMethod]
        // public void countRepeats_ReturnWordRepeatCount_1()
        // {
        //     string sentence = "I walked my dog today";
        //     string word = "dog";
        //     int result = RepeatCounter.countRepeats(sentence, word);
        //     Assert.AreEqual(1, result);
        // }
        //  [TestMethod]
        // public void countRepeats_ReturnWordRepeatCount_2()
        // {
        //     string sentence = "Does Will Smith smith?";
        //     string word = "smith";
        //     int result = RepeatCounter.countRepeats(sentence, word);
        //     Assert.AreEqual(2, result);
        // }
        //  [TestMethod]
        // public void countRepeats_ReturnWordRepeatCount_chuck1()
        // {
        //     string sentence = "Can a woodchuck chuck wood";
        //     string word = "wood";
        //     int result = RepeatCounter.countRepeats(sentence, word);
        //     Assert.AreEqual(1, result);
        // }
        [TestMethod]
        public void sentenceCleaner_RemoveSPecialChars_StringNoSpecialChars()
        {
            string sentence = "How can you say that!";
            string check = "How can you say that ";
            string result = RepeatCounter.sentenceCleaner(sentence);
            Assert.AreEqual(check, result);
        }
    }
}