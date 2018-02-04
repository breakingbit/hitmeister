using System;
using BreakingBit.Hitmeister.Core.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BreakingBit.Hitmeister.Core.UnitTests.Extensions.NumericExtensions
{
    [TestClass]
    public class NumericExtensionsTests
    {
        [TestMethod]
        public void CountDigitsTest()
        {
            for (var i = 0; i < 16; ++i)
                Assert.AreEqual((uint)(i + 1), Convert.ToUInt64(Math.Pow(10, i)).CountDigits());
        }
    }
}
