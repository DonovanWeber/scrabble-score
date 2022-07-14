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
      newDictionaryScrabble.Add(letter, valueOfLetter);
      int testScrabbleValue = newDictionaryScrabble["a"];
      
      Dictionary<string, int> result = Scrabble.GetAll();
      int finalResult = result["a"];
      Assert.AreEqual(testScrabbleValue, finalResult);
    }
    [TestMethod]
    public void GetKeyValues_ReturnTotalValue_Int()
    {
    string testWord = "add";
    char[] testCharArrayWord = testWord.ToCharArray();
    Dictionary<string, int> testDictionary = new  Dictionary<string, int>();
    testDictionary.Add("a", 1);
    testDictionary.Add("d", 2);
    List<string> stringList = new List<string>{};
    foreach (char ch in testCharArrayWord)
    {
     string kvp = ch.ToString();
     stringList.Add(kvp);
     
    }
    int totalValue = 0;
    foreach(string Letter in stringList)
    {
      int value = testDictionary[Letter];
      totalValue += value;
    }
    int resultTotalValue = 0;
    Dictionary<string, int> result = Scrabble.GetAll();
    foreach(string Letter in stringList)
    {
      int value = result[Letter];
      resultTotalValue += value;
    }
    Console.WriteLine(totalValue);
    Assert.AreEqual(totalValue, resultTotalValue);
    }
  }
}