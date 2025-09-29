using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class SalesTerritoryHistoryReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'BusinessEntityID'.
    /// </summary>
    /// <value>
    /// The property value for 'BusinessEntityID'.
    /// </value>
    public int BusinessEntityID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'TerritoryID'.
    /// </summary>
    /// <value>
    /// The property value for 'TerritoryID'.
    /// </value>
    public int TerritoryID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'StartDate'.
    /// </summary>
    /// <value>
    /// The property value for 'StartDate'.
    /// </value>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'EndDate'.
    /// </summary>
    /// <value>
    /// The property value for 'EndDate'.
    /// </value>
    public DateTime? EndDate { get; set; }

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
