using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Domain.Models;

/// <summary>
/// View Model class
/// </summary>
public partial class AddressReadModel
    : IEntityReadModel
{
    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value for 'AddressID'.
    /// </summary>
    /// <value>
    /// The property value for 'AddressID'.
    /// </value>
    public int AddressID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'AddressLine1'.
    /// </summary>
    /// <value>
    /// The property value for 'AddressLine1'.
    /// </value>
    public string AddressLine1 { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'AddressLine2'.
    /// </summary>
    /// <value>
    /// The property value for 'AddressLine2'.
    /// </value>
    public string? AddressLine2 { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'City'.
    /// </summary>
    /// <value>
    /// The property value for 'City'.
    /// </value>
    public string City { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value for 'StateProvinceID'.
    /// </summary>
    /// <value>
    /// The property value for 'StateProvinceID'.
    /// </value>
    public int StateProvinceID { get; set; }

    /// <summary>
    /// Gets or sets the property value for 'PostalCode'.
    /// </summary>
    /// <value>
    /// The property value for 'PostalCode'.
    /// </value>
    public string PostalCode { get; set; } = null!;

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
