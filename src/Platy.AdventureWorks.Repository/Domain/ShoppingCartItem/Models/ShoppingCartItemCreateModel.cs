using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class ShoppingCartItemCreateModel
    : IEntityCreateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'ShoppingCartItemID'.
    /// </summary>
    /// <value>
    /// The property value for 'ShoppingCartItemID'.
    /// </value>
    public int ShoppingCartItemID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ShoppingCartID'.
    /// </summary>
    /// <value>
    /// The property value for 'ShoppingCartID'.
    /// </value>
    public string ShoppingCartID { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'Quantity'.
    /// </summary>
    /// <value>
    /// The property value for 'Quantity'.
    /// </value>
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductID'.
    /// </value>
    public int ProductID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'DateCreated'.
    /// </summary>
    /// <value>
    /// The property value for 'DateCreated'.
    /// </value>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value for 'ModifiedDate'.
    /// </value>
    public DateTime ModifiedDate { get; set; }

    #endregion

}
