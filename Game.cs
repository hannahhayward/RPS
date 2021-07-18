using System;
using System.Collections.Generic;
using System.Linq;

namespace RPS
{
  class Game
  {
    private int move = 0;
    private bool _playing = true;
    public int Wins {get; set;} = 0;
    public int Attempts {get; set;} = 0;
    Dictionary<string, int> moves = new Dictionary<string, int>()
    {
      { "rock" , 1},
      { "paper" , 2},
      { "scissors" , 3}
    };
    public void Start()
    {
      var computer = new Random();
      move = computer.Next(1,3);
      Console.WriteLine("let the game begin");
      PlayGame();
    }
    public void PlayGame()
    {
      while (_playing)
      {
        Console.Clear();
        Console.WriteLine($@"
        Attempts: {Attempts}
        Wins: {Wins} ");
        Console.WriteLine("Enter your move..");
        string userMove = Console.ReadLine();
        if(userMove == "q")
        {
          _playing = false;
          Console.WriteLine("see you next time");
          return;
        } 
        if (moves.ContainsKey($@"{userMove}"))
        {
          int play = moves[$@"{userMove}"];
          if(move > play)
          {
            Console.WriteLine("you win");
            Wins ++;
            Attempts ++;
            return;
          }
          else
          {
              Console.WriteLine("you lose");
              Attempts ++;
              return;
          }
        }
        if (!moves.ContainsKey($@"{userMove}"))
        {
          Console.WriteLine("that move is not an option, must choose from 'rock', 'paper', or 'scissors'");
        }
      }
    }
  }
}