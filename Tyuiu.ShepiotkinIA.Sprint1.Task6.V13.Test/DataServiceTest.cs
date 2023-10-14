using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint1.Task6.V13.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string[] words = { "abc", "xyz", "hello", "world", "alphabet", "zebra" };

            foreach (string word in words)
            {
                bool isAlphabetical = CheckWordsAlphabet(word);
                Console.WriteLine("Word \"" + word + "\" is in alphabetical order: " + isAlphabetical);
            }
        }
    }
}
