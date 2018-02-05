using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The particulars of the place where a warehouse is situated.
    /// </summary>
    public sealed class WarehouseAddress
    {
        /// <summary>
        /// Country code according to ISO 3166-2
        /// </summary>
        /// <value>Country/Region code</value>
        [JsonProperty("country", Required = Required.Always)]
        public Location Country { get; set; }

        /// <summary>
        /// The name of the street unique in its city
        /// </summary>
        /// <value>User written string</value>
        [JsonProperty("street", Required = Required.Always)]
        public string Street { get; set; }

        /// <summary>
        /// The house number may have arbitrary formats
        /// </summary>
        /// <value>A user written house number</value>
        [JsonProperty("house_number", Required = Required.Always)]
        public string HouseNumber { get; set; }

        /// <summary>
        /// An identifier for the city unique in its country
        /// </summary>
        /// <value>A composition of digits, may have leading zeros</value>
        [JsonProperty("postcode", Required = Required.Always)]
        public string Postcode { get; set; }

        /// <summary>
        /// The name of the city
        /// </summary>
        /// <value>User written string</value>
        [JsonProperty("city", Required = Required.Always)]
        public string City { get; set; }

        /// <summary>
        /// The phone number for calling
        /// </summary>
        /// <value>An arbitrary phone number format</value>
        [JsonProperty("phone", Required = Required.Always)]
        public string PhoneNumber { get; set; }
    }
}
