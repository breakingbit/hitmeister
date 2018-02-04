using System;
using BreakingBit.Hitmeister.API.JsonConverters;
using BreakingBit.Hitmeister.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BreakingBit.Hitmeister.API.UnitTests.JsonConverters
{
    [TestClass]
#pragma warning disable S101 // EAN is an abbreviation
    public class EANJsonConverterTests
#pragma warning restore S101 // EAN is an abbreviation
    {
        sealed class TestJsonType
        {
            public EAN EAN1;
            public EAN EAN2;
        }

        [TestMethod]
        public void CanConvertOnlyEAN()
        {
            var converter = new EANJsonConverter();
            Assert.IsTrue(converter.CanConvert(typeof(EAN)));
            Assert.IsFalse(converter.CanConvert(typeof(string)));
            Assert.IsFalse(converter.CanConvert(typeof(ulong)));
        }

        [TestMethod]
        public void ReadThrowsFormatExceptionIfTokenIsNotAString()
        {
            Assert.ThrowsException<FormatException>(() =>
                JsonConvert.DeserializeObject<TestJsonType>("{\"EAN1\": 10}")
            );
        }

        [TestMethod]
        public void ReaderHandlesNullToken()
        {
            var obj = JsonConvert.DeserializeObject<TestJsonType>(
            @"{
                ""EAN1"": null
            }");
            Assert.IsNull(obj.EAN1);
            Assert.IsNull(obj.EAN2);
        }

        [TestMethod]
        public void ReaderConvertsStringToEAN()
        {
            var obj = JsonConvert.DeserializeObject<TestJsonType>(
            @"{
                ""EAN1"": ""0003823918234"",
                ""EAN2"": ""00008479349200""
            }");
            Assert.IsNotNull(obj.EAN1);
            Assert.AreEqual(3823918234Lu, obj.EAN1.Number);
            Assert.AreEqual(EANType.GTIN_13, obj.EAN1.Type);

            Assert.IsNotNull(obj.EAN2);
            Assert.AreEqual(8479349200Lu, obj.EAN2.Number);
            Assert.AreEqual(EANType.GTIN_14, obj.EAN2.Type);
        }

        [TestMethod]
        public void WriteSerializesNullValueToNullToken()
        {
            var testJson = new TestJsonType { EAN1 = null };
            var jtoken = JToken.FromObject(testJson)["EAN1"];
            Assert.AreEqual(JTokenType.Null, jtoken.Type);
        }

        [TestMethod]
        public void ConverterSerializesConsistent()
        {
            var testJson = new TestJsonType
            {
                EAN1 = new EAN(451281, EANType.GTIN_13),
                EAN2 = new EAN(945721, EANType.GTIN_14)
            };
            var serializedTestJson = JsonConvert.SerializeObject(testJson);
            var deserializedTestJson = JsonConvert.DeserializeObject<TestJsonType>(serializedTestJson);
            Assert.IsNotNull(deserializedTestJson);
            Assert.IsNotNull(deserializedTestJson.EAN1);
            Assert.AreEqual(testJson.EAN1.Number, deserializedTestJson.EAN1.Number);
            Assert.AreEqual(testJson.EAN1.Type, deserializedTestJson.EAN1.Type);
            Assert.IsNotNull(deserializedTestJson.EAN2);
            Assert.AreEqual(testJson.EAN2.Number, deserializedTestJson.EAN2.Number);
            Assert.AreEqual(testJson.EAN2.Type, deserializedTestJson.EAN2.Type);
        }
    }
}
