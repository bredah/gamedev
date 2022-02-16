using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gamedev
{
    [TestClass]
    public class BetaTest
    {
        [TestMethod]
        public void dumb()
        {
            CharacterMoves.Walk(Direction.LEFT);
            Sound.Muted = true;
            CharacterMoves.Walk(Direction.RIGHT);
        }
    }
}
