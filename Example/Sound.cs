using System;
using System.Threading.Tasks;

namespace gamedev
{

  public class Sound
  {

    private static bool _muted = false;

    public static bool Muted
    {
      set { _muted = value; }
    }

    public static async Task PlaySound(String sound)
    {
      if (!_muted)
      {
        await Helper.randomDelay();
        Console.WriteLine("play sound: " + sound);
      }
    }
  }
}
