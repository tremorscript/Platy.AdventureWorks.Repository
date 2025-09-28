using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="AdventureWorks.Repository.Data.Entities.ScrapReason" />
/// </summary>
internal partial class ScrapReasonConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.ScrapReason>
{
    /// <summary>
    /// Configures the entity of type <see cref="AdventureWorks.Repository.Data.Entities.ScrapReason" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.ScrapReason> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("ScrapReason", "Production");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("ScrapReasonID")
            .HasColumnType("smallint")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(50)")
            .HasMaxLength(50);

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="AdventureWorks.Repository.Data.Entities.ScrapReason" /></summary>
        public const string Schema = "Production";
        /// <summary>Table Name constant for entity <see cref="AdventureWorks.Repository.Data.Entities.ScrapReason" /></summary>
        public const string Name = "ScrapReason";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="AdventureWorks.Repository.Data.Entities.ScrapReason.Id" /></summary>
        public const string Id = "ScrapReasonID";
        /// <summary>Column Name constant for property <see cref="AdventureWorks.Repository.Data.Entities.ScrapReason.Name" /></summary>
        public const string Name = "Name";
        /// <summary>Column Name constant for property <see cref="AdventureWorks.Repository.Data.Entities.ScrapReason.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
