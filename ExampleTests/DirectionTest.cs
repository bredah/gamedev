using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gamedev
{
    [TestClass]
    public class DirectionTest
    {
        [DataTestMethod]
        [DataRow(Direction.FOWARD, "foward")]
        [DataRow(Direction.BACK, "back")]
        [DataRow(Direction.LEFT, "left")]
        [DataRow(Direction.RIGHT, "rigth")]
        public void ShouldPresentContent(Direction currentValue, string expectedValue)
        {
            Assert.AreEqual(expectedValue, currentValue.GetString());
        }

        [TestMethod]
        public void ShouldPresentContent_WrongDirection()
        {
            Direction currentValue = (Direction)6;
            Assert.AreEqual("wrong direction", currentValue.GetString());
        }
    }
}
