using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests 
{
  [TestClass]
  public class ScrabbleTests 
  {
    [TestMethod]
    public void ScrabbleConstructor_CreatesInstanceOfScrabble_Scrabble()
    {
      Scrabble newScrabble = new Scrabble("a", 1);
      Assert.AreEqual(typeof(Scrabble), newScrabble.GetType());
    }
    [TestMethod]
    public void GetLetters_ReturnsLetters_String()
    {
      string letter = "a";
      int valueOfLetter = 1;
      Scrabble newScrabble = new Scrabble(letter, valueOfLetter);
      string result = newScrabble.Letters;
      Assert.AreEqual(result, letter);
    }
    [TestMethod]
    public void GetValues_ReturnValues_int()
    {
      string letter = "a";
      int valueOfLetter = 1;
      Scrabble newScrabble = new Scrabble(letter, valueOfLetter);
      Dictionary<string, int> newDictionaryScrabble = new Dictionary<string, int>();
      newDictionaryScrabble.Add("a", 1);
      int testScrabbleValue = newDictionaryScrabble["a"];
      Dictionary<string, int> result = Scrabble.GetAll();
      int finalResult = result["a"];
     
      Assert.AreEqual(testScrabbleValue, finalResult);
    }

  }
}