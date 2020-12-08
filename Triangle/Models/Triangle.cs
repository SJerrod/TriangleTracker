using System;

namespace Tracker
{
  public class Triangle
  {
    public bool IsTriangle(int side1, int side2, int side3)
    {
      if ((side1 == side2) && (side1 == side3))
      {
        return true;
      }
      else if (((side1 == side2) && (side2 != side3)) || ((side1 == side3) && (side2 != side3)))
      {
        return true;
      }
      else if ((side1 != side2) && (side2 != side3) && (side1 != side3))
      {
        return true;
      }
      else if ((side1 + side2 < side3) || (side1 + side3 < side2) || (side2 + side3 < side1))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    
    public string stringIsTriangle(int side1, int side2, int side3)
    {
      if ((side1 + side2 < side3) || (side1 + side3 < side2) || (side2 + side3 < side1))
      {
        return "is not triangle";
      }
      else
      {
        return "Is Triangle";
      }
    }
  }
}