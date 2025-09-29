using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class SalesOrderHeaderSalesReasonUpdateModel
    : IEntityUpdateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'SalesOrderID'.
    /// </summary>
    /// <value>
    /// The property value for 'SalesOrderID'.
    /// </value>
    public int SalesOrderID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'SalesReasonID'.
    /// </summary>
    /// <value>
    /// The property value for 'SalesReasonID'.
    /// </value>
    public int SalesReasonID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
