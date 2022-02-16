using System;
using System.Collections.Generic;
using System.Linq;
using gamedev.helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gamedev
{
  [TestClass]
  public class PlaceTest
  {

    [TestInitialize]
    public void Setup()
    {
      Sound.Muted = false;
    }

    [TestMethod]
    [DynamicData(nameof(TestData), DynamicDataSourceType.Method)]
    public void ShouldPlaceDescriptionExists(Place place)
    {
      string placeDescription = place.GetString();

      Assert.IsFalse(String.IsNullOrEmpty(placeDescription));
    }

    [TestMethod]
    public void ShouldPlaceDescriptionNotExists()
    {
      Place place = (Place)9;
      string placeDescription = place.GetString();
    
      Assert.IsFalse(String.IsNullOrEmpty(placeDescription));
      Assert.AreEqual("this place does not exists", placeDescription);
    }

    public static IEnumerable<object[]> TestData()
    {
      yield return new object[] { Place.ABANDONED_HOUSE };
      yield return new object[] { Place.DARK_CAVE };
      yield return new object[] { Place.FLOREST };
      yield return new object[] { Place.FROZEN_MOUNTAIN };
    }
  }

}
