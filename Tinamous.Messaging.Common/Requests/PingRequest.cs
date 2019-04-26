using System;

namespace AnalysisUK.Tinamous.Messaging.Common.Requests
{
    /// <summary>
    /// PubSub request. Issuer sets desired Service/Server (any combination) and services matching
    /// respond by firing a PongEvent.
    /// </summary>
    public class PingRequest
    {
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public string Server { get; set; }
        public DateTime DateTime { get; set; }
    }
}