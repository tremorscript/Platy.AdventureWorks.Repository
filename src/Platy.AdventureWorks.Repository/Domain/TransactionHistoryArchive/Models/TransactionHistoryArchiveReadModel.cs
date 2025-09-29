using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class TransactionHistoryArchiveReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'TransactionID'.
    /// </summary>
    /// <value>
    /// The property value for 'TransactionID'.
    /// </value>
    public int TransactionID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductID'.
    /// </value>
    public int ProductID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ReferenceOrderID'.
    /// </summary>
    /// <value>
    /// The property value for 'ReferenceOrderID'.
    /// </value>
    public int ReferenceOrderID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ReferenceOrderLineID'.
    /// </summary>
    /// <value>
    /// The property value for 'ReferenceOrderLineID'.
    /// </value>
    public int ReferenceOrderLineID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'TransactionDate'.
    /// </summary>
    /// <value>
    /// The property value for 'TransactionDate'.
    /// </value>
    public DateTime TransactionDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'TransactionType'.
    /// </summary>
    /// <value>
    /// The property value for 'TransactionType'.
    /// </value>
    public string TransactionType { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'Quantity'.
    /// </summary>
    /// <value>
    /// The property value for 'Quantity'.
    /// </value>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ActualCost'.
    /// </summary>
    /// <value>
    /// The property value for 'ActualCost'.
    /// </value>
    public decimal ActualCost { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
