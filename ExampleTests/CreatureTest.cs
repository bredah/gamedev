using System;
using System.Collections.Generic;
using System.Linq;
using gamedev.helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gamedev
{
  [TestClass]
  public class CreatureTest
  {

    [TestInitialize]
    public void Setup()
    {
      Sound.Muted = false;
    }

    [TestMethod]
    [DynamicData(nameof(TestData), DynamicDataSourceType.Method)]
    public void ShouldCreateHasNameAndSound(Creature creature)
    {
      string creatureName = creature.GetString();
      string creatureSound = creature.GetSound();

      Assert.IsFalse(String.IsNullOrEmpty(creatureName));
      Assert.IsFalse(String.IsNullOrEmpty(creatureSound));
    }

    [TestMethod]
    public void ShouldCreateNotExists()
    {
      Creature creature = (Creature)9;
      string creatureName = creature.GetString();
      string creatureSound = creature.GetSound();

      Assert.IsFalse(String.IsNullOrEmpty(creatureName));
      Assert.AreEqual("this creature does not exists", creatureName);
      Assert.IsFalse(String.IsNullOrEmpty(creatureSound));
      Assert.AreEqual("this creature does not exists", creatureSound);
    }



    public static IEnumerable<object[]> TestData()
    {
      yield return new object[] { Creature.DOLPHIN };
      yield return new object[] { Creature.DRAGON };
      yield return new object[] { Creature.LION };
      yield return new object[] { Creature.PENGUIN };
      yield return new object[] { Creature.UNICORN };
      yield return new object[] { Creature.WILD_DOG };
    }
  }

}
