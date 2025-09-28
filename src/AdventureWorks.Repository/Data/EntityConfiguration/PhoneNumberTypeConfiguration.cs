using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="AdventureWorks.Repository.Data.Entities.PhoneNumberType" />
/// </summary>
internal partial class PhoneNumberTypeConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.PhoneNumberType>
{
    /// <summary>
    /// Configures the entity of type <see cref="AdventureWorks.Repository.Data.Entities.PhoneNumberType" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.PhoneNumberType> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("PhoneNumberType", "Person");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("PhoneNumberTypeID")
            .HasColumnType("int")
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
        /// <summary>Table Schema name constant for entity <see cref="AdventureWorks.Repository.Data.Entities.PhoneNumberType" /></summary>
        public const string Schema = "Person";
        /// <summary>Table Name constant for entity <see cref="AdventureWorks.Repository.Data.Entities.PhoneNumberType" /></summary>
        public const string Name = "PhoneNumberType";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="AdventureWorks.Repository.Data.Entities.PhoneNumberType.Id" /></summary>
        public const string Id = "PhoneNumberTypeID";
        /// <summary>Column Name constant for property <see cref="AdventureWorks.Repository.Data.Entities.PhoneNumberType.Name" /></summary>
        public const string Name = "Name";
        /// <summary>Column Name constant for property <see cref="AdventureWorks.Repository.Data.Entities.PhoneNumberType.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
