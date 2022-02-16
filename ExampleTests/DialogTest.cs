using System;
using System.Linq;
using System.Threading.Tasks;
using gamedev.helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gamedev
{
  [TestClass]
  public class DialogTest
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
    public async Task ShouldPresentPlaceDialog()
    {
      Tuple<Place, Creature> testData = new Tuple<Place, Creature>(Place.FLOREST, Creature.DOLPHIN);
      using (var consoleOutput = new ConsoleOutput())
      {
        await Dialog.TellHistoryAsync(testData);
        Assert.IsTrue(consoleOutput.GetOuput().Any(x => x.Contains(testData.Item1.GetString())), "Log does not show the place: " + testData.Item1.GetString());
        Assert.IsTrue(consoleOutput.GetOuput().Any(x => x.Contains(testData.Item2.GetString())), "Log does not show the creatjure: " + testData.Item2.GetString());
      }
    }


  }
}
