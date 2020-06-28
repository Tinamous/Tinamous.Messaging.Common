using System;
using System.Collections.Generic;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;
using AnalysisUK.Tinamous.Messaging.Common.Dtos.Enums;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    public class GasLeakEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Device indicating the gas leak
        /// </summary>
        public UserSummaryDto User { get; set; }

        /// <summary>
        /// The type of gas (CO / CO2, natural / chlorine / VOC etc.).
        /// Device is responsible for populating this based on
        /// the sensor type
        /// </summary>
        public GasType Gas { get; set; }

        /// <summary>
        /// The gas level (i.e. 200 [ppm]).
        /// </summary>
        /// <remarks>Units should be used to set the units.</remarks>
        public double Level { get; set; }

        public string Units { get; set; }

        public string Message { get; set; }

        public DateTime Date { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
    }
}