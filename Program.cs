using System;
using System.Collections.Generic;

namespace Dealership {

  public class Program
  {
    public static void Main()
    {
      Triangle equilateral = new Triangle(3, 3, 3);
      Triangle isoleces = new Triangle(2, 2, 1);
      Triangle scalene = new Triangle(1, 2, 3);

      List<Triangle> Triangle = new List<Triangle>() {equilateral, isoleces, scalene}

      Console.WriteLine("")
    }
  }
}
