using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Tree structure for organizing items into categories with shared data or data requirements 
    /// expressed as attributes.
    /// </summary>
    /// <remarks>
    /// On the Hitmeister site, every item must belong to a category. Hitmeister has a multi-level 
    /// category tree with over 5,000 categories in it, but items can only be in leaf categories in 
    /// the tree. At the top level of the tree we have the root category, which is guaranteed to 
    /// have an Identifier = 1.
    /// </remarks>
    public class Category
    {

        /// <summary>
        /// Internal ID of Category, unique across all Categories
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_category", Required = Required.Always)]
        public int Identifier { get; set; }

        /// <summary>
        /// Name of Category, unique across all Categories
        /// </summary>
        /// <value>Unique name</value>
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// Identifier of the parent category this category is a child of
        /// </summary>
        /// <value>Identifier of the associated parent category</value>
        [JsonProperty("id_parent_category", Required = Required.Always)]
        public int ParentCategoryIdentifier { get; set; }

        /// <summary>
        /// Singular Title of Category displayed on the website
        /// </summary>
        /// <value>Singular Title of Category</value>
        [JsonProperty("title_singular", Required = Required.Always)]
        public string TitleSingular { get; set; }

        /// <summary>
        /// Plural Title of Category displayed on the website
        /// </summary>
        /// <value>Plural Title of Category</value>
        [JsonProperty("title_plural", Required = Required.Always)]
        public string TitlePlural { get; set; }

        /// <summary>
        /// The count of direct and indirect parent categories
        /// </summary>
        /// <value>Level of depth</value>
        [JsonProperty("level", Required = Required.Always)]
        public int Level { get; set; }

        /// <summary>
        /// URL to the category shop website
        /// </summary>
        /// <value>Shop Category URL</value>
        [JsonProperty("url", Required = Required.Always)]
        public string Url { get; set; }

        /// <summary>
        /// A category indicating which requirements apply to shipment by law.
        /// </summary>
        [JsonProperty("shipping_category", Required = Required.Always)]
        public string ShippingCategory { get; set; }

        /// <summary>
        /// Percentage amount of your selling price charged as fee if selling an item in this category.
        /// </summary>
        /// <value>Percentage fees for sales</value>
        [JsonProperty("variable_fee", Required = Required.Always)]
        public double VariableFee { get; set; }

        /// <summary>
        /// Fixed amount in eurocent charged as fee if selling an item in this category.
        /// </summary>
        /// <value>Fixed fees for sales</value>
        [JsonProperty("fixed_fee", Required = Required.Always)]
        public int FixedFee { get; set; }

        /// <summary>
        /// Taxes percentage applying for items in this category
        /// </summary>
        /// <value>Taxes in percent</value>
        [JsonProperty("vat", Required = Required.Always)]
        public double Vat { get; set; }

        /// <summary>
        /// Unique identifier for the most top level category this category belongs to
        /// </summary>
        /// <value>Identifier root parent</value>
        [JsonProperty("real_main_category_id", Required = Required.Always)]
        public int RealMainCategoryId { get; set; }
    }

}
