using BreakingBit.Hitmeister.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BreakingBit.Hitmeister.API.UnitTests.Models
{
    [TestClass]
    public class UnitConditionTests
    {
        [TestMethod]
        public void CodecsAndWrittenConditionsAreMappedCorrectly()
        {
            Assert.AreEqual(UnitCondition.Code_100, UnitCondition.New);
            Assert.AreEqual(UnitCondition.Code_200, UnitCondition.UsedAsNew);
            Assert.AreEqual(UnitCondition.Code_300, UnitCondition.UsedVeryGood);
            Assert.AreEqual(UnitCondition.Code_400, UnitCondition.UsedGood);
            Assert.AreEqual(UnitCondition.Code_500, UnitCondition.UsedAcceptable);
            Assert.AreEqual(UnitCondition.Code_900, UnitCondition.Download);
        }
    }
}
