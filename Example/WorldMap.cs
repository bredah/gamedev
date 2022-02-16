using System;
using System.Collections.Generic;

namespace gamedev
{

  public class WorldMap
  {
    public static readonly int MaxWorlds = 3;
    public static readonly int WorldSize = 5;

    public static List<string> generateWorlds()
    {
      List<string> maps = new List<string>();
      string mapValue;
      for (int mapAmount = 0; mapAmount < MaxWorlds; mapAmount++)
      {
        mapValue = "";
        for (int mapLength = 0; mapLength < WorldSize; mapLength++)
        {
          int num = new Random().Next(0, 2);
          mapValue += num;
        }
        maps.Add(mapValue);
      }
      return maps;
    }

  }
}
