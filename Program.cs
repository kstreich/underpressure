using System;

namespace challenge
{
  class Program
  {
    static void Main(string[] args)
    {
      bool playing = true;
      Console.WriteLine("Guess the random number between 1-100");

      Random rnd = new Random();
      int num = rnd.Next(1, 101);
      Console.WriteLine(num);

      while (playing != false)
      {
        // int guess = Convert.ToInt32(Console.ReadLine());
        string guessedStr = Console.ReadLine();
        int guess;
        if (!Int32.TryParse(guessedStr, out guess))
          if (guess > num)
          {
            System.Console.WriteLine("Too High, guess again");
          }
          else if (guess < num)
          {
            System.Console.WriteLine("Too Low, guess again");
          }
          else if (guess == num)
          {
            System.Console.WriteLine("You Guessed Correctly!");
            System.Console.WriteLine("Play again? (y/n)");

          }
      }
    }
  }
}
