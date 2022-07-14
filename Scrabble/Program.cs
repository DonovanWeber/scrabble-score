using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  class Program
  {
    static void Main()
    {
     Console.WriteLine("Welcome to Scrabble Scorer!");
     FindTheScore();
    }
    static void FindTheScore()
    {
      Console.WriteLine("Enter a word");
      string userInput = Console.ReadLine();
      Scrabble userScore = new Scrabble(userInput);
      Console.WriteLine("Your score for " + userInput + " " +"is " + userScore.CalculateScore(userInput));
      Console.WriteLine("Would you like to calculate another word if so press 'Enter' or Type 'Y' for yes ");
      string answer = Console.ReadLine();
      if (answer == "y" || answer == "Y")
      {
        FindTheScore();
      }
      else
      {
        Main();
      }
    }
  }
}