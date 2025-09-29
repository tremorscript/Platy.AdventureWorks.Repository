using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class PersonCreditCardCreateModel
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
    /// Gets or sets the property value for 'CreditCardID'.
    /// </summary>
    /// <value>
    /// The property value for 'CreditCardID'.
    /// </value>
    public int CreditCardID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
