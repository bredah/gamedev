using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public async Task ShouldPlayAsyncSound()
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        string textSound = "dumb";
        string expectedValue = "play sound: " + textSound;

        await Sound.PlaySound(textSound);

        Assert.IsTrue(consoleOutput.GetOuput().Any(x => x.Equals(expectedValue)), "Log does not show the msg: " + expectedValue);
      }
    }

    [TestMethod]
    public async Task ShouldPlayAsyncSoundInParallel()
    {
      var sounds = new List<Tuple<string, string>>();
      sounds.Add(new Tuple<string, string>("pong", "play sound: pong"));
      sounds.Add(new Tuple<string, string>("toc", "play sound: toc"));

      using (var consoleOutput = new ConsoleOutput())
      {
        string textSound = "dumb";
        string expectedValue = "play sound: " + textSound;

        await Task.WhenAll(new[]{
          Sound.PlaySound(sounds[0].Item1),
          Sound.PlaySound(sounds[1].Item1)
        });

        Assert.IsTrue(consoleOutput.GetOuput().Any(x => x.Equals(sounds[0].Item2)), "Log does not show the msg: " + sounds[0].Item2);
        Assert.IsTrue(consoleOutput.GetOuput().Any(x => x.Equals(sounds[1].Item2)), "Log does not show the msg: " + sounds[1].Item2);
      }
    }

    [TestMethod]
    public async Task ShouldNotPlaySound()
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        Sound.Muted = true;

        await Sound.PlaySound("dumb");

        Assert.AreEqual("", consoleOutput.ToString());
      }
    }
  }
}
