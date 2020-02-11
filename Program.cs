using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      //As a user, I should see a welcome message.
      Console.WriteLine("Welcome to Rock, Paper Scissors!");
      //As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
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
  }
}
