using System;
using System.Linq;
using BreakingBit.Hitmeister.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BreakingBit.Hitmeister.API.UnitTests.Models
{
    [TestClass]
    public class EanTests
    {
        [TestMethod]
        public void ConstructorThrowsOnOverflowException()
        {
            foreach (var type in Enum.GetValues(typeof(EanType)).Cast<EanType>())
            {
                Assert.ThrowsException<OverflowException>(() =>
                    new Ean((ulong)Math.Pow(10, (uint)type), type)
                );
            }
        }

        [TestMethod]
        public void ConstructorSetsProperties()
        {
            var Ean = new Ean(212, EanType.GTIN_13);
            Assert.AreEqual(212Lu, Ean.Number);
            Assert.AreEqual(EanType.GTIN_13, Ean.Type);
            Ean = new Ean(121, EanType.GTIN_14);
            Assert.AreEqual(121Lu, Ean.Number);
            Assert.AreEqual(EanType.GTIN_14, Ean.Type);
        }

        [TestMethod]
        public void ParseThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
                Ean.Parse(null)
            );
            Assert.ThrowsException<ArgumentNullException>(() =>
                Ean.Parse(null, EanType.GTIN_13)
            );
        }

        [TestMethod]
        public void ParseThrowsFormatExceptionOnInvalidNumber()
        {
            Assert.ThrowsException<FormatException>(() =>
                Ean.Parse("not a number")
            );
            Assert.ThrowsException<FormatException>(() =>
                Ean.Parse(new string('-', 13))
            );
            Assert.ThrowsException<FormatException>(() =>
                Ean.Parse("not a number", EanType.GTIN_14)
            );

            Assert.ThrowsException<FormatException>(() =>
                Ean.Parse("2,7")
            );
            Assert.ThrowsException<FormatException>(() =>
                Ean.Parse("1.0", EanType.GTIN_14)
            );
        }

        [TestMethod]
        public void ParseThrowFormatExceptionIfNoNormCannotBeDerrived()
        {
            Assert.ThrowsException<FormatException>(() =>
                Ean.Parse("100")
            );
            Assert.ThrowsException<FormatException>(() =>
                Ean.Parse(new string('9', 20))
            );
        }

        [TestMethod]
        public void ParseDerivesNormCorrectly()
        {
            foreach (var type in Enum.GetValues(typeof(EanType)).Cast<EanType>())
                Assert.AreEqual(type, Ean.Parse(new string('0', (int)type)).Type);
        }

        [TestMethod]
        public void TryParseReturnsFalseNullOnInvalidValues()
        {
            var check = Ean.TryParse("not a number", out var placeholder);
            Assert.IsNull(placeholder);
            Assert.IsFalse(check);

            check = Ean.TryParse(new string('-', 13), out placeholder);
            Assert.IsNull(placeholder);
            Assert.IsFalse(check);

            check = Ean.TryParse("-1", EanType.GTIN_13, out placeholder);
            Assert.IsNull(placeholder);
            Assert.IsFalse(check);
        }

        [TestMethod]
        public void TryParseReturnsTrueEanOnValidValues()
        {
            var check = Ean.TryParse("812371", EanType.GTIN_13, out var placeholder);
            Assert.IsNotNull(placeholder);
            Assert.IsTrue(check);

            check = Ean.TryParse(new string('1', 14), out placeholder);
            Assert.IsNotNull(placeholder);
            Assert.IsTrue(check);
        }

        [TestMethod]
        public void EqualComparisonReturnsFalseOnDifferentTypedObjectsOrNull()
        {
            var Ean = new Ean(0, EanType.GTIN_13);
            Assert.IsFalse(Ean.Equals(""));
            Assert.IsFalse(Ean.Equals(null));
        }

        [TestMethod]
        public void EqualComparisonIgnoresType()
        {
            var Ean1 = new Ean(938741, EanType.GTIN_13);
            var Ean2 = new Ean(Ean1.Number, EanType.GTIN_14);
            Assert.IsTrue(Ean1.Equals(Ean2));
            Assert.IsTrue(Ean2.Equals(Ean1));
        }

        [TestMethod]
        public void HashCodeIgnoresType()
        {
            var Ean1 = new Ean(938741, EanType.GTIN_13);
            var Ean2 = new Ean(Ean1.Number, EanType.GTIN_14);
            Assert.AreEqual(Ean1.GetHashCode(), Ean2.GetHashCode());
        }

        [TestMethod]
        public void ToStringConformsToNorm()
        {
            var Ean = new Ean(100, EanType.GTIN_13);
            Assert.AreEqual(Ean.ToString(), new string('0', 13 - 3) + Ean.Number);
            Ean = new Ean(49182, EanType.GTIN_14);
            Assert.AreEqual(Ean.ToString(), new string('0', 14 - 5) + Ean.Number);
        }
    }
}
