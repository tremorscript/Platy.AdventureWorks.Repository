using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class EmployeePayHistoryUpdateModel
    : IEntityUpdateModel
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
    /// Gets or sets the property value for 'RateChangeDate'.
    /// </summary>
    /// <value>
    /// The property value for 'RateChangeDate'.
    /// </value>
    public DateTime RateChangeDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Rate'.
    /// </summary>
    /// <value>
    /// The property value for 'Rate'.
    /// </value>
    public decimal Rate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'PayFrequency'.
    /// </summary>
    /// <value>
    /// The property value for 'PayFrequency'.
    /// </value>
    public byte PayFrequency { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
