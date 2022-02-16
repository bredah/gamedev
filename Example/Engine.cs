using System;
using System.Collections.Generic;

namespace gamedev
{

    static class Engine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start\n");
            var worldMap = WorldMap.generateWorlds();
            for (int i = 0; i < worldMap.Count; i++)
            {
                Console.WriteLine("World " + (i + 1).ToString());
                Console.WriteLine("Map - " + worldMap[i] + "\n");

            }

            Console.ReadKey(true);
            Console.WriteLine("Finish");
        }
    }
}
