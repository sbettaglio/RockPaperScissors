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
        //As a user, I should see a welcome message.
        Console.WriteLine("Welcome to Rock, Paper Scissors!");
        //As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
        Console.WriteLine("How tough do you want it?");
        Console.WriteLine("easy, normal or impossible?");
        var difficulty = Console.ReadLine().ToLower();
        if (difficulty != "easy" && difficulty != "normal" && difficulty != "impossible")
        {
          Console.WriteLine("Whoa there, we can't get that crazy! Please pick easy, normal or impossible");
          difficulty = Console.ReadLine().ToLower();
        }
        if (difficulty == "normal")
        {
          Console.WriteLine("Choose Wisely");
          Console.WriteLine("rock, paper or scissors?");
          var tool = Console.ReadLine().ToLower();
          if (tool != "rock" && tool != "paper" && tool != "scissors")
          {
            Console.WriteLine("Invalid Selection. Please pick rock, paper or scissors");
            Console.ReadLine();
          }
          //The computer should randomly decide one of the options
          Random rnd = new Random();
          string[] choices = { "rock", "paper", "scissors" };
          int mChoices = rnd.Next(choices.Length);
          Console.WriteLine("Your opponent choose: {0}", choices[mChoices]);
          var RanChoice = choices[mChoices];
          //Your program should then decide who the winner is;
          //The user should then see the randomly selected option, as well as a win or lose message.
          if (tool == RanChoice)
          {
            Console.WriteLine("You have tied");
          }
          else if (tool == "rock" && RanChoice == "paper")
          {
            Console.WriteLine("The computer wins!");
          }
          else if (tool == "rock" && RanChoice == "scissors")
          {
            Console.WriteLine("You Win!");
          }
          else if (tool == "paper" && RanChoice == "rock")
          {
            Console.WriteLine("You win!");
          }
          else if (tool == "paper" && RanChoice == "scissors")
          {
            Console.WriteLine("The computer wins!");
          }
          else if (tool == "scissors" && RanChoice == "rock")
          {
            Console.WriteLine("The computer wins!");
          }
          else if (tool == "scissors" && RanChoice == "paper")
          {
            Console.WriteLine("You win!");
          }

          //add some validation around user input.
        }
        else if (difficulty == "easy")
        {
          Console.WriteLine("Choose Wisely");
          Console.WriteLine("rock, paper or scissors?");
          var tool = Console.ReadLine().ToLower();
          if (tool != "rock" && tool != "paper" && tool != "scissors")
          {
            Console.WriteLine("Invalid Selection. Please pick rock, paper or scissors");
            tool = Console.ReadLine().ToLower();
          }
          if (tool == "rock")
          {
            Console.WriteLine("Your opponent chose scissors.");
            Console.WriteLine("You Win!");
          }
          else if (tool == "paper")
          {
            Console.WriteLine("Your opponent chose rock");
            Console.WriteLine("You win!");
          }
          else if (tool == "scissors")
          {
            Console.WriteLine("Your opponent chose paper");
            Console.WriteLine("You win!");
          }
        }
        else if (difficulty == "impossible")
        {
          Console.WriteLine("Choose Wisely");
          Console.WriteLine("rock, paper or scissors?");
          var tool = Console.ReadLine().ToLower();
          if (tool != "rock" && tool != "paper" && tool != "scissors")
          {
            Console.WriteLine("Invalid Selection. Please pick rock, paper or scissors");
            tool = Console.ReadLine().ToLower();
          }
          if (tool == "rock")
          {
            Console.WriteLine("Your opponent chose paper.");
            Console.WriteLine("You lose");
          }
          else if (tool == "paper")
          {
            Console.WriteLine("Your opponent chose scissors");
            Console.WriteLine("You lose!");
          }
          else if (tool == "scissors")
          {
            Console.WriteLine("Your opponent chose rock");
            Console.WriteLine("You lose");
          }
        }
        Console.WriteLine("Play again? ('yes' or 'no')");
        string playAgain = null;
        playAgain = Console.ReadLine().ToLower();
        if (playAgain != "yes" && playAgain != "no")
        {
          Console.WriteLine("I don't get it. Yes or no?");
          playAgain = Console.ReadLine().ToLower();
        }
        if (playAgain == "no")
        {
          play = false;
        }
      }

    }
  }
}
