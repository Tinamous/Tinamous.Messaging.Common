using System;

namespace AnalysisUK.Tinamous.Messaging.Common.Events.System
{
    public class ServiceStopping
    {
        public DateTime Time { get; set; }
        public string Service { get; set; }
        public string Server { get; set; } 
    }
}