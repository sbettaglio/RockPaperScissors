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
        Console.WriteLine("Play again? ('yes' or 'no')");
        string playAgain = null;
        playAgain = Console.ReadLine().ToLower();
        while (playAgain != "yes" && playAgain != "no")
        {
          Console.WriteLine("I don't get it. Yes or no?");
          playAgain = Console.ReadLine().ToLower();
        }
        if (playAgain == "no")
        {
          play = false;
        }
      }






      //   else if (difficulty == "impossible")
      //   {
      //     Console.WriteLine("Choose Wisely");
      //     Console.WriteLine("rock, paper, scissors, lizard or spock?");
      //     var tool = Console.ReadLine().ToLower();
      //     if (tool != "rock" && tool != "paper" && tool != "scissors" && tool != "lizard" && tool != "spock")
      //     {
      //       Console.WriteLine("Invalid Selection. Please pick rock, paper or scissors");
      //       tool = Console.ReadLine().ToLower();
      //     }
      //     if (tool == "rock")
      //     {
      //       Random rnd = new Random();
      //       string[] rockLoses = { "spock", "paper" };
      //       int iRockLoses = rnd.Next(rockLoses.Length);
      //       Console.WriteLine("Your opponent chose {0}", rockLoses[iRockLoses]);
      //       Console.WriteLine("You lose");
      //     }
      //     else if (tool == "paper")
      //     {
      //       Random rnd = new Random();
      //       string[] paperLoses = { "lizard", "scissors" };
      //       int iPaperLoses = rnd.Next(paperLoses.Length);
      //       Console.WriteLine("Your opponent chose {0}", paperLoses[iPaperLoses]);
      //       Console.WriteLine("You lose!");
      //     }
      //     else if (tool == "scissors")
      //     {
      //       Random rnd = new Random();
      //       string[] scissorsLose = { "spock", "rock" };
      //       int iScissorsLose = rnd.Next(scissorsLose.Length);
      //       Console.WriteLine("Your opponent chose {0}", scissorsLose[iScissorsLose]);
      //       Console.WriteLine("You lose");
      //     }
      //     else if (tool == "lizard")
      //     {
      //       Random rnd = new Random();
      //       string[] lizardLoses = { "rock", "scissors" };
      //       int iLizardLoses = rnd.Next(lizardLoses.Length);
      //       Console.WriteLine("Your opponent chose {0}", lizardLoses[iLizardLoses]);
      //       Console.WriteLine("You lose!");
      //     }
      //     else if (tool == "spock")
      //     {
      //       Random rnd = new Random();
      //       string[] spockLoses = { "lizard", "paper" };
      //       int iSpockLoses = rnd.Next(spockLoses.Length);
      //       Console.WriteLine("Your opponent chose {0}", spockLoses[iSpockLoses]);
      //       Console.WriteLine("You lose!");
      //     }
      //   }

    }
  }
}
