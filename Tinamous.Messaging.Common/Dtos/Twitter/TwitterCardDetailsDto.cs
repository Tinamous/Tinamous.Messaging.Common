using System;

namespace AnalysisUK.Tinamous.Messaging.Common.Dtos.Twitter
{
    /// <summary>
    /// Twitter card used for a device or device field.
    /// </summary>
    public class TwitterCardDetailsDto
    {
        /// <summary>
        /// The card to use (e.g. summary_large_image).
        /// Do not use this directly in the meta-tag, use GetMetaTagCardName to get the 
        /// meta tag compatible version
        /// </summary>
        /// <remarks>
        ///  Twitter card name. Not to be used in the meta tag.
        /// </remarks>
        public TwitterCardName Card { get; set; }

        /// <summary>
        /// Used for meta twitter:site
        /// </summary>
        public string Site { get; set; }

        /// <summary>
        /// Used for meta twitter:creator
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// Used for meta twitter:tittle
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Used for meta twitter:description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The style of card to use.
        /// </summary>
        /// <remarks>
        ///     Not all card images styles are appropriate for a certain twitter card.
        /// </remarks>
        public TwitterCardImageStyle TwitterCardImageStyle { get; set; }

        /// <summary>
        /// The chart template to use when generating the twitter card.
        /// </summary>
        /// <remarks>
        /// Leave this as Guid.Empty for the default line chart.
        /// 
        /// Not needed for every TwitterCardStyle.
        /// </remarks>
        public Guid ChartTemplateId { get; set; }
    }
}