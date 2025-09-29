using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class PersonPhoneReadModel
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
    /// Gets or sets the property value for 'PhoneNumber'.
    /// </summary>
    /// <value>
    /// The property value for 'PhoneNumber'.
    /// </value>
    public string PhoneNumber { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'PhoneNumberTypeID'.
    /// </summary>
    /// <value>
    /// The property value for 'PhoneNumberTypeID'.
    /// </value>
    public int PhoneNumberTypeID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
