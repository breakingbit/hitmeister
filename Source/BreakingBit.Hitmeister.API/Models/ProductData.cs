using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A collection of product attributes.
    /// </summary>
    /// <remarks>
    /// The description for a product is created by combining information from multiple sources: 
    /// product information services, marketplace sellers, manufacturers, and members of the 
    /// Hitmeister category management team. The chosen product sheet is called Item.
    /// </remarks>
    public partial class ProductData
    {
        /// <summary>
        /// A list of Eans associated with this product.
        /// </summary>
        /// <value>EAN, 13 or 14 digits</value>
        [JsonProperty("ean", Required = Required.Always)]
        public List<Ean> Ean { get; set; }

        /// <summary>
        /// Available titles for this product.
        /// </summary>
        /// <value>Product Title</value>
        [JsonProperty("title", Required = Required.Always)]
        public List<string> Title { get; set; }

        /// <summary>
        /// The main category of the item
        /// </summary>
        /// <value>Unique leaf category Names</value>
        [JsonProperty("category", Required = Required.Always)]
        public List<string> Category { get; set; }

        /// <summary>
        /// Additional categories for the item
        /// </summary>
        /// <value>Unique leaf category Names</value>
        [JsonProperty("additional_categories", Required = Required.Always)]
        public List<string> AdditionalCategories { get; set; }

        /// <summary>
        /// A detailed product description
        /// </summary>
        /// <value>max. 65535 characters, may contain HTML</value>
        [JsonProperty("description", Required = Required.Always)]
        [MaxLength(65535)]
        public List<string> Description { get; set; }

        /// <summary>
        /// A short product description
        /// </summary>
        /// <value>max. 1024 characters, cannot contain HTML</value>
        [JsonProperty("short_description", Required = Required.Always)]
        public List<string> ShortDescription { get; set; }

        /// <summary>
        /// Manufacturer's Part Number
        /// </summary>
        /// <value>Part Number</value>
        [JsonProperty("mpn", Required = Required.Always)]
        public List<string> Mpn { get; set; }

        /// <summary>
        /// List Price
        /// </summary>
        /// <value>User defined format</value>
        [JsonProperty("list_price", Required = Required.Always)]
        public List<string> ListPrice { get; set; }

        /// <summary>
        /// Picture URLs for this product.
        /// </summary>
        /// <value>List of URL of pictures</value>
        [JsonProperty("picture", Required = Required.Always)]
        public List<Uri> Picture { get; set; }
    }
}
