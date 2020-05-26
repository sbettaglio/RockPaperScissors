using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      bool play = true;
      while (play)
      {

        Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!");
        //   Console.WriteLine("How tough do you want it?");
        //   Console.WriteLine("easy, normal or impossible?");
        //   var difficulty = Console.ReadLine().ToLower();
        //   if (difficulty != "easy" && difficulty != "normal" && difficulty != "impossible")
        //   {
        //     Console.WriteLine("Whoa there, we can't get that crazy! Please pick easy, normal or impossible");
        //     difficulty = Console.ReadLine().ToLower();
        //   }
        //   if (difficulty == "normal")
        //   {
        //     Console.WriteLine("Choose Wisely");
        //     Console.WriteLine("rock, paper, scissors, lizard or spock?");
        //     var tool = Console.ReadLine().ToLower();
        //     if (tool != "rock" && tool != "paper" && tool != "scissors" && tool != "lizard" && tool != "spock")
        //     {
        //       Console.WriteLine("Invalid Selection. Please pick rock, paper, scissors, lizard or spock");
        //       tool = Console.ReadLine();
        //     }
        //     //The computer should randomly decide one of the options
        //     Random rnd = new Random();
        //     string[] choices = { "rock", "paper", "scissors", "lizard", "spock" };
        //     int mChoices = rnd.Next(choices.Length);
        //     Console.WriteLine("Your opponent choose: {0}", choices[mChoices]);
        //     var RanChoice = choices[mChoices];
        //     //Your program should then decide who the winner is;
        //     //The user should then see the randomly selected option, as well as a win or lose message.
        //     if (tool == RanChoice)
        //     {
        //       Console.WriteLine("You have tied");
        //     }
        //     else if (tool == "rock" && RanChoice == "paper")
        //     {
        //       Console.WriteLine("The computer wins!");
        //     }
        //     else if (tool == "rock" && RanChoice == "scissors")
        //     {
        //       Console.WriteLine("You Win!");
        //     }
        //     else if (tool == "rock" && RanChoice == "lizard")
        //     {
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "rock" && RanChoice == "spock")
        //     {
        //       Console.WriteLine("The computer wins!");
        //     }
        //     else if (tool == "paper" && RanChoice == "rock")
        //     {
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "paper" && RanChoice == "scissors")
        //     {
        //       Console.WriteLine("The computer wins!");
        //     }
        //     else if (tool == "paper" && RanChoice == "lizard")
        //     {
        //       Console.WriteLine("The computer wins!");
        //     }
        //     else if (tool == "paper" && RanChoice == "spock")
        //     {
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "scissors" && RanChoice == "rock")
        //     {
        //       Console.WriteLine("The computer wins!");
        //     }
        //     else if (tool == "scissors" && RanChoice == "paper")
        //     {
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "scissors" && RanChoice == "lizard")
        //     {
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "scissors" && RanChoice == "spock")
        //     {
        //       Console.WriteLine("The computer wins!");
        //     }
        //     else if (tool == "lizard" && RanChoice == "rock")
        //     {
        //       Console.WriteLine("The computer wins!");
        //     }
        //     else if (tool == "lizard" && RanChoice == "paper")
        //     {
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "lizard" && RanChoice == "scissors")
        //     {
        //       Console.WriteLine("The computer wins!");
        //     }
        //     else if (tool == "lizard" && RanChoice == "spock")
        //     {
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "spock" && RanChoice == "rock")
        //     {
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "spock" && RanChoice == "paper")
        //     {
        //       Console.WriteLine("The computer wins!");
        //     }
        //     else if (tool == "spock" && RanChoice == "scissors")
        //     {
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "spock" && RanChoice == "lizard")
        //     {
        //       Console.WriteLine("The computer wins!");
        //     }

        //     //add some validation around user input.
        //   }
        //   else if (difficulty == "easy")
        //   {
        //     Console.WriteLine("Choose Wisely");
        //     Console.WriteLine("rock, paper, scissors, lizard or spock?");
        //     var tool = Console.ReadLine().ToLower();
        //     if (tool != "rock" && tool != "paper" && tool != "scissors" && tool != "lizard" && tool != "spock")
        //     {
        //       Console.WriteLine("Invalid Selection. Please pick rock, paper or scissors, lizard or spock");
        //       tool = Console.ReadLine().ToLower();
        //     }
        //     if (tool == "rock")
        //     {
        //       Random rnd = new Random();
        //       string[] rockWins = { "scissors", "lizard" };
        //       int iRockWins = rnd.Next(rockWins.Length);
        //       Console.WriteLine("Your opponent chose {0}", rockWins[iRockWins]);
        //       Console.WriteLine("You Win!");
        //     }
        //     else if (tool == "paper")
        //     {
        //       Random rnd = new Random();
        //       string[] paperWins = { "spock", "rock" };
        //       int iPaperWins = rnd.Next(paperWins.Length);
        //       Console.WriteLine("Your opponent chose {0}", paperWins[iPaperWins]);
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "scissors")
        //     {
        //       Random rnd = new Random();
        //       string[] scissorsWin = { "lizard", "paper" };
        //       int iScissorsWin = rnd.Next(scissorsWin.Length);
        //       Console.WriteLine("Your opponent chose {0}", scissorsWin[iScissorsWin]);
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "lizard")
        //     {
        //       Random rnd = new Random();
        //       string[] lizardWins = { "spock", "paper" };
        //       int iLizardWins = rnd.Next(lizardWins.Length);
        //       Console.WriteLine("Your opponent chose {0}", lizardWins[iLizardWins]);
        //       Console.WriteLine("You win!");
        //     }
        //     else if (tool == "spock")
        //     {
        //       Random rnd = new Random();
        //       string[] spockWins = { "rock", "scissors" };
        //       int iSpockWins = rnd.Next(spockWins.Length);
        //       Console.WriteLine("Your opponent chose {0}", spockWins[iSpockWins]);
        //       Console.WriteLine("You win!");
        //     }

        //   }
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
        //   Console.WriteLine("Play again? ('yes' or 'no')");
        //   string playAgain = null;
        //   playAgain = Console.ReadLine().ToLower();
        //   if (playAgain != "yes" && playAgain != "no")
        //   {
        //     Console.WriteLine("I don't get it. Yes or no?");
        //     playAgain = Console.ReadLine().ToLower();
        //   }
        //   if (playAgain == "no")
        //   {
        //     play = false;
        //   }
      }
    }
  }
}