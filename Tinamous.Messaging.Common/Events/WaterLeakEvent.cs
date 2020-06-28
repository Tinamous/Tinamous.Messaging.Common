using System;
using System.Collections.Generic;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    public class WaterLeakEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Device indicating the water leak
        /// </summary>
        public UserSummaryDto User { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
    }
}