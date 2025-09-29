using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ProductReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductID'.
    /// </value>
    public int ProductID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Name'.
    /// </summary>
    /// <value>
    /// The property value for 'Name'.
    /// </value>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'ProductNumber'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductNumber'.
    /// </value>
    public string ProductNumber { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'MakeFlag'.
    /// </summary>
    /// <value>
    /// The property value for 'MakeFlag'.
    /// </value>
    public bool MakeFlag { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'FinishedGoodsFlag'.
    /// </summary>
    /// <value>
    /// The property value for 'FinishedGoodsFlag'.
    /// </value>
    public bool FinishedGoodsFlag { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Color'.
    /// </summary>
    /// <value>
    /// The property value for 'Color'.
    /// </value>
    public string? Color { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'SafetyStockLevel'.
    /// </summary>
    /// <value>
    /// The property value for 'SafetyStockLevel'.
    /// </value>
    public short SafetyStockLevel { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ReorderPoint'.
    /// </summary>
    /// <value>
    /// The property value for 'ReorderPoint'.
    /// </value>
    public short ReorderPoint { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'StandardCost'.
    /// </summary>
    /// <value>
    /// The property value for 'StandardCost'.
    /// </value>
    public decimal StandardCost { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ListPrice'.
    /// </summary>
    /// <value>
    /// The property value for 'ListPrice'.
    /// </value>
    public decimal ListPrice { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Size'.
    /// </summary>
    /// <value>
    /// The property value for 'Size'.
    /// </value>
    public string? Size { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'SizeUnitMeasureCode'.
    /// </summary>
    /// <value>
    /// The property value for 'SizeUnitMeasureCode'.
    /// </value>
    public string? SizeUnitMeasureCode { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'WeightUnitMeasureCode'.
    /// </summary>
    /// <value>
    /// The property value for 'WeightUnitMeasureCode'.
    /// </value>
    public string? WeightUnitMeasureCode { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Weight'.
    /// </summary>
    /// <value>
    /// The property value for 'Weight'.
    /// </value>
    public decimal? Weight { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'DaysToManufacture'.
    /// </summary>
    /// <value>
    /// The property value for 'DaysToManufacture'.
    /// </value>
    public int DaysToManufacture { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ProductLine'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductLine'.
    /// </value>
    public string? ProductLine { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Class'.
    /// </summary>
    /// <value>
    /// The property value for 'Class'.
    /// </value>
    public string? Class { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Style'.
    /// </summary>
    /// <value>
    /// The property value for 'Style'.
    /// </value>
    public string? Style { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ProductSubcategoryID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductSubcategoryID'.
    /// </value>
    public int? ProductSubcategoryID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ProductModelID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductModelID'.
    /// </value>
    public int? ProductModelID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'SellStartDate'.
    /// </summary>
    /// <value>
    /// The property value for 'SellStartDate'.
    /// </value>
    public DateTime SellStartDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'SellEndDate'.
    /// </summary>
    /// <value>
    /// The property value for 'SellEndDate'.
    /// </value>
    public DateTime? SellEndDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'DiscontinuedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'DiscontinuedDate'.
    /// </value>
    public DateTime? DiscontinuedDate { get; set; }

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
