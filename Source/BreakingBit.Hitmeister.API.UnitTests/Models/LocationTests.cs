using System;
using System.Linq;
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

        [TestMethod]
        public void NoOtherThanUnitedKingdomAndGreatBritianAreTreatedTheSame()
        {
            foreach (var item1 in Enum.GetValues(typeof(Location)).Cast<Location>())
            {
                if (item1 == Location.UnitedKingdom)
                    continue;
                foreach (var item2 in Enum.GetValues(typeof(Location)).Cast<Location>())
                {
                    if (item2 == Location.UnitedKingdom)
                        continue;
                    if (item1.ToString() == item2.ToString())
                        continue;
                    Assert.AreNotEqual(item1, item2);
                }
            }
        }
    }
}
