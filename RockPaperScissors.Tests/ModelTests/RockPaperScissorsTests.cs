
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System;
using System.Collections.Generic;

namespace RockPaperScissors.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {

    [TestMethod]
    public void DetermineWinner_ComparesTwoStrings_String()
    {
      string playerOneChoice = "Rock";
      string playerTwoChoice = "Rock";
      string tie = "Tie";
      string answer = RockPaperScissorsGame.DetermineWinner(playerOneChoice, playerTwoChoice);
      Assert.AreEqual(tie, answer);
    }
  }
}