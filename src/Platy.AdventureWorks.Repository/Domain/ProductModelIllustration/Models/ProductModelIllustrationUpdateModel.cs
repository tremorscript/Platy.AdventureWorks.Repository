using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ProductModelIllustrationUpdateModel
    : IEntityUpdateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'ProductModelID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductModelID'.
    /// </value>
    public int ProductModelID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'IllustrationID'.
    /// </summary>
    /// <value>
    /// The property value for 'IllustrationID'.
    /// </value>
    public int IllustrationID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
