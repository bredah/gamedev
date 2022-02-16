using System.Linq;
using gamedev.helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gamedev
{
  [TestClass]
  public class WorldMapTest
  {
    [TestInitialize]
    public void SetUp()
    {
      Sound.Muted = false;
    }

    [ClassCleanup]
    public static void TestFixtureTearDown()
    {
      Sound.Muted = false;
    }

    [TestMethod]
    public void GenerateWorlds()
    {
      var resultObtained = WorldMap.generateWorlds();
      
      Assert.AreEqual(WorldMap.MaxWorlds, resultObtained.Count());
      Assert.AreEqual(WorldMap.WorldSize, resultObtained[0].Length);
    } 
  }
}
