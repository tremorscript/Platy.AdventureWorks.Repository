using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ProductProductPhotoReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductID'.
    /// </value>
    public int ProductID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ProductPhotoID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductPhotoID'.
    /// </value>
    public int ProductPhotoID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Primary'.
    /// </summary>
    /// <value>
    /// The property value for 'Primary'.
    /// </value>
    public bool Primary { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
