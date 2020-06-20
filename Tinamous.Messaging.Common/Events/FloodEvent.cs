using System;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    public class FloodEvent
    {
        /// <summary>
        /// Device indicating the flood
        /// </summary>
        public UserSummaryDto User { get; set; }

        /// <summary>
        /// flood level detected
        /// </summary>
        public int Level { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}