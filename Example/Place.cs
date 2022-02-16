namespace gamedev
{

  public enum Place
  {
    FLOREST,
    DARK_CAVE,
    ABANDONED_HOUSE,
    FROZEN_MOUNTAIN
  }

  public static class PlaceExtensions
  {
    public static string GetString(this Place place)
    {
      switch (place)
      {
        case Place.ABANDONED_HOUSE:
          return "abandoned house";
        case Place.DARK_CAVE:
          return "dark cave";
        case Place.FLOREST:
          return "florest";
        case Place.FROZEN_MOUNTAIN:
          return "frozen mountain";
        default:
          return "this place does not exists";
      }
    }
  }
}
