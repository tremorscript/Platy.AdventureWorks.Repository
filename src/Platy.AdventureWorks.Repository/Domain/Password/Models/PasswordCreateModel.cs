using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class PasswordCreateModel
    : IEntityCreateModel
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
    /// Gets or sets the property value for 'PasswordHash'.
    /// </summary>
    /// <value>
    /// The property value for 'PasswordHash'.
    /// </value>
    public string PasswordHash { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'PasswordSalt'.
    /// </summary>
    /// <value>
    /// The property value for 'PasswordSalt'.
    /// </value>
    public string PasswordSalt { get; set; } = null!;

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
