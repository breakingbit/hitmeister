using System;
using System.Linq;
using BreakingBit.Hitmeister.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BreakingBit.Hitmeister.API.UnitTests.Models
{
    [TestClass]
    public class EANTests
    {
        [TestMethod]
        public void ConstructorThrowsOnOverflowException()
        {
            foreach (var type in Enum.GetValues(typeof(EANType)).Cast<EANType>())
            {
                Assert.ThrowsException<OverflowException>(() =>
                    new EAN((ulong)Math.Pow(10, (uint)type), type)
                );
            }
        }

        [TestMethod]
        public void ConstructorSetsProperties()
        {
            var ean = new EAN(212, EANType.GTIN_13);
            Assert.AreEqual(212Lu, ean.Number);
            Assert.AreEqual(EANType.GTIN_13, ean.Type);
            ean = new EAN(121, EANType.GTIN_14);
            Assert.AreEqual(121Lu, ean.Number);
            Assert.AreEqual(EANType.GTIN_14, ean.Type);
        }

        [TestMethod]
        public void ParseThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
                EAN.Parse(null)
            );
            Assert.ThrowsException<ArgumentNullException>(() =>
                EAN.Parse(null, EANType.GTIN_13)
            );
        }

        [TestMethod]
        public void ParseThrowsFormatExceptionOnInvalidNumber()
        {
            Assert.ThrowsException<FormatException>(() =>
                EAN.Parse("not a number")
            );
            Assert.ThrowsException<FormatException>(() =>
                EAN.Parse(new string('-', 13))
            );
            Assert.ThrowsException<FormatException>(() =>
                EAN.Parse("not a number", EANType.GTIN_14)
            );

            Assert.ThrowsException<FormatException>(() =>
                EAN.Parse("2,7")
            );
            Assert.ThrowsException<FormatException>(() =>
                EAN.Parse("1.0", EANType.GTIN_14)
            );
        }

        [TestMethod]
        public void ParseThrowFormatExceptionIfNoNormCannotBeDerrived()
        {
            Assert.ThrowsException<FormatException>(() =>
                EAN.Parse("100")
            );
            Assert.ThrowsException<FormatException>(() =>
                EAN.Parse(new string('9', 20))
            );
        }

        [TestMethod]
        public void ParseDerivesNormCorrectly()
        {
            foreach (var type in Enum.GetValues(typeof(EANType)).Cast<EANType>())
                Assert.AreEqual(type, EAN.Parse(new string('0', (int)type)).Type);
        }

        [TestMethod]
        public void TryParseReturnsFalseNullOnInvalidValues()
        {
            var placeholder = new EAN(1, EANType.GTIN_13);
            var check = EAN.TryParse("not a number", out placeholder);
            Assert.IsNull(placeholder);
            Assert.IsFalse(check);

            check = EAN.TryParse(new string('-', 13), out placeholder);
            Assert.IsNull(placeholder);
            Assert.IsFalse(check);

            check = EAN.TryParse("-1", EANType.GTIN_13, out placeholder);
            Assert.IsNull(placeholder);
            Assert.IsFalse(check);
        }

        [TestMethod]
        public void TryParseReturnsTrueEANOnValidValues()
        {
            var check = EAN.TryParse("812371", EANType.GTIN_13, out var placeholder);
            Assert.IsNotNull(placeholder);
            Assert.IsTrue(check);

            check = EAN.TryParse(new string('1', 14), out placeholder);
            Assert.IsNotNull(placeholder);
            Assert.IsTrue(check);
        }
    }
}
