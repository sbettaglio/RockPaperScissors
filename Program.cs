using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      var logic = new Method();
      bool play = true;
      while (play)
      {

        Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
        var difficulty = logic.ChooseDifficulty();
        logic.RunDifficulty(difficulty);
        play = logic.PlayAgain();
      }
    }
  }
}
