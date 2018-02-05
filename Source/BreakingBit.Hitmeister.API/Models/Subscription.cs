using Newtonsoft.Json;

namespace BreakingBit.Hitmeister.API.Models
{
    /// <summary>
    /// A configuration to retrieve push notifications from the
    /// Hitmeister system.
    /// </summary>
    public sealed class Subscription
    {
        /// <summary>
        /// The name of the event subscribing to, see SubscriptionEvent.
        /// </summary>
        [JsonProperty("event_name", Required = Required.Always)]
        public SubscriptionEvent Event { get; set; }

        /// <summary>
        /// Internal identifier of Subscription, unique across all Subscriptions
        /// </summary>
        /// <value>Unique identifier</value>
        [JsonProperty("id_subscription", Required = Required.Always)]
        public long Identifier { get; set; }

        /// <summary>
        /// A publicly-accessible URL that will receive a POST request for each event notification.
        /// </summary>
        /// <value>Callback URL</value>
        [JsonProperty("callback_url", Required = Required.Always)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// An email address that will receive an email if the Hitmeister system can’t reach the callback 
        /// URL for an extended period of time and the subscription gets disabled.
        /// </summary>
        /// <value>Email address</value>
        [JsonProperty("fallback_email", Required = Required.Always)]
        public string FallbackEmail { get; set; }

        /// <summary>
        /// If IsActive is set to true the Hitmeister system will try to POST notification to this 
        /// Subscription otherwise it will be ignored.
        /// </summary>
        /// <value>Active/Inactive flag</value>
        [JsonProperty("is_active", Required = Required.Always)]
        public bool IsActive { get; set; }
    }
}
