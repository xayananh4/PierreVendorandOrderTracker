using System.Collections.Generic;
namespace ShapeTracker.Models
{
  public class Triangle
  {
    private int _side1;
    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }
    public int Side2 { get; set; }
    private int _side3;
    public int Side3
    {
      get { return _side3; }
      set { _side3 = value; }
    }
    private static List<Triangle> _instances = new List<Triangle> { };

    public Triangle(int length1, int length2, int length3)
    {
      _side1 = length1;
      Side2 = length2;
      _side3 = length3;
      _instances.Add(this);
    }

    // public int GetSide3()
    // {
    //   return _side3;
    // }

    // public void SetSide3(int newValue)
    // {
    //   _side3 = newValue;
    // }

    public string CheckType()
    {
      if ((Side1 > (Side2 + Side3)) || (Side2 > (Side1 + Side3)) || (Side3 > (Side1 + Side2)))
      {
        return "not a triangle";
      }
      else if ((Side1 != Side2) && ((Side1 != Side3)) && ((Side2 != Side3)))
      {
        return "scalene triangle";
      }
      else if ((Side1 == Side2) && (Side1 == Side3))
      {
        return "equilateral triangle";
      }
      else
      {
        return "isosceles triangle";
      }
    }

    public static List<Triangle> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}