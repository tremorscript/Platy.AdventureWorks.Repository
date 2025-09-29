using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ProductModelCreateModel
    : IEntityCreateModel
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
    /// Gets or sets the property value for 'Name'.
    /// </summary>
    /// <value>
    /// The property value for 'Name'.
    /// </value>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'CatalogDescription'.
    /// </summary>
    /// <value>
    /// The property value for 'CatalogDescription'.
    /// </value>
    public string? CatalogDescription { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Instructions'.
    /// </summary>
    /// <value>
    /// The property value for 'Instructions'.
    /// </value>
    public string? Instructions { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Rowguid'.
    /// </summary>
    /// <value>
    /// The property value for 'Rowguid'.
    /// </value>
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
