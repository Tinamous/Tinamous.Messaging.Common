using System;
using System.Collections.Generic;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    public class IntruderDetectedEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Device detecting the intruder
        /// </summary>
        public UserSummaryDto User { get; set; }

        /// <summary>
        /// Free text field to indicate the location
        /// (i.e. hall way).
        /// </summary>
        public string Location { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
    }
}