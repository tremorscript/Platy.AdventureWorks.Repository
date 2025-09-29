using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class VStateProvinceCountryRegionReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'StateProvinceID'.
    /// </summary>
    /// <value>
    /// The property value for 'StateProvinceID'.
    /// </value>
    public int StateProvinceID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'StateProvinceCode'.
    /// </summary>
    /// <value>
    /// The property value for 'StateProvinceCode'.
    /// </value>
    public string StateProvinceCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'IsOnlyStateProvinceFlag'.
    /// </summary>
    /// <value>
    /// The property value for 'IsOnlyStateProvinceFlag'.
    /// </value>
    public bool IsOnlyStateProvinceFlag { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'StateProvinceName'.
    /// </summary>
    /// <value>
    /// The property value for 'StateProvinceName'.
    /// </value>
    public string StateProvinceName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'TerritoryID'.
    /// </summary>
    /// <value>
    /// The property value for 'TerritoryID'.
    /// </value>
    public int TerritoryID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'CountryRegionCode'.
    /// </summary>
    /// <value>
    /// The property value for 'CountryRegionCode'.
    /// </value>
    public string CountryRegionCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'CountryRegionName'.
    /// </summary>
    /// <value>
    /// The property value for 'CountryRegionName'.
    /// </value>
    public string CountryRegionName { get; set; } = null!;

    #endregion

}
