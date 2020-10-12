using System;


namespace RPS.Controllers
{
  class GameController
  {

    //PROPERTIES
    public string PlayerName { get; private set; }
    public string PlayerWeapon { get; private set; }
    public string ComputerWeapon { get; private set; }
    public bool Fighting { get; set; } = true;

    public void Run()
    {
      while (Fighting)
      {
        GetUserInput();
      }
    }

    private void GetUserInput()
    {
      System.Console.WriteLine("What Do You Want To Do?(Fight, Run)");
      var input = Console.ReadLine().ToLower();

      Console.Clear();
      switch (input)
      {
        case "quit":
        case "close":
        case "run":
          Fighting = false;
          System.Console.WriteLine("Run, Run Away You Little Coward!!!");
          break;
        case "fight":
          Battle();
          break;
        default:
          System.Console.WriteLine("Invalid Selection");
          break;
      }
    }
    private void Battle()
    {
      Console.WriteLine("Pick Your Weapon(Rock, Paper, Scissors)!");
      var Weapon = Console.ReadLine();


    }
  }
}