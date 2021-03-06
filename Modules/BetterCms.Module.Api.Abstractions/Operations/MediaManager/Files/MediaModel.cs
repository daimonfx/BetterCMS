﻿using System.Runtime.Serialization;

using BetterCms.Module.Api.Infrastructure;

namespace BetterCms.Module.Api.Operations.MediaManager.Files
{
    [DataContract]
    public class MediaModel : ModelBase
    {
        /// <summary>
        /// Gets or sets the media title.
        /// </summary>
        /// <value>
        /// The media title.
        /// </value>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the type of the media content.
        /// </summary>
        /// <value>
        /// The type of the media content.
        /// </value>
        [DataMember]
        public MediaContentType MediaContentType { get; set; }

        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        [DataMember]
        public string FileExtension { get; set; }

        /// <summary>
        /// Gets or sets the size of the file.
        /// </summary>
        /// <value>
        /// The size of the file.
        /// </value>
        [DataMember]
        public long? FileSize { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [DataMember]
        public string FileUrl { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail URL.
        /// </summary>
        /// <value>
        /// The thumbnail URL.
        /// </value>
        [DataMember]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail id.
        /// </summary>
        /// <value>
        /// The thumbnail id.
        /// </value>
        [DataMember]
        public System.Guid? ThumbnailId { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail caption.
        /// </summary>
        /// <value>
        /// The thumbnail caption.
        /// </value>
        [DataMember]
        public string ThumbnailCaption { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether media is archived.
        /// </summary>
        /// <value>
        /// <c>true</c> if media is archived; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsArchived { get; set; }
    }
}