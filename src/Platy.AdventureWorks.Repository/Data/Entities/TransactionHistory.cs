using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'TransactionHistory'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("TransactionHistory", Schema = "Production")]
internal partial class TransactionHistory
    : EntityBase<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransactionHistory"/> class.
    /// </summary>
    public TransactionHistory()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'TransactionID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TransactionID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("TransactionID", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductID", TypeName = "int")]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ReferenceOrderID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ReferenceOrderID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ReferenceOrderID", TypeName = "int")]
    public int ReferenceOrderId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ReferenceOrderLineID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ReferenceOrderLineID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ReferenceOrderLineID", TypeName = "int")]
    public int ReferenceOrderLineId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'TransactionDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TransactionDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("TransactionDate", TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'TransactionType'.
    /// </summary>
    /// <value>
    /// The property value representing column 'TransactionType'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("TransactionType", TypeName = "nchar(1)")]
    public string TransactionType { get; set; } = null!;

    /// <summary>
    /// Gets or sets the property value representing column 'Quantity'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Quantity'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Quantity", TypeName = "int")]
    public int Quantity { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ActualCost'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ActualCost'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ActualCost", TypeName = "money")]
    public decimal ActualCost { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="Product" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Product" />.
    /// </value>
    /// <seealso cref="ProductId" />
    public virtual Product Product { get; set; } = null!;

    #endregion

}
