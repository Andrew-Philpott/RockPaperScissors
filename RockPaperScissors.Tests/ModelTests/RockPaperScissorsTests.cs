
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
    public void GameResult_ReturnsStringDrawAsDefaultInt_Zero()
    {
      int playerOneChoice = 2;
      int playerTwoChoice = 2;
      int draw = 0;
      int answer = RockPaperScissorsGame.GameResult(playerOneChoice, playerTwoChoice);
      Assert.AreEqual(draw, answer);
    }

    [TestMethod]
    public void GameResult_ReturnIntOneIfPlayerOnesChoiceEqualsZeroAndPlayerTwosChoiceEqualsIntTwo_One()
    {
      int playerOneChoice = 0;
      int playerTwoChoice = 2;
      int one = 1;
      int answer = RockPaperScissorsGame.GameResult(playerOneChoice, playerTwoChoice);
      Assert.AreEqual(one, answer);
    }
    [TestMethod]
    public void GameResult_ReturnsIntTwoIfPlayerTwosChoiceEqualsIntZeroAndPlayerOnesChoiceEqulsIntTwo_Two()
    {
      int playerOneChoice = 2;
      int playerTwoChoice = 0;
      int two = 2;
      int answer = RockPaperScissorsGame.GameResult(playerOneChoice, playerTwoChoice);
      Assert.AreEqual(two, answer);
    }

    [TestMethod]
    public void GameResult_ReturnsIntOneWhenPlayerOnesChoiceIsGreaterThanPlayerTwosChoice_One()
    {
      int playerOneChoice = 2;
      int playerTwoChoice = 1;
      int one = 1;
      int answer = RockPaperScissorsGame.GameResult(playerOneChoice, playerTwoChoice);
      Assert.AreEqual(one, answer);
    }

    [TestMethod]
    public void GameResult_ReturnsIntTwoWhenPlayerTwosChoiceIsGreaterThanPlayerOnesChoice_Two()
    {
      int playerOneChoice = 1;
      int playerTwoChoice = 2;
      int two = 2;
      int answer = RockPaperScissorsGame.GameResult(playerOneChoice, playerTwoChoice);
      Assert.AreEqual(two, answer);
    }
  }
}