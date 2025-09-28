using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VEmployeeDepartment"/> .
/// </summary>
public partial class VEmployeeDepartmentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VEmployeeDepartmentProfile"/> class.
    /// </summary>
    public VEmployeeDepartmentProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployeeDepartment, AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentCreateModel, AdventureWorks.Repository.Data.Entities.VEmployeeDepartment>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployeeDepartment, AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployeeDepartment, AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentUpdateModel, AdventureWorks.Repository.Data.Entities.VEmployeeDepartment>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentReadModel, AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentUpdateModel>();

    }

}
