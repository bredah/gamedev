using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace gamedev
{

  public class WorldGame
  {
    public static readonly int MaxPlaces = 3;

    public static async Task<List<Tuple<Place, Creature>>> generateRandomWorld()
    {
      Console.WriteLine("Create new worlds");
      var places = new List<Tuple<Place, Creature>>();
      for (int i = 0; i < MaxPlaces; i++)
      {
        Console.WriteLine("World " + (i + 1).ToString());
        await Helper.randomDelay();
        Console.WriteLine("Find a (safe) place...");
        await Helper.randomDelay();
        Console.WriteLine("Capture a random creature...");
        places.Add(new Tuple<Place, Creature>(getRandomPlace(), getRandomCreature()));
      }
      return places;
    }

    private static Place getRandomPlace()
    {
      return (Place)new Random().Next(Enum.GetNames(typeof(Place)).Length);
    }

    private static Creature getRandomCreature()
    {
      return (Creature)new Random().Next(Enum.GetNames(typeof(Creature)).Length);
    }
  }
}
