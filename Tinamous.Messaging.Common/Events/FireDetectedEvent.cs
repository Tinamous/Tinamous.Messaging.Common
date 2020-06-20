using System;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;
using AnalysisUK.Tinamous.Messaging.Common.Dtos.Enums;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    /// <summary>
    /// Fire detected by a device
    /// </summary>
    /// <see cref="FireWarningEvent"/>
    public class FireDetectedEvent
    {
        public UserSummaryDto User { get; set; }
        public FireAlarmType FireAlarmType { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}