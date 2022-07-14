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
      Scrabble newScrabble = new Scrabble("test");
      Assert.AreEqual(typeof(Scrabble), newScrabble.GetType());
    }

    

  }
}