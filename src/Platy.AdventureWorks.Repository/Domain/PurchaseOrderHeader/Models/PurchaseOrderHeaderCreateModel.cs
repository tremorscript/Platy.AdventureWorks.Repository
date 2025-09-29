using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class PurchaseOrderHeaderCreateModel
    : IEntityCreateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'PurchaseOrderID'.
    /// </summary>
    /// <value>
    /// The property value for 'PurchaseOrderID'.
    /// </value>
    public int PurchaseOrderID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'RevisionNumber'.
    /// </summary>
    /// <value>
    /// The property value for 'RevisionNumber'.
    /// </value>
    public byte RevisionNumber { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Status'.
    /// </summary>
    /// <value>
    /// The property value for 'Status'.
    /// </value>
    public byte Status { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'EmployeeID'.
    /// </summary>
    /// <value>
    /// The property value for 'EmployeeID'.
    /// </value>
    public int EmployeeID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'VendorID'.
    /// </summary>
    /// <value>
    /// The property value for 'VendorID'.
    /// </value>
    public int VendorID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ShipMethodID'.
    /// </summary>
    /// <value>
    /// The property value for 'ShipMethodID'.
    /// </value>
    public int ShipMethodID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'OrderDate'.
    /// </summary>
    /// <value>
    /// The property value for 'OrderDate'.
    /// </value>
    public DateTime OrderDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ShipDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ShipDate'.
    /// </value>
    public DateTime? ShipDate { get; set; }

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
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
