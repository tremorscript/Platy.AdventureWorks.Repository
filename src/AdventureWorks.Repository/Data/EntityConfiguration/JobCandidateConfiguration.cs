using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace AdventureWorks.Repository.Data.EntityConfiguration;

/// <summary>
/// Allows configuration for an entity type <see cref="AdventureWorks.Repository.Data.Entities.JobCandidate" />
/// </summary>
internal partial class JobCandidateConfiguration
    : IEntityTypeConfiguration<AdventureWorks.Repository.Data.Entities.JobCandidate>
{
    /// <summary>
    /// Configures the entity of type <see cref="AdventureWorks.Repository.Data.Entities.JobCandidate" />
    /// </summary>
    /// <param name="builder">The builder to be used to configure the entity type.</param>
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AdventureWorks.Repository.Data.Entities.JobCandidate> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("JobCandidate", "HumanResources");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("JobCandidateID")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.BusinessEntityId)
            .HasColumnName("BusinessEntityID")
            .HasColumnType("int");

        builder.Property(t => t.Resume)
            .HasColumnName("Resume")
            .HasColumnType("xml");

        builder.Property(t => t.ModifiedDate)
            .IsRequired()
            .HasColumnName("ModifiedDate")
            .HasColumnType("datetime")
            .HasDefaultValueSql("(getdate())");

        // relationships
        builder.HasOne(t => t.Employee)
            .WithMany(t => t.JobCandidates)
            .HasForeignKey(d => d.BusinessEntityId)
            .HasConstraintName("FK_JobCandidate_Employee_BusinessEntityID");

        #endregion
    }

    #region Generated Constants
    internal readonly struct Table
    {
        /// <summary>Table Schema name constant for entity <see cref="AdventureWorks.Repository.Data.Entities.JobCandidate" /></summary>
        public const string Schema = "HumanResources";
        /// <summary>Table Name constant for entity <see cref="AdventureWorks.Repository.Data.Entities.JobCandidate" /></summary>
        public const string Name = "JobCandidate";
    }

    internal readonly struct Columns
    {
        /// <summary>Column Name constant for property <see cref="AdventureWorks.Repository.Data.Entities.JobCandidate.Id" /></summary>
        public const string Id = "JobCandidateID";
        /// <summary>Column Name constant for property <see cref="AdventureWorks.Repository.Data.Entities.JobCandidate.BusinessEntityId" /></summary>
        public const string BusinessEntityId = "BusinessEntityID";
        /// <summary>Column Name constant for property <see cref="AdventureWorks.Repository.Data.Entities.JobCandidate.Resume" /></summary>
        public const string Resume = "Resume";
        /// <summary>Column Name constant for property <see cref="AdventureWorks.Repository.Data.Entities.JobCandidate.ModifiedDate" /></summary>
        public const string ModifiedDate = "ModifiedDate";
    }
    #endregion
}
