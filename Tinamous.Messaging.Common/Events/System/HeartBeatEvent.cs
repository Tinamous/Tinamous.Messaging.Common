using System;
using System.Collections.Generic;
using AnalysisUK.Tinamous.Messaging.Common.Dtos.System;

namespace AnalysisUK.Tinamous.Messaging.Common.Events.System
{
    /// <summary>
    /// Heartbeat event published by a service to indicate it's running and
    /// to include some statistics on the service/process/machine.
    /// </summary>
    public class HeartBeatEvent
    {
        public DateTime Time { get; set; }

        /// <summary>
        /// Name of the service
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Name of the server.
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// Heartbeat interval for the service.
        /// </summary>
        public int IntervalSeconds { get; set; }

        /// <summary>
        /// Software version running on the machine.
        /// </summary>
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// If the service is the master service where appropriate
        /// </summary>
        public bool IsMaster { get; set; }

        public ProcessInfo ProcessInfo { get; set; }

        public MachineInfo MachineInfo { get; set; }

        public List<RecordsProcessed> RecordsProcessed { get; set; }

        /// <summary>
        /// Freeform meta data.
        /// </summary>
        public string MetaData { get; set; }
    }
}