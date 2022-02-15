namespace gamedev
{

  public enum Direction
  {
    FOWARD,
    BACK,
    LEFT,
    RIGHT
  }

  public static class DirectionExtensions
  {
    public static string GetString(this Direction direction)
    {
      switch (direction)
      {
        case Direction.FOWARD:
          return "foward";
        case Direction.BACK:
          return "back";
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
