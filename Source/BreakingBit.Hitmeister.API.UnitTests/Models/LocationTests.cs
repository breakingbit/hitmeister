using BreakingBit.Hitmeister.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BreakingBit.Hitmeister.API.UnitTests.Models
{
    [TestClass]
    public class LocationTests
    {
        [TestMethod]
        public void UnitedKingdomAndGreatBritianTreatedTheSame()
        {
            Assert.AreEqual(Location.UnitedKingdom, Location.GreatBritian);
        }
    }
}
