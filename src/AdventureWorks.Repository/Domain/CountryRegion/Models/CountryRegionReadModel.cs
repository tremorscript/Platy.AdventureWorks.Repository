using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class CountryRegionReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'CountryRegionCode'.
    /// </summary>
    /// <value>
    /// The property value for 'CountryRegionCode'.
    /// </value>
    public string CountryRegionCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'Name'.
    /// </summary>
    /// <value>
    /// The property value for 'Name'.
    /// </value>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
