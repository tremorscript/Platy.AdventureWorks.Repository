using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class PersonCreditCardReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'BusinessEntityId'.
    /// </summary>
    /// <value>
    /// The property value for 'BusinessEntityId'.
    /// </value>
    public int BusinessEntityId { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'CreditCardId'.
    /// </summary>
    /// <value>
    /// The property value for 'CreditCardId'.
    /// </value>
    public int CreditCardId { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
