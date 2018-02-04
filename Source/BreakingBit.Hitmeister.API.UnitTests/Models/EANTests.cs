using System;
using System.Linq;
using BreakingBit.Hitmeister.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BreakingBit.Hitmeister.API.UnitTests.Models
{
    [TestClass]
#pragma warning disable S101 // EAN is an abbreviation
    public class EANTests
#pragma warning restore S101 // EAN is an abbreviation
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
            var check = EAN.TryParse("not a number", out var placeholder);
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

        [TestMethod]
        public void EqualComparisonReturnsFalseOnDifferentTypedObjectsOrNull()
        {
            var ean = new EAN(0, EANType.GTIN_13);
            Assert.IsFalse(ean.Equals(""));
            Assert.IsFalse(ean.Equals(null));
        }

        [TestMethod]
        public void EqualComparisonIgnoresType()
        {
            var ean1 = new EAN(938741, EANType.GTIN_13);
            var ean2 = new EAN(ean1.Number, EANType.GTIN_14);
            Assert.IsTrue(ean1.Equals(ean2));
            Assert.IsTrue(ean2.Equals(ean1));
        }

        [TestMethod]
        public void HashCodeIgnoresType()
        {
            var ean1 = new EAN(938741, EANType.GTIN_13);
            var ean2 = new EAN(ean1.Number, EANType.GTIN_14);
            Assert.AreEqual(ean1.GetHashCode(), ean2.GetHashCode());
        }
    }
}
