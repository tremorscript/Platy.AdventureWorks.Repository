using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Department"/> .
/// </summary>
public partial class DepartmentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DepartmentProfile"/> class.
    /// </summary>
    public DepartmentProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Department, AdventureWorks.Repository.Domain.Models.DepartmentReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.DepartmentCreateModel, AdventureWorks.Repository.Data.Entities.Department>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Department, AdventureWorks.Repository.Domain.Models.DepartmentCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Department, AdventureWorks.Repository.Domain.Models.DepartmentUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.DepartmentUpdateModel, AdventureWorks.Repository.Data.Entities.Department>();

        CreateMap<AdventureWorks.Repository.Domain.Models.DepartmentReadModel, AdventureWorks.Repository.Domain.Models.DepartmentUpdateModel>();

    }

}
