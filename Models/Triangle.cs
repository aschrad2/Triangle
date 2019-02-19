using System;

class Triangle
{
  private int SideOne;
  private int SideTwo;
  private int SideThree;

  public Triangle(int sideOne, int sideTwo, int sideThree)
  {
    SideOne = sideOne;
    SideTwo = sideTwo;
    SideThree = sideThree;
  }

  public int GetSideOne()
  {
    return SideOne;
  }

  public int GetSideTwo()
  {
    return SideTwo;
  }

  public int GetSideThree()
  {
    return SideThree;
  }

}
