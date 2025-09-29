using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ContactTypeCreateModel
    : IEntityCreateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'ContactTypeID'.
    /// </summary>
    /// <value>
    /// The property value for 'ContactTypeID'.
    /// </value>
    public int ContactTypeID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Name'.
    /// </summary>
    /// <value>
    /// The property value for 'Name'.
    /// </value>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
