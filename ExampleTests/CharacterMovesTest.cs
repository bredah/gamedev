using System;
using System.Collections.Generic;
using System.Linq;
using gamedev.helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gamedev
{
  [TestClass]
  public class CharacterMovesTest
  {

    [TestInitialize]
    public void Setup()
    {
      Sound.Muted = false;
    }

    [TestMethod]
    [DynamicData(nameof(TestDataDirections), DynamicDataSourceType.Method)]
    public void ShouldCharacterWalkToDirection(Direction direction)
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        string expectedAction = "walk to: " + direction.GetString();
        string expectedActionSound = "play sound: walk";

        CharacterMoves.Walk(direction);

        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedAction.Contains), String.Format("Expected action: {0} - Received: {1}", expectedAction, consoleOutput));
        Assert.IsFalse(Sound.Muted, "It is expected that the sound is not muted");
        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedActionSound.Contains), String.Format("Expected sound: {0} - Received: {1}", expectedActionSound, consoleOutput));
      }
    }

    [TestMethod]
    [DynamicData(nameof(TestDataDirections), DynamicDataSourceType.Method)]
    public void ShouldCharacterJumpToDirection(Direction direction)
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        string expectedAction = "jump to: " + direction.GetString();
        string expectedActionSound = "play sound: jump";

        CharacterMoves.Jump(direction);

        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedAction.Contains), String.Format("Expected action: {0} - Received: {1}", expectedAction, consoleOutput));
        Assert.IsFalse(Sound.Muted, "It is expected that the sound is not muted");
        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedActionSound.Contains), String.Format("Expected sound: {0} - Received: {1}", expectedActionSound, consoleOutput));
      }
    }

    [TestMethod]
    public void ShouldCharacterJump_WithoutMoving()
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        string expectedAction = "jump";
        string expectedActionSound = "play sound: jump";

        CharacterMoves.Jump();

        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedAction.Contains), String.Format("Expected action: {0} - Received: {1}", expectedAction, consoleOutput));
        Assert.IsFalse(Sound.Muted, "It is expected that the sound is not muted");
        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedActionSound.Contains), String.Format("Expected sound: {0} - Received: {1}", expectedActionSound, consoleOutput));
      }
    }

    [TestMethod]
    [DynamicData(nameof(TestDataDirections), DynamicDataSourceType.Method)]
    public void ShouldCharacterCrouchToDirection(Direction direction)
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        string expectedAction = "crouch to: " + direction.GetString();
        string expectedActionSound = "play sound: crouch";

        CharacterMoves.Crouch(direction);

        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedAction.Contains), String.Format("Expected action: {0} - Received: {1}", expectedAction, consoleOutput));
        Assert.IsFalse(Sound.Muted, "It is expected that the sound is not muted");
        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedActionSound.Contains), String.Format("Expected sound: {0} - Received: {1}", expectedActionSound, consoleOutput));
      }
    }

    [TestMethod]
    public void ShouldCharacterCrouch_WithoutMoving()
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        string expectedAction = "crouch";

        CharacterMoves.Crouch();

        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedAction.Contains), String.Format("Expected action: {0} - Received: {1}", expectedAction, consoleOutput));
        Assert.IsFalse(Sound.Muted, "It is expected that the sound is not muted");
        Assert.AreEqual(1, consoleOutput.GetOuput().Length, "It is expected not more then 1 action");
      }
    }

    [TestMethod]
    [DynamicData(nameof(TestDataDirections), DynamicDataSourceType.Method)]
    public void ShouldCharacterCrawlToDirection(Direction direction)
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        string expectedAction = "crawl to: " + direction.GetString();
        string expectedActionSound = "play sound: crawl";

        CharacterMoves.Crawl(direction);

        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedAction.Contains), String.Format("Expected action: {0} - Received: {1}", expectedAction, consoleOutput));
        Assert.IsFalse(Sound.Muted, "It is expected that the sound is not muted");
        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedActionSound.Contains), String.Format("Expected sound: {0} - Received: {1}", expectedActionSound, consoleOutput));
      }
    }

    [TestMethod]
    public void ShouldCharacterCrawl_WithoutMoving()
    {
      using (var consoleOutput = new ConsoleOutput())
      {
        string expectedAction = "crawl";

        CharacterMoves.Crawl();

        Assert.IsTrue(consoleOutput.GetOuput().Any(expectedAction.Contains), String.Format("Expected action: {0} - Received: {1}", expectedAction, consoleOutput));
        Assert.IsFalse(Sound.Muted, "It is expected that the sound is not muted");
        Assert.AreEqual(1, consoleOutput.GetOuput().Length, "It is expected not more then 1 action");
      }
    }


    public static IEnumerable<object[]> TestDataDirections()
    {
      yield return new object[] { Direction.FOWARD };
      yield return new object[] { Direction.BACK };
      yield return new object[] { Direction.LEFT };
      yield return new object[] { Direction.RIGHT };
    }
  }

}
