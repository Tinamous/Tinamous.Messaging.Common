using System;

namespace AnalysisUK.Tinamous.Messaging.Common.Dtos
{
    public class UserSummaryDto
    {
        /// <summary>
        /// Primary key (Mongo DB Id) for the user.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Account Id.
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// Account Name
        /// </summary>
        /// <remarks>Optional</remarks>
        public string AccountName { get; set; }

        /// <summary>
        /// @Username
        /// </summary>
        /// <remarks>Optional</remarks>
        public string UserName { get; set; }

        /// <summary>
        /// Full Username (Username.AccountName)
        /// </summary>
        /// <remarks>Optional</remarks>
        public string FullUserName { get; set; }

        /// <summary>
        /// Display Name. Full human friendly readable name.
        /// </summary>
        /// <example>Spider Logger</example>
        /// <remarks>Optional</remarks>
        public string FullName { get; set; }
    }
}
