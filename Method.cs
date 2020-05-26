using System;
namespace RockPaperScissors
{
  public class Method
  {
    public string ChooseDifficulty()
    {
      Console.WriteLine("How tough do you want it?");
      Console.WriteLine("easy, normal or impossible?");
      var difficulty = Console.ReadLine().ToLower();
      while (difficulty != "easy" && difficulty != "normal" && difficulty != "impossible")
      {
        Console.WriteLine("Whoa there, we can't get that crazy! Please pick easy, normal or impossible");
        difficulty = Console.ReadLine().ToLower();
      }
      return difficulty;
    }
    public void RunDifficulty(string difficulty)
    {
      switch (difficulty)
      {
        case "easy":
          EasyDifficulty();
          break;
        case "impossible":
          ImpossibleDifficulty();
          break;
        default:
          NormalDifficulty();
          break;
      }
    }
    public void NormalDifficulty()
    {
      var tool = PlayerToolSelection();
      Random rnd = new Random();
      string[] choices = { "rock", "paper", "scissors", "lizard", "spock" };
      int mChoices = rnd.Next(choices.Length);
      Console.WriteLine("Your opponent choose: {0}", choices[mChoices]);
      var RanChoice = choices[mChoices];
      if (tool == RanChoice)
      {
        Console.WriteLine("You have tied");
      }
      else if ((tool == "rock" && (RanChoice == "paper" || RanChoice == "spock")) ||
      (tool == "paper" && (RanChoice == "scissors" || RanChoice == "lizard")) ||
      (tool == "scissors" && (RanChoice == "rock" || RanChoice == "spock")) ||
      (tool == "lizard" && (RanChoice == "rock" || RanChoice == "scissors")) ||
      (tool == "spock" && (RanChoice == "paper" || RanChoice == "lizard")))
      {
        Console.WriteLine("The computer wins!");
      }
      else if ((tool == "rock" && (RanChoice == "scissors" || RanChoice == "lizard")) ||
      (tool == "paper" && (RanChoice == "rock" || RanChoice == "spock")) ||
      (tool == "scissors" && (RanChoice == "paper" || RanChoice == "lizard")) ||
      (tool == "lizard" && (RanChoice == "paper" || RanChoice == "spock")) ||
      (tool == "spock" && (RanChoice == "rock" || RanChoice == "scissors")))
      {
        Console.WriteLine("You Win!");
      }
    }
    public void EasyDifficulty()
    {
      var tool = PlayerToolSelection();
      var result = "";
      switch (tool)
      {
        case "rock":
          result = ComputerRandomSelection("scissors", "lizard");
          break;
        case "paper":
          result = ComputerRandomSelection("spock", "rock");
          break;
        case "scissors":
          result = ComputerRandomSelection("lizard", "paper");
          break;
        case "lizard":
          result = ComputerRandomSelection("spock", "paper");
          break;
        default:
          result = ComputerRandomSelection("rock", "scissors");
          break;
      }
      Console.WriteLine($"Your opponent chose {result}");
      Console.WriteLine("You win!");
    }
    public void ImpossibleDifficulty()
    {
      var tool = PlayerToolSelection();
      var result = "";
      switch (tool)
      {
        case "rock":
          result = ComputerRandomSelection("spock", "paper");
          break;
        case "paper":
          result = ComputerRandomSelection("scissors", "lizard");
          break;
        case "scissors":
          result = ComputerRandomSelection("spock", "rock");
          break;
        case "lizard":
          result = ComputerRandomSelection("rock", "scissors");
          break;
        default:
          result = ComputerRandomSelection("lizard", "paper");
          break;
      }
      Console.WriteLine($"Your opponent chose {result}");
      Console.WriteLine("You lose!");
    }
    public string ComputerRandomSelection(string opponent1, string opponent2)
    {
      Random rnd = new Random();
      string[] results = { opponent1, opponent2 };
      int iResult = rnd.Next(results.Length);
      return results[iResult];
    }
    public string PlayerToolSelection()
    {
      Console.WriteLine("Choose Wisely");
      Console.WriteLine("rock, paper, scissors, lizard or spock?");
      var tool = Console.ReadLine().ToLower();
      while (tool != "rock" && tool != "paper" && tool != "scissors" && tool != "lizard" && tool != "spock")
      {
        Console.WriteLine("Invalid Selection. Please pick rock, paper, scissors, lizard or spock");
        tool = Console.ReadLine();
      }
      return tool;
    }
    public bool PlayAgain()
    {
      Console.WriteLine("Play again? ('yes' or 'no')");
      var playAgain = Console.ReadLine().ToLower();
      while (playAgain != "yes" && playAgain != "no")
      {
        Console.WriteLine("I don't get it. Yes or no?");
        playAgain = Console.ReadLine().ToLower();
      }
      return playAgain == "no" ? false : true;
    }
  }
}
