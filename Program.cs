﻿using System;
using RockPaperSci;


namespace RockPaperSci
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine(@" _____            _      _   _____                        _    _____      _                        
|  __ \          | |    | | |  __ \                      | |  / ____|    (_)                       
| |__) |___   ___| | __ | | | |__) |_ _ _ __   ___ _ __  | | | (___   ___ _ ___ ___  ___  _ __ ___ 
|  _  // _ \ / __| |/ / | | |  ___/ _` | '_ \ / _ \ '__| | |  \___ \ / __| / __/ __|/ _ \| '__/ __|
| | \ \ (_) | (__|   <  | | | |  | (_| | |_) |  __/ |    | |  ____) | (__| \__ \__ \ (_) | |  \__ \
|_|  \_\___/ \___|_|\_\ | | |_|   \__,_| .__/ \___|_|    | | |_____/ \___|_|___/___/\___/|_|  |___/
                        | |            | |               | |                                       
                        |_|            |_|               |_|                                       


");
      Console.WriteLine("Pick Your Weapon(Rock, Paper, Scissors)!");
      var name = Console.ReadLine();


    }
  }
}
