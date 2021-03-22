﻿using System;
using AnalysisUK.Tinamous.Messaging.Common.Enums;

namespace AnalysisUK.Tinamous.Messaging.Common.Dtos
{
    public class LocationDto
    {
        /// <summary>
        /// Mongo Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The WellKnownLocationId
        /// </summary>
        public Guid WellKnownLocationId { get; set; }

        /// <summary>
        /// Friendly name of the location
        /// </summary>
        /// <remarks>
        /// This may be null or empty if the location is unknown.
        /// </remarks>
        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double Elevation { get; set; }

        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Where this location came from.
        /// i.e. for a measurement where it gets the location from the user
        /// object, this would be User. When assigned to the User object
        /// this might be Device or Manually set.
        /// </summary>
        public LocationSource LocationSource { get; set; }
    }
}