using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class StateProvinceReadModel
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
    /// Gets or sets the property value for 'CountryRegionCode'.
    /// </summary>
    /// <value>
    /// The property value for 'CountryRegionCode'.
    /// </value>
    public string CountryRegionCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'IsOnlyStateProvinceFlag'.
    /// </summary>
    /// <value>
    /// The property value for 'IsOnlyStateProvinceFlag'.
    /// </value>
    public bool IsOnlyStateProvinceFlag { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Name'.
    /// </summary>
    /// <value>
    /// The property value for 'Name'.
    /// </value>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'TerritoryID'.
    /// </summary>
    /// <value>
    /// The property value for 'TerritoryID'.
    /// </value>
    public int TerritoryID { get; set; }

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
