using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Repository.Data.Entities;

/// <summary>
/// Entity class representing data for table 'ProductProductPhoto'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("ProductProductPhoto", Schema = "Production")]
internal partial class ProductProductPhoto
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductProductPhoto"/> class.
    /// </summary>
    public ProductProductPhoto()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'ProductID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductID", TypeName = "int")]
    public int ProductId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ProductPhotoID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ProductPhotoID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ProductPhotoID", TypeName = "int")]
    public int ProductPhotoId { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'Primary'.
    /// </summary>
    /// <value>
    /// The property value representing column 'Primary'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("Primary", TypeName = "bit")]
    public bool Primary { get; set; }

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
    /// Gets or sets the navigation property for entity <see cref="ProductPhoto" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="ProductPhoto" />.
    /// </value>
    /// <seealso cref="ProductPhotoId" />
    public virtual ProductPhoto ProductPhoto { get; set; } = null!;

    #endregion

}
