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
        default:
          playerChoiceConvertedToInt = -1;
          break;
      }
      return playerChoiceConvertedToInt;
    }
  }
}