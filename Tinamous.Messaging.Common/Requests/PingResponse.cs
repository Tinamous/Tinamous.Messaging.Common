using System;

namespace AnalysisUK.Tinamous.Messaging.Common.Requests
{
    /// <summary>
    /// When Ping Request comes via RPC channel, use the PingResponse, otherwise use PongEvent
    /// </summary>
    public class PingResponse
    {
        /// <summary>
        /// The Id of the Ping event we are replying to
        /// </summary>
        public Guid Id { get; set; }
        public string ServiceName { get; set; }
        public string Server { get; set; }
        public string SoftwareVersion { get; set; }
        public DateTime DateTime { get; set; }
    }
}