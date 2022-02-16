using System;
using System.Threading.Tasks;

namespace gamedev
{
  public class Helper
  {

    private static bool _skipDelay = false;

    public static bool SkipDelay
    {
      set { _skipDelay = value; }
    }

    public static async Task randomDelay()
    {
      int value = _skipDelay ? 0 : new Random().Next(100, 3000);
      await Task.Delay(value);
    }
  }

}
