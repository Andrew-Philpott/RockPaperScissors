
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
    public void DetermineWinner_ComparesTwoStrings_Tie()
    {
      string playerOneChoice = "Rock";
      string playerTwoChoice = "Rock";
      string tie = "Tie";
      string answer = RockPaperScissorsGame.DetermineWinner(playerOneChoice, playerTwoChoice);
      Assert.AreEqual(tie, answer);
    }

    [TestMethod]
    public void ConvertPlayerChoiceToNumber_ConvertsInvalidChoce_NegativeOne()
    {
      int invalidChoice = -1;
      string playerChoice = "Rock";
      int answer = RockPaperScissorsGame.ConvertPlayerChoiceToNumber(playerChoice);
      Assert.AreEqual(invalidChoice, answer);
    }
  }
}