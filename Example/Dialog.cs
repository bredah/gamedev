using System;
using System.Threading.Tasks;

namespace gamedev
{
  public class Dialog
  {
    public static readonly string[] placeDialog = {
      "Behold, the traveler finds a {place}...",
      "After a long walk, the traveler finds a {place}...",
      "Behold, our hero sees a {place} ahead..." };
    public static readonly string[] creatureDialog = {
      "and decides to run away because a dangerous {creature} sees ahead",
      "and comes across a terrible {creature} ahead and decides not to take this risk",
      "saw a dangerous {creature} and decides not to lose his way today for the dangerous animal."};

    public static async Task TellHistoryAsync(Tuple<Place, Creature> map)
    {
      string dialogPlaceToPresent = placeDialog[new Random().Next(0, placeDialog.Length)].Replace("{place}", map.Item1.GetString());
      string dialogCreatureToPresent = creatureDialog[new Random().Next(0, creatureDialog.Length)].Replace("{creature}", map.Item2.ToString());
      
      Console.WriteLine(dialogPlaceToPresent);
      await Sound.PlaySound(map.Item1.ToString());
      
      Console.WriteLine(dialogCreatureToPresent);
      await Sound.PlaySound(String.Format("{0} - {1}", map.Item2.GetString(), map.Item2.GetSound()));
    }
  }
}
