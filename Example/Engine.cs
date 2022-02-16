using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace gamedev
{

  public static class Engine
  {
    public static void Main()
    {
      MainAsync().GetAwaiter().GetResult();
    }

    public static async Task MainAsync()
    {
      Console.WriteLine("\nStart of a dumb game\n");
      var worldMap = await WorldGame.generateRandomWorld();

      Console.WriteLine("\nStart the history\n");

      for (int i = 0; i < worldMap.Count; i++)
      {
        Console.WriteLine("World " + (i + 1).ToString());
        await Dialog.TellHistoryAsync(worldMap[i]);
      }

      Console.WriteLine("\nFinish");
    }
  }
}
