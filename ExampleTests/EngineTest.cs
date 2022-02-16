using System;
using System.Linq;
using System.Threading.Tasks;
using gamedev.helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gamedev
{
  [TestClass]
  public class EngineTest
  {

    [ClassInitialize]
    public static void setup(TestContext testContext)
    {
      Helper.SkipDelay = true;
    }

    [ClassCleanup]
    public static void tearDown()
    {
      Helper.SkipDelay = false;
    }

    [TestMethod]
    public async Task ShouldEngineRunning()
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        await Engine.MainAsync();
        // Shows at least one of the places
        Assert.IsTrue(Enum.GetValues(typeof(Place)).Cast<Place>().Any(place => consoleOutput.GetOuput().Any(line => line.Contains(place.GetString()))));
        // Shows at least one of the creatures
        Assert.IsTrue(Enum.GetValues(typeof(Creature)).Cast<Creature>().Any(creature => consoleOutput.GetOuput().Any(line => line.Contains(creature.GetString())))); 
      }
    }


  }
}
