
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
    public void ConvertPlayerChoiceToNumber_ConvertsInvalidChoiceSting_NegativeOne()
    {
      int invalidChoice = -1;
      string playerChoice = "Rck";
      int answer = RockPaperScissorsGame.ConvertPlayerChoiceToNumber(playerChoice);
      Assert.AreEqual(invalidChoice, answer);
    }

    [TestMethod]
    public void ConvertPlayerChoiceToNumber_ConvertsRockStringToTwo_Two()
    {
      int rockInt = 2;
      string playerChoice = "Rock";
      int answer = RockPaperScissorsGame.ConvertPlayerChoiceToNumber(playerChoice);
      Assert.AreEqual(rockInt, answer);
    }
    [TestMethod]
    public void ConvertPlayerChoiceToNumber_ConvertsScissorsStringToOne_One()
    {
      int scissorsInt = 1;
      string playerChoice = "Scissors";
      int answer = RockPaperScissorsGame.ConvertPlayerChoiceToNumber(playerChoice);
      Assert.AreEqual(scissorsInt, answer);
    }

    [TestMethod]
    public void ConvertPlayerChoiceToNumber_ConvertsPaperStringToZero_Zero()
    {
      int paperInt = 0;
      string playerChoice = "Paper";
      int answer = RockPaperScissorsGame.ConvertPlayerChoiceToNumber(playerChoice);
      Assert.AreEqual(paperInt, answer);
    }
  }
}