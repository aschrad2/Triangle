using System;
using System.Collections.Generic;

public class Triangle
{
  public int SideOne;
  public int SideTwo;
  public int SideThree;
}

class Program
{
  public static void Main()
  {
    // Reads in the 3 variables and saves them as integers
    Console.WriteLine("-----------------------");
    Console.WriteLine("What is first side?");
    int UserSideOne = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the second side?");
    int UserSideTwo = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the third side?");
    int UserSideThree = int.Parse(Console.ReadLine());

    // Ouputs the inputted sides
    Console.WriteLine("Your inputs for the triangle is " + UserSideOne + " and " + UserSideTwo + " and " + UserSideThree);
    int result = UserSideOne + UserSideTwo + UserSideThree;
    Console.WriteLine(result);

    if (UserSideOne > 0)
    {
      if (UserSideOne == UserSideTwo && UserSideTwo == UserSideThree)
      {
        string quote = "You've inputted the dimensions of an equilateral triangle";
        Console.WriteLine(quote);
      }
      else if (UserSideOne != UserSideTwo && UserSideTwo != UserSideThree && UserSideOne != UserSideThree)
      {
        string quote = "You've inputted the dimensions of a scalene triangle";
        Console.WriteLine(quote);
      }
      else if (UserSideOne == UserSideTwo && UserSideTwo != UserSideThree)
      {
        string quote = "You've inputted the dimensions of an isoleces triangle";
        Console.WriteLine(quote);
      }
      else if (UserSideOne != UserSideTwo && UserSideTwo == UserSideThree)
      {
        string quote = "You've inputted the dimensions of a triangle that is also an isoleces triangle";
        Console.WriteLine(quote);
      }
      else if (UserSideOne == UserSideThree && UserSideTwo != UserSideThree)
      {
        string quote = "You've inputted the dimensions of a triangle that is alsooooo an isoleces triangle!!!";
        Console.WriteLine(quote);
      }
    }
  }
}
