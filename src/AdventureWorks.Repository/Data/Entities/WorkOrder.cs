using System;
using System.Collections.Generic;

namespace AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'WorkOrder'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("WorkOrder", Schema = "Production")]
internal partial class WorkOrder
    : EntityBase<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkOrder"/> class.
    /// </summary>
    public WorkOrder()
    {
        #region Generated Constructor
        WorkOrderRoutings = new HashSet<WorkOrderRouting>();
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'WorkOrderID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'WorkOrderID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("WorkOrderID", TypeName = "int")]
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
    /// Gets or sets the property value representing column 'OrderQty'.
    /// </summary>
    /// <value>
    /// The property value representing column 'OrderQty'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("OrderQty", TypeName = "int")]
    public int OrderQty { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'StockedQty'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StockedQty'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StockedQty", TypeName = "int")]
    [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed)]
    public int StockedQty { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ScrappedQty'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ScrappedQty'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ScrappedQty", TypeName = "smallint")]
    public short ScrappedQty { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'StartDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'StartDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("StartDate", TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'EndDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'EndDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("EndDate", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'DueDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'DueDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("DueDate", TypeName = "datetime")]
    public DateTime DueDate { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ScrapReasonID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ScrapReasonID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ScrapReasonID", TypeName = "smallint")]
    public short? ScrapReasonId { get; set; }

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

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="ScrapReason" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="ScrapReason" />.
    /// </value>
    /// <seealso cref="ScrapReasonId" />
    public virtual ScrapReason? ScrapReason { get; set; }

    /// <summary>
    /// Gets or sets the navigation collection for entity <see cref="WorkOrderRouting" />.
    /// </summary>
    /// <value>
    /// The navigation collection for entity <see cref="WorkOrderRouting" />.
    /// </value>
    public virtual ICollection<WorkOrderRouting> WorkOrderRoutings { get; set; }

    #endregion

}
