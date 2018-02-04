using System;
using BreakingBit.Hitmeister.API.JsonConverters;
using BreakingBit.Hitmeister.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BreakingBit.Hitmeister.API.UnitTests.JsonConverters
{
    [TestClass]
    public class EanJsonConverterTests
    {
        sealed class TestJsonType
        {
            public Ean Ean1;
            public Ean Ean2;
        }

        [TestMethod]
        public void CanConvertOnlyEan()
        {
            var converter = new EanJsonConverter();
            Assert.IsTrue(converter.CanConvert(typeof(Ean)));
            Assert.IsFalse(converter.CanConvert(typeof(string)));
            Assert.IsFalse(converter.CanConvert(typeof(ulong)));
        }

        [TestMethod]
        public void ReadThrowsFormatExceptionIfTokenIsNotAString()
        {
            Assert.ThrowsException<FormatException>(() =>
                JsonConvert.DeserializeObject<TestJsonType>("{\"Ean1\": 10}")
            );
        }

        [TestMethod]
        public void ReaderHandlesNullToken()
        {
            var obj = JsonConvert.DeserializeObject<TestJsonType>(
            @"{
                ""Ean1"": null
            }");
            Assert.IsNull(obj.Ean1);
            Assert.IsNull(obj.Ean2);
        }

        [TestMethod]
        public void ReaderConvertsStringToEan()
        {
            var obj = JsonConvert.DeserializeObject<TestJsonType>(
            @"{
                ""Ean1"": ""0003823918234"",
                ""Ean2"": ""00008479349200""
            }");
            Assert.IsNotNull(obj.Ean1);
            Assert.AreEqual(3823918234Lu, obj.Ean1.Number);
            Assert.AreEqual(EanType.GTIN_13, obj.Ean1.Type);

            Assert.IsNotNull(obj.Ean2);
            Assert.AreEqual(8479349200Lu, obj.Ean2.Number);
            Assert.AreEqual(EanType.GTIN_14, obj.Ean2.Type);
        }

        [TestMethod]
        public void WriteSerializesNullValueToNullToken()
        {
            var testJson = new TestJsonType { Ean1 = null };
            var jtoken = JToken.FromObject(testJson)["Ean1"];
            Assert.AreEqual(JTokenType.Null, jtoken.Type);
        }

        [TestMethod]
        public void ConverterSerializesConsistent()
        {
            var testJson = new TestJsonType
            {
                Ean1 = new Ean(451281, EanType.GTIN_13),
                Ean2 = new Ean(945721, EanType.GTIN_14)
            };
            var serializedTestJson = JsonConvert.SerializeObject(testJson);
            var deserializedTestJson = JsonConvert.DeserializeObject<TestJsonType>(serializedTestJson);
            Assert.IsNotNull(deserializedTestJson);
            Assert.IsNotNull(deserializedTestJson.Ean1);
            Assert.AreEqual(testJson.Ean1.Number, deserializedTestJson.Ean1.Number);
            Assert.AreEqual(testJson.Ean1.Type, deserializedTestJson.Ean1.Type);
            Assert.IsNotNull(deserializedTestJson.Ean2);
            Assert.AreEqual(testJson.Ean2.Number, deserializedTestJson.Ean2.Number);
            Assert.AreEqual(testJson.Ean2.Type, deserializedTestJson.Ean2.Type);
        }
    }
}
