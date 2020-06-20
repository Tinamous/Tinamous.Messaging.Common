using System;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    public class EarthQuakeEvent
    {
        public UserSummaryDto User { get; set; }

        public double Magnitude { get; set; }

        public LocationDto Location { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}