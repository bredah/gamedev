using System;
using System.Linq;
using System.Threading.Tasks;
using gamedev.helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gamedev
{
  [TestClass]
  public class WorldGameTest
  {

    [TestMethod]
    public async Task GenerateWorlds()
    {
      var resultObtained = await WorldGame.generateRandomWorld();
      
      Assert.AreEqual(WorldGame.MaxPlaces, resultObtained.Count());
      Assert.IsTrue(Enum.IsDefined(typeof(Place), resultObtained[0].Item1));
      Assert.IsTrue(Enum.IsDefined(typeof(Creature), resultObtained[0].Item2));
      Assert.IsTrue(Enum.IsDefined(typeof(Place), resultObtained[1].Item1));
      Assert.IsTrue(Enum.IsDefined(typeof(Creature), resultObtained[2].Item2));
      Assert.IsTrue(Enum.IsDefined(typeof(Place), resultObtained[2].Item1));
      Assert.IsTrue(Enum.IsDefined(typeof(Creature), resultObtained[2].Item2));
    } 
  }
}
