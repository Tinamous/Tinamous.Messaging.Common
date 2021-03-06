﻿using System;
using System.Collections.Generic;
using AnalysisUK.Tinamous.Messaging.Common.Dtos;
using AnalysisUK.Tinamous.Messaging.Common.Dtos.Enums;

namespace AnalysisUK.Tinamous.Messaging.Common.Events
{
    /// <summary>
    /// Fire detected by a device
    /// </summary>
    /// <see cref="FireWarningEvent"/>
    public class FireDetectedEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public UserSummaryDto User { get; set; }
        public FireAlarmType FireAlarmType { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
    }
}