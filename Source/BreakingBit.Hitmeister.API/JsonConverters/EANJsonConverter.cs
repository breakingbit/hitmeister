using System;
using BreakingBit.Hitmeister.API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BreakingBit.Hitmeister.API.JsonConverters
{
    /// <summary>
    /// Implements a <see cref="JsonConverter"/> for <see cref="Ean"/> based
    /// on a string representation.
    /// </summary>
    /// <remarks>
    /// Object types are not checked in the implementation assuming <see cref="CanConvert(Type)"/>
    /// only accepts the type of <see cref="Ean"/>.
    /// </remarks>
    public sealed class EanJsonConverter : JsonConverter
    {
        /// <summary>
        /// Implements <see cref="JsonConverter.CanConvert(Type)"/> to check for the supported <see cref="Ean"/> type.
        /// </summary>
        /// <param name="objectType">The <see cref="Type"/> to check against.</param>
        /// <returns>True if <paramref name="objectType"/> is the <see cref="Ean"/> type; otherwise false</returns>
        public override bool CanConvert(Type objectType) =>
            objectType == typeof(Ean);

        /// <summary>
        /// Reads the JSON representation of the <see cref="Ean"/>.
        /// </summary>
        /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
        /// <param name="objectType"><see cref="Type"/> of the object, fixed to type of <see cref="Ean"/></param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The parsed <see cref="Ean"/> object</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            if (reader.TokenType != JsonToken.String)
                throw new FormatException($"The {nameof(Ean)} json representation must be a string.");
            var token = JToken.ReadFrom(reader);
            return Ean.Parse(token.Value<string>());
        }

        /// <summary>
        /// Writes the JSON representation of the <see cref="Ean"/>.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The <see cref="Ean"/> to serialize.</param>
        /// <param name="serializer">The calling <see cref="JsonSerializer"/></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var jvalue = JValue.CreateNull();
            if (value is Ean ean)
                jvalue = JValue.CreateString(ean.ToString());
            jvalue.WriteTo(writer);
        }
    }
}
