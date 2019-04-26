using System;

namespace AnalysisUK.Tinamous.Messaging.Common.Events.System
{
    /// <summary>
    /// A event raised responding to a PingRequest.
    /// </summary>
    public class PongEvent
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