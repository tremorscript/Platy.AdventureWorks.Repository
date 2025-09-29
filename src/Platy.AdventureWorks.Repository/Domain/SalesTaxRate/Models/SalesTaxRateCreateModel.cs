using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class SalesTaxRateCreateModel
    : IEntityCreateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'SalesTaxRateID'.
    /// </summary>
    /// <value>
    /// The property value for 'SalesTaxRateID'.
    /// </value>
    public int SalesTaxRateID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'StateProvinceID'.
    /// </summary>
    /// <value>
    /// The property value for 'StateProvinceID'.
    /// </value>
    public int StateProvinceID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'TaxType'.
    /// </summary>
    /// <value>
    /// The property value for 'TaxType'.
    /// </value>
    public byte TaxType { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'TaxRate'.
    /// </summary>
    /// <value>
    /// The property value for 'TaxRate'.
    /// </value>
    public decimal TaxRate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Name'.
    /// </summary>
    /// <value>
    /// The property value for 'Name'.
    /// </value>
    public string Name { get; set; } = null!;

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
