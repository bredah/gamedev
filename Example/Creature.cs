namespace gamedev
{

  public enum Creature
  {
    UNICORN,
    PENGUIN,
    LION,
    WILD_DOG,
    DRAGON,
    DOLPHIN
  }

  public static class CreatureExtensions
  {
    public static string GetString(this Creature creature)
    {
      switch (creature)
      {
        case Creature.DOLPHIN:
          return "dolphin";
        case Creature.DRAGON:
          return "dragon";
        case Creature.LION:
          return "lion";
        case Creature.PENGUIN:
          return "penguin";
        case Creature.UNICORN:
          return "unicorn";
        case Creature.WILD_DOG:
          return "wild dog";
        default:
          return "this creature does not exists";
      }
    }

    public static string GetSound(this Creature creature)
    {
      switch (creature)
      {
        case Creature.DOLPHIN:
          return "clicks";
        case Creature.DRAGON:
          return "hello I am frank";
        case Creature.LION:
          return "roar";
        case Creature.PENGUIN:
          return "have you installed linux today?";
        case Creature.UNICORN:
          return "la la la la";
        case Creature.WILD_DOG:
          return "woff";
        default:
          return "this creature does not exists";
      }
    }
  }
}
