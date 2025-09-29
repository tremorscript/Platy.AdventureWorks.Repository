using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class SalesOrderHeaderCreateModel
    : IEntityCreateModel
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
    /// Gets or sets the property value for 'RevisionNumber'.
    /// </summary>
    /// <value>
    /// The property value for 'RevisionNumber'.
    /// </value>
    public byte RevisionNumber { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'OrderDate'.
    /// </summary>
    /// <value>
    /// The property value for 'OrderDate'.
    /// </value>
    public DateTime OrderDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'DueDate'.
    /// </summary>
    /// <value>
    /// The property value for 'DueDate'.
    /// </value>
    public DateTime DueDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ShipDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ShipDate'.
    /// </value>
    public DateTime? ShipDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Status'.
    /// </summary>
    /// <value>
    /// The property value for 'Status'.
    /// </value>
    public byte Status { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'OnlineOrderFlag'.
    /// </summary>
    /// <value>
    /// The property value for 'OnlineOrderFlag'.
    /// </value>
    public bool OnlineOrderFlag { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'SalesOrderNumber'.
    /// </summary>
    /// <value>
    /// The property value for 'SalesOrderNumber'.
    /// </value>
    public string SalesOrderNumber { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'PurchaseOrderNumber'.
    /// </summary>
    /// <value>
    /// The property value for 'PurchaseOrderNumber'.
    /// </value>
    public string? PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'AccountNumber'.
    /// </summary>
    /// <value>
    /// The property value for 'AccountNumber'.
    /// </value>
    public string? AccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'CustomerID'.
    /// </summary>
    /// <value>
    /// The property value for 'CustomerID'.
    /// </value>
    public int CustomerID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'SalesPersonID'.
    /// </summary>
    /// <value>
    /// The property value for 'SalesPersonID'.
    /// </value>
    public int? SalesPersonID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'TerritoryID'.
    /// </summary>
    /// <value>
    /// The property value for 'TerritoryID'.
    /// </value>
    public int? TerritoryID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'BillToAddressID'.
    /// </summary>
    /// <value>
    /// The property value for 'BillToAddressID'.
    /// </value>
    public int BillToAddressID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ShipToAddressID'.
    /// </summary>
    /// <value>
    /// The property value for 'ShipToAddressID'.
    /// </value>
    public int ShipToAddressID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ShipMethodID'.
    /// </summary>
    /// <value>
    /// The property value for 'ShipMethodID'.
    /// </value>
    public int ShipMethodID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'CreditCardID'.
    /// </summary>
    /// <value>
    /// The property value for 'CreditCardID'.
    /// </value>
    public int? CreditCardID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'CreditCardApprovalCode'.
    /// </summary>
    /// <value>
    /// The property value for 'CreditCardApprovalCode'.
    /// </value>
    public string? CreditCardApprovalCode { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'CurrencyRateID'.
    /// </summary>
    /// <value>
    /// The property value for 'CurrencyRateID'.
    /// </value>
    public int? CurrencyRateID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'SubTotal'.
    /// </summary>
    /// <value>
    /// The property value for 'SubTotal'.
    /// </value>
    public decimal SubTotal { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'TaxAmt'.
    /// </summary>
    /// <value>
    /// The property value for 'TaxAmt'.
    /// </value>
    public decimal TaxAmt { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Freight'.
    /// </summary>
    /// <value>
    /// The property value for 'Freight'.
    /// </value>
    public decimal Freight { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'TotalDue'.
    /// </summary>
    /// <value>
    /// The property value for 'TotalDue'.
    /// </value>
    public decimal TotalDue { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Comment'.
    /// </summary>
    /// <value>
    /// The property value for 'Comment'.
    /// </value>
    public string? Comment { get; set; }

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
