using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Event name
    /// </summary>
    /// <value>Event name</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionEvent
    {

        /// <summary>
        /// This event is triggered once each time a customer places an order 
        /// which includes one or more of your items.
        /// </summary>
        /// <remarks>
        /// If a customer buys 5 items from you in a single order, only 1 OrderNew 
        /// event notification will be sent.
        /// </remarks>
        [EnumMember(Value = "order_new")]
        OrderNew,

        /// <summary>
        /// This event is triggered each time one of your units is ordered.
        /// </summary>
        /// <remarks>
        /// If a customer buys 5 items from you in a single order, 5 separate 
        /// OrderUnitNew notifications will be sent.
        /// </remarks>
        [EnumMember(Value = "order_unit_new")]
        OrderUnitNew,

        /// <summary>
        ///  This event is triggered each time when the status of one of your units 
        ///  has been changed.
        /// </summary>
        [EnumMember(Value = "order_unit_status_changed")]
        OrderUnitStatusChanged,

        /// <summary>
        /// This event is triggered each time when an item has changed.
        /// </summary>
        [EnumMember(Value = "item_changed")]
        ItemChanged,

        /// <summary>
        /// This event is triggered each time a category has changed.
        /// </summary>
        [EnumMember(Value = "category_changed")]
        CategoryChanged,

        /// <summary>
        /// This event is triggered each time a customer starts a return process.
        /// </summary>
        [EnumMember(Value = "return_new")]
        ReturnNew
    }
}
