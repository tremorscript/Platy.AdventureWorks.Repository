using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class BusinessEntityContactReadModel
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
    /// Gets or sets the property value for 'PersonID'.
    /// </summary>
    /// <value>
    /// The property value for 'PersonID'.
    /// </value>
    public int PersonID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ContactTypeID'.
    /// </summary>
    /// <value>
    /// The property value for 'ContactTypeID'.
    /// </value>
    public int ContactTypeID { get; set; }

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
