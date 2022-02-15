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

    public static void Jump(Direction direction)
    {
      Console.WriteLine("jump to: " + direction.GetString());
      Sound.PlaySound("jump");
    }

    public static void Crouch()
    {
      // without creativity for this sound effect
      Console.WriteLine("crouch");
    }

    public static void Crouch(Direction direction)
    {
      Console.WriteLine("crouch to: " + direction.GetString());
      Sound.PlaySound("crouch");
    }

    public static void Crawl()
    {
      // without creativity for this sound effect
      Console.WriteLine("crawl");
    }
    
    public static void Crawl(Direction direction)
    {
      Console.WriteLine("crawl to: " + direction.GetString());
      Sound.PlaySound("crawl");
    }
  }
}
