using System;
using BreakingBit.Hitmeister.API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BreakingBit.Hitmeister.API.JsonConverters
{
    /// <summary>
    /// Implements a <see cref="JsonConverter"/> for <see cref="EAN"/> based
    /// on a string representation.
    /// </summary>
    /// <remarks>
    /// Object types are not checked in the implementation assuming <see cref="CanConvert(Type)"/>
    /// only accepts the type of <see cref="EAN"/>.
    /// </remarks>
#pragma warning disable S101 // EAN is an abbreviation
    public sealed class EANJsonConverter : JsonConverter
#pragma warning restore S101 // EAN is an abbreviation
    {
        /// <summary>
        /// Implements <see cref="JsonConverter.CanConvert(Type)"/> to check for the supported <see cref="EAN"/> type.
        /// </summary>
        /// <param name="objectType">The <see cref="Type"/> to check against.</param>
        /// <returns>True if <paramref name="objectType"/> is the <see cref="EAN"/> type; otherwise false</returns>
        public override bool CanConvert(Type objectType) =>
            objectType == typeof(EAN);

        /// <summary>
        /// Reads the JSON representation of the <see cref="EAN"/>.
        /// </summary>
        /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
        /// <param name="objectType"><see cref="Type"/> of the object, fixed to type of <see cref="EAN"/></param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The parsed <see cref="EAN"/> object</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            if (reader.TokenType != JsonToken.String)
                throw new FormatException($"The {nameof(EAN)} json representation must be a string.");
            var token = JToken.ReadFrom(reader);
            return EAN.Parse(token.Value<string>());
        }

        /// <summary>
        /// Writes the JSON representation of the <see cref="EAN"/>.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> t owrite to.</param>
        /// <param name="value">The <see cref="EAN"/> to serialize.</param>
        /// <param name="serializer">The calling <see cref="JsonSerializer"/></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var jvalue = JValue.CreateNull();
            if (value is EAN ean)
                jvalue = JValue.CreateString(ean.ToString());
            jvalue.WriteTo(writer);
        }
    }
}
