using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ProductPhotoReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'ProductPhotoID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductPhotoID'.
    /// </value>
    public int ProductPhotoID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ThumbNailPhoto'.
    /// </summary>
    /// <value>
    /// The property value for 'ThumbNailPhoto'.
    /// </value>
    public byte[]? ThumbNailPhoto { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ThumbnailPhotoFileName'.
    /// </summary>
    /// <value>
    /// The property value for 'ThumbnailPhotoFileName'.
    /// </value>
    public string? ThumbnailPhotoFileName { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'LargePhoto'.
    /// </summary>
    /// <value>
    /// The property value for 'LargePhoto'.
    /// </value>
    public byte[]? LargePhoto { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'LargePhotoFileName'.
    /// </summary>
    /// <value>
    /// The property value for 'LargePhotoFileName'.
    /// </value>
    public string? LargePhotoFileName { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
