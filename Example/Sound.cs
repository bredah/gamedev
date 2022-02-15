using System;

namespace gamedev
{

  public class Sound
  {

    private static bool _muted = false;

    public static bool Muted
    {
      get { return _muted; }
      set { _muted = value; }
    }

    public static void PlaySound(String sound)
    {
      if (!_muted)
      {
        Console.WriteLine("play sound: " + sound);
      }
    }

    // public static async Task<String> playSound(String sound)
    // {
    //   await Task.Delay(10);
    //   return ("play sound: " + sound);
    // }
  }
}
