using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class VProductAndDescriptionCreateModel
    : IEntityCreateModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductID'.
    /// </value>
    public int ProductID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'Name'.
    /// </summary>
    /// <value>
    /// The property value for 'Name'.
    /// </value>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'ProductModel'.
    /// </summary>
    /// <value>
    /// The property value for 'ProductModel'.
    /// </value>
    public string ProductModel { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'CultureID'.
    /// </summary>
    /// <value>
    /// The property value for 'CultureID'.
    /// </value>
    public string CultureID { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'Description'.
    /// </summary>
    /// <value>
    /// The property value for 'Description'.
    /// </value>
    public string Description { get; set; } = null!;

    #endregion

}
