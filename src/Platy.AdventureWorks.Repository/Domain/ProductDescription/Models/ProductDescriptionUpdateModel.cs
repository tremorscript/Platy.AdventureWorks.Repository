using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ProductDescriptionUpdateModel
    : IEntityUpdateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'ProductDescriptionID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductDescriptionID'.
    /// </value>
    public int ProductDescriptionID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Description'.
    /// </summary>
    /// <value>
    /// The property value for 'Description'.
    /// </value>
    public string Description { get; set; } = null!;

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
