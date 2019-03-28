using System;

namespace RPSmARCH
{
  class Program
  {
    static void Main(string[] args)
    {
      int secret;
      bool won = false;

      Console.Clear();
      Console.WriteLine("Are you ready to play RPS? Enter your name");
      string name = Console.ReadLine();
      Console.WriteLine("Welcome to the game " + name);
      bool gotUserName = true;
      if (gotUserName)
      {
        Console.WriteLine("What is your choice? play 1=rock, 2=paper or 3=scissors");
        Random rnd = new Random();
        secret = rnd.Next(1, 4);
        Console.WriteLine(secret);
        while (!won)
        {
          string guessString = Console.ReadLine();
          int guess;
          if (Int32.TryParse(guessString, out guess))
          {
            if (1 == secret && 1 == guess)
            {
              Console.WriteLine("You Tied on Rock");
            }
            if (2 == secret && 2 == guess)
            {
              Console.WriteLine("You Tied on Paper");
            }
            if (3 == secret && 3 == guess)
            {
              Console.WriteLine("You Tied on Scissors");
            }
            else if (1 == secret && 2 == guess)
            {
              Console.WriteLine("You Win Paper Covers Rock!");
              won = true;
            }
            else if (2 == secret && 1 == guess)
            {
              Console.WriteLine("You Lose Paper Covers Rock!");

            }
            else if (guess == 3 && 1 == secret)
            {
              Console.WriteLine("You Lose Rock Smashes Scissors!");
            }
            else if (guess == 1 && 3 == secret)
            {
              Console.WriteLine("You Win Rock Smashes Scissors!");
              won = true;
            }

          }
          //   }
          //   string play = Console.ReadLine();
          //   Console.WriteLine("You Chose " + play);
          //   bool pick = true;
          //   Random mathRandomTool = new Random();
          //   while (pick)
          //   {
          //     System.Console.Write("Enter your choice for play 1=rock, 2=paper or 3=scissors");
          //     string guessString = Console.ReadLine();
          //     int guess;
          //     if (Int)
          //       string input = Console.ReadLine().ToLower();
          //     string[4] arrInputs = input.
        }
      }
    }
  }
}

