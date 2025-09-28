using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'CountryRegionCurrency'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("CountryRegionCurrency", Schema = "Sales")]
internal partial class CountryRegionCurrency
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CountryRegionCurrency"/> class.
    /// </summary>
    public CountryRegionCurrency()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'CountryRegionCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CountryRegionCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("CountryRegionCode", TypeName = "nvarchar(3)")]
    public string CountryRegionCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'CurrencyCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CurrencyCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("CurrencyCode", TypeName = "nchar(3)")]
    public string CurrencyCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ModifiedDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ModifiedDate", TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="CountryRegion" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="CountryRegion" />.
    /// </value>
    /// <seealso cref="CountryRegionCode" />
    public virtual CountryRegion CountryRegion { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Currency" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Currency" />.
    /// </value>
    /// <seealso cref="CurrencyCode" />
    public virtual Currency Currency { get; set; } = null!;

    #endregion

}
