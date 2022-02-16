namespace gamedev
{

  public enum Direction
  {
    LEFT,
    RIGHT
  }

  public static class DirectionExtensions
  {
    public static string GetString(this Direction direction)
    {
      switch (direction)
      {
        case Direction.LEFT:
          return "left";
        case Direction.RIGHT:
          return "rigth";
        default:
          return "wrong direction";
      }
    }
  }
}
