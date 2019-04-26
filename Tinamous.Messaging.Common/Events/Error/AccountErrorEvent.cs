using System;
using AnalysisUK.Tinamous.Messaging.Common.Enums;

namespace AnalysisUK.Tinamous.Messaging.Common.Events.Error
{
    /// <summary>
    /// An error event occurred for the account specified.
    /// </summary>
    /// <remarks>
    /// These events may be exposable to the user to help them understand what is happening with their account.
    /// </remarks>
    public class AccountErrorEvent
    {
        private readonly Guid _id = Guid.NewGuid();

        public Guid Id { get { return _id; } }

        public Guid AccountId { get; set; }

        /// <summary>
        /// If appropriate, the user this error event occured for
        /// </summary>
        public Guid UserId { get; set; }

        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }
        public Source Source { get; set; }

        /// <summary>
        /// If this error should be hidden from the user.
        /// </summary>
        public bool Hidden { get; set; }
    }
}