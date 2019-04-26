namespace AnalysisUK.Tinamous.Messaging.Common.Dtos.System
{
    /// <summary>
    /// Heartbeat system process information
    /// </summary>
    public class ProcessInfo
    {
        public long PrivateMemorySize64 { get; set; }
        public int CpuUsage { get; set; }
    }
}