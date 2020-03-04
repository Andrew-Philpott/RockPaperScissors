using System;
using RockPaperScissors.Models;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class Program
  {

    public static void Main()
    {
      Console.WriteLine("Let's play RockPaperScissors.");
      Console.WriteLine("Player 1\'s turn. Please enter either \"Rock\", \"Paper\", or \"Scissors\"");
      string playerOneAnswer = Console.ReadLine();
      int playerOneAnswerValue = RockPaperScissorsGame.ConvertPlayerChoiceToNumber(playerOneAnswer);
      while (playerOneAnswerValue == -1)
      {
        Console.WriteLine("That is not a valid choice. Please try again. Enter either \"Rock\", \"Paper\", or \"Scissors\".");
        playerOneAnswer = Console.ReadLine();
        playerOneAnswerValue = RockPaperScissorsGame.ConvertPlayerChoiceToNumber(playerOneAnswer);
      }
      Console.WriteLine("Player 2\'s turn. Please enter either \"Rock\", \"Paper\", or \"Scissors\"");
      string playerTwoAnswer = Console.ReadLine();
      int playerTwoAnswerValue = RockPaperScissorsGame.ConvertPlayerChoiceToNumber(playerTwoAnswer);
      while (playerOneAnswerValue == -1)
      {
        Console.WriteLine("That is not a valid choice. Please try again. Enter either \"Rock\", \"Paper\", or \"Scissors\".");
        playerTwoAnswer = Console.ReadLine();
        playerTwoAnswerValue = RockPaperScissorsGame.ConvertPlayerChoiceToNumber(playerTwoAnswer);
      }
      int winner = RockPaperScissorsGame.GameResult(playerOneAnswerValue, playerTwoAnswerValue);
      if (winner != 0)
      {
        Console.WriteLine("Player " + winner + " wins!");
      }
      else
      {
        Console.WriteLine("Draw.");
      }
      Console.WriteLine("Press Enter to exit.");
      Console.ReadLine();
    }
  }
}