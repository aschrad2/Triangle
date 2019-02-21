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
    Console.WriteLine("-----------------------");
    Console.WriteLine("What is first side?");
    int UserSideOne = int.Parse(Console.ReadLine());
    // string UserSideOne = Console.ReadLine();
    Console.WriteLine("What is the second side?");
    string UserSideTwo = Console.ReadLine();
    Console.WriteLine("What is the third side?");
    string UserSideThree = Console.ReadLine();
    Console.WriteLine("Your inputs for the triangle is " + UserSideOne + " and " + UserSideTwo + " and " + UserSideThree);
    // int result = int.Parse(UserSideOne) + int.Parse(UserSideTwo) + int.Parse(UserSideThree);
    // Console.WriteLine(result);

    // if (UserSideOne) {
      // if (UserSideOne == UserSideTwo && UserSideTwo == UserSideThree) {
        // string quote = "It is an equilateral triangle";
      // }

    // Console.WriteLine(quote);


    // }
  }
}
