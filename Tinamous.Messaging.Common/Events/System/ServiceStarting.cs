using System;

namespace AnalysisUK.Tinamous.Messaging.Common.Events.System
{
    public class ServiceStarting
    {
        public DateTime Time { get; set; }
        public string Service { get; set; }
        public string Server { get; set; }
        public string SoftwareVersion { get; set; }
    }
}
