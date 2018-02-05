using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// The product data for a single product.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Internal ID of Item, unique across all Items
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_item", Required = Required.Always)]
        public long Identifier { get; set; }

        /// <summary>
        /// The products title displayed in the shop.
        /// </summary>
        /// <value>Item Title</value>
        [JsonProperty("title", Required = Required.Always)]
        public string Title { get; set; }

        /// <summary>
        /// Eans associated with this item.
        /// </summary>
        /// <value>A list of Eans</value>
        [JsonProperty("eans", Required = Required.Always)]
        public List<Ean> Eans { get; set; }

        /// <summary>
        /// Internal ID of Category, unique across all Categories
        /// </summary>
        /// <value>Associated category identifier</value>
        [JsonProperty("id_category", Required = Required.Always)]
        public int CategoryIdentifier { get; set; }

        /// <summary>
        /// URL of the main picture for this item.
        /// </summary>
        /// <value>Items main picture URL</value>
        [JsonProperty("main_picture", Required = Required.Always)]
        public Uri MainPictureUrl { get; set; }

        /// <summary>
        /// The manufacturer who manufactures this item.
        /// </summary>
        /// <value>Manufacturer</value>
        [JsonProperty("manufacturer", Required = Required.Always)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// URL to the items page in the real on-line shop.
        /// </summary>
        /// <value>Shop URL</value>
        [JsonProperty("url", Required = Required.Always)]
        public Uri ShopUrl { get; set; }

        /// <summary>
        /// Unfortunate undocumented
        /// </summary>
        [JsonProperty("real_mgb_article_number", Required = Required.Always)]
        public string RealMgbArticleNumber { get; set; }
    }

}
