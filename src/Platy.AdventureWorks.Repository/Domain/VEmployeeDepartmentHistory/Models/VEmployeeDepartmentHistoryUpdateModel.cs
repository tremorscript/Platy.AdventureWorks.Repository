using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class VEmployeeDepartmentHistoryUpdateModel
    : IEntityUpdateModel
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
    /// Gets or sets the property value for 'Title'.
    /// </summary>
    /// <value>
    /// The property value for 'Title'.
    /// </value>
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'FirstName'.
    /// </summary>
    /// <value>
    /// The property value for 'FirstName'.
    /// </value>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'MiddleName'.
    /// </summary>
    /// <value>
    /// The property value for 'MiddleName'.
    /// </value>
    public string? MiddleName { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'LastName'.
    /// </summary>
    /// <value>
    /// The property value for 'LastName'.
    /// </value>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'Suffix'.
    /// </summary>
    /// <value>
    /// The property value for 'Suffix'.
    /// </value>
    public string? Suffix { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Shift'.
    /// </summary>
    /// <value>
    /// The property value for 'Shift'.
    /// </value>
    public string Shift { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'Department'.
    /// </summary>
    /// <value>
    /// The property value for 'Department'.
    /// </value>
    public string Department { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'GroupName'.
    /// </summary>
    /// <value>
    /// The property value for 'GroupName'.
    /// </value>
    public string GroupName { get; set; } = null!;

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

    #endregion

}
