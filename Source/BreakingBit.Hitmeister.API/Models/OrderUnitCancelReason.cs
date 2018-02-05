using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Encoding of a reason why an order has been canceled
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderUnitCancelReason
    {

        /// <summary>
        /// If none of the other reasons apply to your situation, use this reason.
        /// </summary>
        [EnumMember(Value = "GeneralAdjustment")]
        GeneralAdjustment,

        /// <summary>
        /// The buyer canceled the order.
        /// </summary>
        [EnumMember(Value = "BuyerCancelled")]
        BuyerCancelled,

        /// <summary>
        /// The customer would like to exchange the ordered item for a different one.
        /// </summary>
        [EnumMember(Value = "CustomerExchange")]
        CustomerExchange,

        /// <summary>
        /// Enum CustomerReturn for "CustomerReturn"
        /// </summary>
        [EnumMember(Value = "CustomerReturn")]
        CustomerReturn,

        /// <summary>
        /// Could not deliver to the address given by the customer.
        /// </summary>
        [EnumMember(Value = "ShippingAddressUndeliverable")]
        ShippingAddressUndeliverable,

        /// <summary>
        /// The description on the Hitmeister site did not match the item in your inventory.
        /// </summary>
        [EnumMember(Value = "WrongCatalogData")]
        WrongCatalogData,

        /// <summary>
        /// The customer says that the item did not arrive due to problems during shipping.
        /// </summary>
        [EnumMember(Value = "MerchandiseNotReceived")]
        MerchandiseNotReceived,

        /// <summary>
        /// The item is not currently in your inventory, for example because you are temporarily or permanently sold out.
        /// </summary>
        [EnumMember(Value = "NoInventory")]
        NoInventory,

        /// <summary>
        /// The price on the Hitmeister site was incorrect.
        /// </summary>
        [EnumMember(Value = "WrongPrice")]
        WrongPrice,

        /// <summary>
        /// If you do not ship to the customers location.
        /// </summary>
        [EnumMember(Value = "UndeliverableRegion")]
        UndeliverableRegion,

        /// <summary>
        /// The item is not in your inventory and there is a delay in delivery by the supplier.
        /// </summary>
        [EnumMember(Value = "DelayedInventory")]
        DelayedInventory,

        /// <summary>
        /// If there is no response by the customer to complete the order.
        /// </summary>
        [EnumMember(Value = "NoReactionBuyer")]
        NoReactionBuyer
    }
}
