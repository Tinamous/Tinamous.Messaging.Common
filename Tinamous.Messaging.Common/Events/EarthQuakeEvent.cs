using System;
using System.Collections.Generic;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    public class EarthQuakeEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public UserSummaryDto User { get; set; }

        public double Magnitude { get; set; }

        public LocationDto Location { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
    }
}