using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ProductModelProductDescriptionCultureReadModel
    : IEntityReadModel
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
    /// Gets or sets the property value for 'ProductDescriptionID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductDescriptionID'.
    /// </value>
    public int ProductDescriptionID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'CultureID'.
    /// </summary>
    /// <value>
    /// The property value for 'CultureID'.
    /// </value>
    public string CultureID { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
