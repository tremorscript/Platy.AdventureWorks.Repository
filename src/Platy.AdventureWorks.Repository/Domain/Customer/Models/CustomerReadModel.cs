using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class CustomerReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'CustomerID'.
    /// </summary>
    /// <value>
    /// The property value for 'CustomerID'.
    /// </value>
    public int CustomerID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'PersonID'.
    /// </summary>
    /// <value>
    /// The property value for 'PersonID'.
    /// </value>
    public int? PersonID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'StoreID'.
    /// </summary>
    /// <value>
    /// The property value for 'StoreID'.
    /// </value>
    public int? StoreID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'TerritoryID'.
    /// </summary>
    /// <value>
    /// The property value for 'TerritoryID'.
    /// </value>
    public int? TerritoryID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'AccountNumber'.
    /// </summary>
    /// <value>
    /// The property value for 'AccountNumber'.
    /// </value>
    public string AccountNumber { get; set; } = null!;

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
