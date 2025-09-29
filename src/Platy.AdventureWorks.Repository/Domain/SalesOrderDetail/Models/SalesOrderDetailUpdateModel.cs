using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class SalesOrderDetailUpdateModel
    : IEntityUpdateModel
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
    /// Gets or sets the property value for 'SalesOrderDetailID'.
    /// </summary>
    /// <value>
    /// The property value for 'SalesOrderDetailID'.
    /// </value>
    public int SalesOrderDetailID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'CarrierTrackingNumber'.
    /// </summary>
    /// <value>
    /// The property value for 'CarrierTrackingNumber'.
    /// </value>
    public string? CarrierTrackingNumber { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'OrderQty'.
    /// </summary>
    /// <value>
    /// The property value for 'OrderQty'.
    /// </value>
    public short OrderQty { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductID'.
    /// </value>
    public int ProductID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'SpecialOfferID'.
    /// </summary>
    /// <value>
    /// The property value for 'SpecialOfferID'.
    /// </value>
    public int SpecialOfferID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'UnitPrice'.
    /// </summary>
    /// <value>
    /// The property value for 'UnitPrice'.
    /// </value>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'UnitPriceDiscount'.
    /// </summary>
    /// <value>
    /// The property value for 'UnitPriceDiscount'.
    /// </value>
    public decimal UnitPriceDiscount { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'LineTotal'.
    /// </summary>
    /// <value>
    /// The property value for 'LineTotal'.
    /// </value>
    public decimal LineTotal { get; set; }

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
