using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public static Dictionary<string, int> _scrabbleScore = new Dictionary<string, int>(){
   {"a", 1},
   {"e", 1},
   {"i", 1},
   {"o", 1},
   {"u", 1},
   {"l", 1},
   {"n", 1},
   {"r", 1},
   {"s", 1},
   {"t", 1},
   {"d", 2},
   {"g", 2},
   {"b", 3},
   {"c", 3},
   {"m", 3},
   {"p", 3},
   {"y", 4},
   {"w", 4},
   {"v", 4},
   {"h", 4},
   {"f", 4},
   {"k", 5},
   {"x", 8},
   {"j", 8},
   {"q", 10},
   {"z", 10}
    };
    public static Dictionary<string, int> GetAll()
    {
      return _scrabbleScore;
    }
    public string Letters { get; set; }
    public int ValueOfLetter { get; set; }
    
    public Scrabble(string letters)
    {
      Letters = letters;
      // ValueOfLetter = valueOfLetter;
      // _scrabbleScore.Add(this);
    }
    public int CalculateScore(string userInput)
    {

      int totalValue = 0;
      char[] charArray = userInput.ToCharArray();
      Dictionary<string, int> result = Scrabble.GetAll();
    List<string> stringList = new List<string>{};
    foreach (char ch in charArray)
    {
     string kvp = ch.ToString();
     stringList.Add(kvp);
     
    }
    foreach(string Letter in stringList)
    {
      int value = result[Letter];
      totalValue += value;
    }
    return totalValue;
    }
  }
}