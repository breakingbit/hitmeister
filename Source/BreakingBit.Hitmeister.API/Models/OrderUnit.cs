using System;
using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A unit sold in an order.
    /// </summary>
    /// <remarks>
    /// When a customer creates an order an OrderUnit is created for every unit you sold.
    /// </remarks>
    public class OrderUnit
    {
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [JsonProperty("status", Required = Required.Always)]
        public OrderUnitStatus Status { get; set; }

        /// <summary>
        /// Condition of the sold product.
        /// </summary>
        [JsonProperty("unit_condition", Required = Required.Always)]
        public UnitCondition Condition { get; set; }

        /// <summary>
        /// The delivery time shown on the shop website.
        /// </summary>
        /// <value>DeliveryTime Code in days</value>
        [JsonProperty("delivery_time", Required = Required.Always)]
        public DeliveryTime DeliveryTime { get; set; }

        /// <summary>
        /// A reason why this OrderUnit was canceled, if so
        /// </summary>
        /// <value>Null if not canceled</value>
        [JsonProperty("cancel_reason", Required = Required.Always)]
        public OrderUnitCancelReason? CancelReason { get; set; }


        /// <summary>
        /// The OrderUnit's internal identifier, unique across all OrderUnits
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_order_unit", Required = Required.Always)]
        public long Identifier { get; set; }

        /// <summary>
        /// Identifier of the partial order referencing all OrderUnits you sold.
        /// </summary>
        /// <value>Order Identifier</value>
        [JsonProperty("id_order", Required = Required.Always)]
        public string OrderIdentifier { get; set; }

        /// <summary>
        /// Date and time when this OrderUnit has been placed.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("ts_created", Required = Required.Always)]
        public DateTime CreationTimestamp { get; set; }

        /// <summary>
        /// Date and time when this OrderUnit has been lastly modified.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("ts_updated", Required = Required.Always)]
        public DateTime LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Price at which this unit will be offered on Hitmeister
        /// </summary>
        /// <value>Eurocent</value>
        [JsonProperty("price", Required = Required.Always)]
        public int Price { get; set; }

        /// <summary>
        /// An unique offer identifier placed by the seller of this unit.
        /// </summary>
        /// <value>Free text</value>
        [JsonProperty("id_offer", Required = Required.Always)]
        public string OfferIdentifier { get; set; }

        /// <summary>
        /// Revenue before paying VAT.
        /// </summary>
        /// <value>Eurocent</value>
        [JsonProperty("revenue_gross", Required = Required.Always)]
        public int RevenueGross { get; set; }

        /// <summary>
        /// Revenue after paying VAT.
        /// </summary>
        /// <value>Eurocent</value>
        [JsonProperty("revenue_net", Required = Required.Always)]
        public int RevenueNet { get; set; }

        /// <summary>
        /// A note for this unit
        /// </summary>
        /// <value>Free user written text.</value>
        [JsonProperty("note", Required = Required.Always)]
        public string Note { get; set; }

        /// <summary>
        /// A date and time until the order must be sent to the customer.
        /// </summary>
        /// <value>Timestamp</value>
        [JsonProperty("delivery_time_expires", Required = Required.Always)]
        public DateTime DeliveryTimeExpiresTimestamp { get; set; }

        /// <summary>
        /// The amount of eurocent charged for shipment.
        /// </summary>
        /// <value>Eurocent</value>
        [JsonProperty("shipping_rate", Required = Required.Always)]
        public int ShippingRate { get; set; }

        /// <summary>
        /// The customer identification who bought this product
        /// </summary>
        [JsonProperty("buyer", Required = Required.Always)]
        public Buyer Buyer { get; set; }

        /// <summary>
        /// A claim made regarding this OrderUnit.
        /// </summary>
        /// <value>Null if no claim exists</value>
        [JsonProperty("claim", Required = Required.Always)]
        public Claim Claim { get; set; }

        /// <summary>
        /// The billing address of the customer who bought this product.
        /// </summary>
        [JsonProperty("billing_address", Required = Required.Always)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The shipping address of the customer who bought this product.
        /// </summary>
        [JsonProperty("shipping_address", Required = Required.Always)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// A customer invoice created by Hitmeister
        /// </summary>
        /// <value>Null if not already created.</value>
        [JsonProperty("invoice", Required = Required.Always)]
        public Invoice Invoice { get; set; }

        /// <summary>
        /// The product data of the bought product.
        /// </summary>
        /// <value>Product Data</value>
        [JsonProperty("item", Required = Required.Always)]
        public Item Item { get; set; }
    }
}
