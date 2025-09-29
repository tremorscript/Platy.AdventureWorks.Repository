using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ProductReviewUpdateModel
    : IEntityUpdateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'ProductReviewID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductReviewID'.
    /// </value>
    public int ProductReviewID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductID'.
    /// </value>
    public int ProductID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ReviewerName'.
    /// </summary>
    /// <value>
    /// The property value for 'ReviewerName'.
    /// </value>
    public string ReviewerName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'ReviewDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ReviewDate'.
    /// </value>
    public DateTime ReviewDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'EmailAddress'.
    /// </summary>
    /// <value>
    /// The property value for 'EmailAddress'.
    /// </value>
    public string EmailAddress { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'Rating'.
    /// </summary>
    /// <value>
    /// The property value for 'Rating'.
    /// </value>
    public int Rating { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Comments'.
    /// </summary>
    /// <value>
    /// The property value for 'Comments'.
    /// </value>
    public string? Comments { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
