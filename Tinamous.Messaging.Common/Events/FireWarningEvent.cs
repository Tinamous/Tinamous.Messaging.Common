using System;
using System.Collections.Generic;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;
using AnalysisUK.Tinamous.Messaging.Common.Dtos.Enums;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    /// <summary>
    /// Potential fire, or events leading to a fire detected
    /// i.e. initial "heads up" smoke detected
    /// </summary>
    public class FireWarningEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Device indicating the fire warning
        /// </summary>
        public UserSummaryDto User { get; set; }

        public FireAlarmType FireAlarmType { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
    }
}