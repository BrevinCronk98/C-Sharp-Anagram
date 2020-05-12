using System;
using System.Collections.Generic;


namespace Anagram.Model
{
    public class Ana
    {
        public char[] NewArray {get; set;}
        private static string _inputWord;
        private static List<string> _wordList = new List<string> {};
        private static List<char[]> _instances = new List<char[]>{};
        
        public Ana(string inputWord)
        {
            _wordList.Add(inputWord);

            char[] charArray = inputWord.ToCharArray();
            Array.Sort(charArray); 
            NewArray = CharArray;

            _instances.Add(word);
        }

        public static List<string> GetWords()
        {
            return _wordList;
        }

        public static List<char[]> GetInstances()
        {
            return _instances;
        }
       
    }
}