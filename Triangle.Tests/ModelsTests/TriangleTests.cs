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
  }
}