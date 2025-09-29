using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'Customer'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("Customer", Schema = "Sales")]
internal partial class Customer
    : EntityBase<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Customer"/> class.
    /// </summary>
    public Customer()
    {
        #region Generated Constructor
        SalesOrderHeaders = new HashSet<SalesOrderHeader>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'CustomerID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'CustomerID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("CustomerID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'PersonID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PersonID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("PersonID", TypeName = "int")]
    public int? PersonId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'StoreID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StoreID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StoreID", TypeName = "int")]
    public int? StoreId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'TerritoryID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TerritoryID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("TerritoryID", TypeName = "int")]
    public int? TerritoryId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'AccountNumber'.
    /// </summary>
    /// <value>
    /// The property value representing column 'AccountNumber'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("AccountNumber", TypeName = "varchar(10)")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
    public string AccountNumber { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'rowguid'.
    /// </summary>
    /// <value>
    /// The property value representing column 'rowguid'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("rowguid", TypeName = "uniqueidentifier")]
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ModifiedDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ModifiedDate", TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Person" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Person" />.
    /// </value>
    /// <seealso cref="PersonId" />
    public virtual Person? Person { get; set; }

    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="SalesOrderHeader" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="SalesOrderHeader" />.
    /// </value>
    public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="SalesTerritory" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="SalesTerritory" />.
    /// </value>
    /// <seealso cref="TerritoryId" />
    public virtual SalesTerritory? SalesTerritory { get; set; }

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Store" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Store" />.
    /// </value>
    /// <seealso cref="StoreId" />
    public virtual Store? Store { get; set; }

    #endregion

}
