using System.Linq;
using gamedev.helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gamedev
{
  [TestClass]
  public class SoundTest
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
    public void ShouldPlaySound()
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        string textSound = "dumb";
        string expectedValue = "play sound: " + textSound;

        Sound.PlaySound(textSound);

        Assert.IsTrue(consoleOutput.GetOuput().Any(x => x.Equals(expectedValue)), "Log does not show the msg: " + expectedValue);
      }
    }

    [TestMethod]
    public void ShouldNotPlaySound()
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        Sound.Muted = true;

        Sound.PlaySound("dumb");

        Assert.AreEqual("", consoleOutput.ToString());
      }
    }
  }
}
