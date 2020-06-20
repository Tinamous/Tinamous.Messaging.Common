using System;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    public class OilLeakEvent
    {
        /// <summary>
        /// Device indicating the oil leak
        /// </summary>
        public UserSummaryDto User { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}