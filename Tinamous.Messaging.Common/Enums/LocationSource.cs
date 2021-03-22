namespace AnalysisUK.Tinamous.Messaging.Common.Enums
{
    /// <summary>
    /// Where the location has come from
    /// </summary>
    public enum LocationSource
    {
        /// <summary>
        /// Unknown location (data previously stored)
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Location has come from the device (i.e. with sensor measurements)
        /// No indication given as to how the device aquired its location
        /// </summary>
        Device = 1,

        /// <summary>
        /// Location come from the device via a GPS system.
        /// </summary>
        DeviceGps =2,

        // Other device location identifiers.

        /// <summary>
        /// Location has come from the stored membership user object
        /// (Check that object for the originating source)
        /// </summary>
        User = 100,

        /// <summary>
        /// GPS location was manually set through the web interface.
        /// </summary>
        ManuallySet = 1000,
    }
}