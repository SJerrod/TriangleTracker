using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker;

namespace Tracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_AllSidesEqual_True()
    {
      Triangle equalateral = new Triangle();
      Assert.AreEqual(true, equalateral.IsTriangle(2,2,2));
    }

    [TestMethod]
    public void IsTriangle_AllSidesEqual_False()
    {
      Triangle notEqual = new Triangle();
      Assert.AreEqual(false, notEqual.IsTriangle(2,1,1));
    }

    [TestMethod]
    public void IsTriangle_Isosceles_True()
    {
      Triangle isIsosceles = new Triangle();
      Assert.AreEqual(true, isIsosceles.IsTriangle(3,3,4));
    }

    [TestMethod]
    public void IsTriangle_Scalene_True()
    {
      Triangle isScalene = new Triangle();
      Assert.AreEqual(true, isScalene.IsTriangle(1,2,3));
    }

    [TestMethod]
    public void IsTriangle_NotTriangle_True()
    {
      Triangle isNotTriangle = new Triangle();
      Assert.AreEqual(true, isNotTriangle.IsTriangle(2,4,7));
    }

    [TestMethod]
    public void stringIsTriangle_NotTriangle_string()
    {
      Triangle isNotTriangle = new Triangle();
      Assert.AreEqual("is not triangle", isNotTriangle.stringIsTriangle(2,4,7));
    }
  }
}