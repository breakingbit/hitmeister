using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// Encodes the current status of a return.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReturnStatus
    {

        /// <summary>
        /// The customer has not sent the product back yet.
        /// </summary>
        [EnumMember(Value = "need_to_be_returned")]
        NeedToBeReturned,

        /// <summary>
        /// The product sent by the customer has arrived.
        /// </summary>
        [EnumMember(Value = "return_arrived")]
        ReturnArrived,

        /// <summary>
        /// The seller accepted the returned products condition.
        /// </summary>
        [EnumMember(Value = "return_accepted")]
        ReturnAccepted,

        /// <summary>
        /// The seller rejected the return.
        /// </summary>
        [EnumMember(Value = "return_rejected")]
        ReturnRejected,

        /// <summary>
        /// The return has been completely processed and closed.
        /// </summary>
        [EnumMember(Value = "return_closed")]
        ReturnClosed
    }
}
