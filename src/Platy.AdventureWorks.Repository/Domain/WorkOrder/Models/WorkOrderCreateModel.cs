using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class WorkOrderCreateModel
    : IEntityCreateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'WorkOrderID'.
    /// </summary>
    /// <value>
    /// The property value for 'WorkOrderID'.
    /// </value>
    public int WorkOrderID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductID'.
    /// </value>
    public int ProductID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'OrderQty'.
    /// </summary>
    /// <value>
    /// The property value for 'OrderQty'.
    /// </value>
    public int OrderQty { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'StockedQty'.
    /// </summary>
    /// <value>
    /// The property value for 'StockedQty'.
    /// </value>
    public int StockedQty { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ScrappedQty'.
    /// </summary>
    /// <value>
    /// The property value for 'ScrappedQty'.
    /// </value>
    public short ScrappedQty { get; set; }

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
    /// Gets or sets the property value for 'DueDate'.
    /// </summary>
    /// <value>
    /// The property value for 'DueDate'.
    /// </value>
    public DateTime DueDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ScrapReasonID'.
    /// </summary>
    /// <value>
    /// The property value for 'ScrapReasonID'.
    /// </value>
    public short? ScrapReasonID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
