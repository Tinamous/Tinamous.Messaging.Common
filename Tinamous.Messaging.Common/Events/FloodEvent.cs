using System;
using System.Collections.Generic;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    public class FloodEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

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

        public List<string> Tags { get; set; } = new List<string>();
    }
}