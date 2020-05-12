using System;
using System.Collections.Generic;


namespace Anagram.Model
{
    public class Anagram
    {
       private string _inputWord
       private string _AnaWords


       public Anagram(string inputWord, string AnaWords)
       {
           _inputWord = inputWord;
           _AnaWords = AnaWords;
       }

       public string GetWord()
       {
           return _inputWord;
       }

       public string GetAnagrams()
       {
           return _AnaWords;
       }
    }
}