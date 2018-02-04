using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The particulars of the place where someone lives or an organization is situated.
    /// </summary>
    public sealed class Address
    {
        /// <summary>
        /// The Gender of the person referenced in this Address
        /// </summary>
        /// <value>Male or Female</value>
        [JsonProperty("gender", Required = Required.Always)]
        public Gender Gender { get; set; }

        /// <summary>
        /// The first name of the person this Address is designated to
        /// </summary>
        /// <value>User written string</value>
        [JsonProperty("first_name", Required = Required.Always)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person this Address is designated to
        /// </summary>
        /// <value>User written string</value>
        [JsonProperty("last_name", Required = Required.Always)]
        public string LastName { get; set; }

        /// <summary>
        /// The name of the company this address belongs to, if any
        /// </summary>
        /// <value>User written string</value>
        [JsonProperty("company_name", Required = Required.Always)]
        public string CompanyName { get; set; }

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
        /// An additional field required for appropriate shipment
        /// </summary>
        /// <value>User written string</value>
        [JsonProperty("additional_field", Required = Required.Always)]
        public string AdditionalField { get; set; }

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

        /// <summary>
        /// The country this Address belongs to
        /// </summary>
        /// <value>User written string</value>
        [JsonProperty("country", Required = Required.Always)]
        public string Country { get; set; }
    }
}
