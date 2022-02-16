using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace gamedev
{

  public class CharacterMoves
  {
    public static void Walk(Direction direction)
    {
      Console.WriteLine("walk to: " + direction.GetString());
      Sound.PlaySound("walk");
    }

    public static void Jump()
    {
      Console.WriteLine("jump");
      Sound.PlaySound("jump");
    }

    public static void Crouch()
    {
      // without creativity for this sound effect
      Console.WriteLine("crouch");
    }

  }
    
}
