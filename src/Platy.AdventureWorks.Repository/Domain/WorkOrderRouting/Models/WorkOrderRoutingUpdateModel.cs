using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class WorkOrderRoutingUpdateModel
    : IEntityUpdateModel
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
    /// Gets or sets the property value for 'OperationSequence'.
    /// </summary>
    /// <value>
    /// The property value for 'OperationSequence'.
    /// </value>
    public short OperationSequence { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'LocationID'.
    /// </summary>
    /// <value>
    /// The property value for 'LocationID'.
    /// </value>
    public short LocationID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ScheduledStartDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ScheduledStartDate'.
    /// </value>
    public DateTime ScheduledStartDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ScheduledEndDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ScheduledEndDate'.
    /// </value>
    public DateTime ScheduledEndDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ActualStartDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ActualStartDate'.
    /// </value>
    public DateTime? ActualStartDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ActualEndDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ActualEndDate'.
    /// </value>
    public DateTime? ActualEndDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ActualResourceHrs'.
    /// </summary>
    /// <value>
    /// The property value for 'ActualResourceHrs'.
    /// </value>
    public decimal? ActualResourceHrs { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'PlannedCost'.
    /// </summary>
    /// <value>
    /// The property value for 'PlannedCost'.
    /// </value>
    public decimal PlannedCost { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ActualCost'.
    /// </summary>
    /// <value>
    /// The property value for 'ActualCost'.
    /// </value>
    public decimal? ActualCost { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
