using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class BillOfMaterialsReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'BillOfMaterialsID'.
    /// </summary>
    /// <value>
    /// The property value for 'BillOfMaterialsID'.
    /// </value>
    public int BillOfMaterialsID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ProductAssemblyID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductAssemblyID'.
    /// </value>
    public int? ProductAssemblyID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ComponentID'.
    /// </summary>
    /// <value>
    /// The property value for 'ComponentID'.
    /// </value>
    public int ComponentID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'StartDate'.
    /// </summary>
    /// <value>
    /// The property value for 'StartDate'.
    /// </value>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'EndDate'.
    /// </summary>
    /// <value>
    /// The property value for 'EndDate'.
    /// </value>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'UnitMeasureCode'.
    /// </summary>
    /// <value>
    /// The property value for 'UnitMeasureCode'.
    /// </value>
    public string UnitMeasureCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'BOMLevel'.
    /// </summary>
    /// <value>
    /// The property value for 'BOMLevel'.
    /// </value>
    public short BOMLevel { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'PerAssemblyQty'.
    /// </summary>
    /// <value>
    /// The property value for 'PerAssemblyQty'.
    /// </value>
    public decimal PerAssemblyQty { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
