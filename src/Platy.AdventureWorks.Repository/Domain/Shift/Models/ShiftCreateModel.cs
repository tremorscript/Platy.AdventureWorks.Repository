using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ShiftCreateModel
    : IEntityCreateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'ShiftID'.
    /// </summary>
    /// <value>
    /// The property value for 'ShiftID'.
    /// </value>
    public byte ShiftID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Name'.
    /// </summary>
    /// <value>
    /// The property value for 'Name'.
    /// </value>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'StartTime'.
    /// </summary>
    /// <value>
    /// The property value for 'StartTime'.
    /// </value>
    public TimeOnly StartTime { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'EndTime'.
    /// </summary>
    /// <value>
    /// The property value for 'EndTime'.
    /// </value>
    public TimeOnly EndTime { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
