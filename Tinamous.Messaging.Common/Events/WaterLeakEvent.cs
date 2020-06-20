using System;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    public class WaterLeakEvent
    {
        /// <summary>
        /// Device indicating the water leak
        /// </summary>
        public UserSummaryDto User { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}