using System;
using System.Collections.Generic;

namespace AnalysisUK.Tinamous.Messaging.Common.Dtos.System
{
    /// <summary>
    /// Heartbeat system process information
    /// </summary>
    public class ProcessInfo
    {
        public long PrivateMemorySize64 { get; set; }
        public int CpuUsage { get; set; }
        public int Threads { get; set; }
        public TimeSpan TotalProcessorTime { get; set; }
        public TimeSpan UserProcessorTime { get; set; }
        public DateTime StartTime { get; set; }
        public long VirtualMemorySize { get; set; }
        public long WorkingSet { get; set; }

        public Dictionary<string, string> More { get; set; } = new Dictionary<string, string>();
    }
}