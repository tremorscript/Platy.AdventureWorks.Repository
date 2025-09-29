using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class CurrencyRateReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'CurrencyRateID'.
    /// </summary>
    /// <value>
    /// The property value for 'CurrencyRateID'.
    /// </value>
    public int CurrencyRateID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'CurrencyRateDate'.
    /// </summary>
    /// <value>
    /// The property value for 'CurrencyRateDate'.
    /// </value>
    public DateTime CurrencyRateDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'FromCurrencyCode'.
    /// </summary>
    /// <value>
    /// The property value for 'FromCurrencyCode'.
    /// </value>
    public string FromCurrencyCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'ToCurrencyCode'.
    /// </summary>
    /// <value>
    /// The property value for 'ToCurrencyCode'.
    /// </value>
    public string ToCurrencyCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'AverageRate'.
    /// </summary>
    /// <value>
    /// The property value for 'AverageRate'.
    /// </value>
    public decimal AverageRate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'EndOfDayRate'.
    /// </summary>
    /// <value>
    /// The property value for 'EndOfDayRate'.
    /// </value>
    public decimal EndOfDayRate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
