using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ProductInventoryCreateModel
    : IEntityCreateModel
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
    /// Gets or sets the property value for 'LocationID'.
    /// </summary>
    /// <value>
    /// The property value for 'LocationID'.
    /// </value>
    public short LocationID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Shelf'.
    /// </summary>
    /// <value>
    /// The property value for 'Shelf'.
    /// </value>
    public string Shelf { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'Bin'.
    /// </summary>
    /// <value>
    /// The property value for 'Bin'.
    /// </value>
    public byte Bin { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Quantity'.
    /// </summary>
    /// <value>
    /// The property value for 'Quantity'.
    /// </value>
    public short Quantity { get; set; }

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
