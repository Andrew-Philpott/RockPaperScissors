using System;
namespace RockPaperScissors.Models
{
  public static class RockPaperScissorsGame
  {

    public static string DetermineWinner(string playerOneAnswer, string playerTwoAnswer)
    {
      string winner = "Draw";
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

    public static int GameResult(int playerOneChoice, int playerTwoChoice)
    {
      int outcome = 0;

      if (playerOneChoice == 0 && playerTwoChoice == 2)
      {
        outcome = 1;
      }
      else if (playerTwoChoice == 0 && playerOneChoice == 2)
      {
        outcome = 2;
      }
      else if (playerOneChoice > playerTwoChoice)
      {
        outcome = 1;
      }
      else if (playerTwoChoice > playerOneChoice)
      {
        outcome = 2;
      }

      return outcome;
    }
  }
}