using System;
namespace RockPaperScissors.Models
{
  public static class RockPaperScissorsGame
  {

    public static string DetermineWinner(string playerOneAnswer, string playerTwoAnswer)
    {
      string winner = "Tie";
      return winner;
    }

    public static int ConvertPlayerChoiceToNumber(string playerChoice)
    {
      string playerChoiceLowerCase = playerChoice.ToLower();
      int playerChoiceConvertedToInt;
      switch (playerChoiceLowerCase)
      {
        case "rock":
          playerChoiceConvertedToInt = 2;
          break;
        case "scissors":
          playerChoiceConvertedToInt = 1;
          break;
        case "paper":
          playerChoiceConvertedToInt = 0;
          break;
        default:
          playerChoiceConvertedToInt = -1;
          break;
      }
      return playerChoiceConvertedToInt;
    }

    public static string GameResult(int playerOneChoice, int playerTwoChoice)
    {
      string outcome = "Tie";

      if (playerOneChoice == 0 && playerTwoChoice == 2)
      {
        outcome = "One";
      }
      else if (playerTwoChoice == 0 && playerOneChoice == 2)
      {
        outcome = "Two";
      }
      return outcome;
    }
  }
}