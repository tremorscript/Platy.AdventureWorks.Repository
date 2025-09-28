using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'vStoreWithAddresses'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("vStoreWithAddresses", Schema = "Sales")]
internal partial class VStoreWithAddresses
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithAddresses"/> class.
    /// </summary>
    public VStoreWithAddresses()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'BusinessEntityID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'BusinessEntityID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("BusinessEntityID", TypeName = "int")]
    public int BusinessEntityId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Name'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Name'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Name", TypeName = "nvarchar(50)")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'AddressType'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AddressType'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("AddressType", TypeName = "nvarchar(50)")]
    public string AddressType { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'AddressLine1'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AddressLine1'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("AddressLine1", TypeName = "nvarchar(60)")]
    public string AddressLine1 { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'AddressLine2'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AddressLine2'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("AddressLine2", TypeName = "nvarchar(60)")]
    public string? AddressLine2 { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'City'.
    /// </summary>
    /// <value>
    /// The property value representing column 'City'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("City", TypeName = "nvarchar(30)")]
    public string City { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'StateProvinceName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StateProvinceName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StateProvinceName", TypeName = "nvarchar(50)")]
    public string StateProvinceName { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'PostalCode'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PostalCode'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("PostalCode", TypeName = "nvarchar(15)")]
    public string PostalCode { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'CountryRegionName'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CountryRegionName'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("CountryRegionName", TypeName = "nvarchar(50)")]
    public string CountryRegionName { get; set; } = null!;

    #endregion

    #region Generated Relationships
    #endregion

}
