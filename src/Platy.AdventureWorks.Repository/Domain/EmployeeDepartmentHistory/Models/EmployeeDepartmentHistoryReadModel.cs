using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class EmployeeDepartmentHistoryReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'BusinessEntityID'.
    /// </summary>
    /// <value>
    /// The property value for 'BusinessEntityID'.
    /// </value>
    public int BusinessEntityID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'DepartmentID'.
    /// </summary>
    /// <value>
    /// The property value for 'DepartmentID'.
    /// </value>
    public short DepartmentID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ShiftID'.
    /// </summary>
    /// <value>
    /// The property value for 'ShiftID'.
    /// </value>
    public byte ShiftID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'StartDate'.
    /// </summary>
    /// <value>
    /// The property value for 'StartDate'.
    /// </value>
    public DateOnly StartDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'EndDate'.
    /// </summary>
    /// <value>
    /// The property value for 'EndDate'.
    /// </value>
    public DateOnly? EndDate { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
