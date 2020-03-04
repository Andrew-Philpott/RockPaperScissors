
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
    [TestMethod]
    public void GameResult_ReturnsStringTieAsDefault_Tie()
    {
      int playerOneChoice = 2;
      int playerTwoChoice = 1;
      string tie = "Tie";
      string answer = RockPaperScissorsGame.GameResult(playerOneChoice, playerTwoChoice);
      Assert.AreEqual(tie, answer);
    }

    [TestMethod]
    public void GameResult_ReturnsStringOneIfPlayerOnesChoiceEqualsZeroAndPlayerTwosChoiceEqulsTwo_One()
    {
      int playerOneChoice = 0;
      int playerTwoChoice = 2;
      string one = "One";
      string answer = RockPaperScissorsGame.GameResult(playerOneChoice, playerTwoChoice);
      Assert.AreEqual(one, answer);
    }
    [TestMethod]
    public void GameResult_ReturnsStringTwoIfPlayerTwosChoiceEqualsZeroAndPlayerOnesChoiceEqulsTwo_Two()
    {
      int playerOneChoice = 2;
      int playerTwoChoice = 0;
      string two = "Two";
      string answer = RockPaperScissorsGame.GameResult(playerOneChoice, playerTwoChoice);
      Assert.AreEqual(two, answer);
    }
  }
}