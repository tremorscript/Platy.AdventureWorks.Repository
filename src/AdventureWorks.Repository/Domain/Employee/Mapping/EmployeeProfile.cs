using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Employee"/> .
/// </summary>
public partial class EmployeeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeProfile"/> class.
    /// </summary>
    public EmployeeProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Employee, AdventureWorks.Repository.Domain.Models.EmployeeReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.EmployeeCreateModel, AdventureWorks.Repository.Data.Entities.Employee>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Employee, AdventureWorks.Repository.Domain.Models.EmployeeCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Employee, AdventureWorks.Repository.Domain.Models.EmployeeUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.EmployeeUpdateModel, AdventureWorks.Repository.Data.Entities.Employee>();

        CreateMap<AdventureWorks.Repository.Domain.Models.EmployeeReadModel, AdventureWorks.Repository.Domain.Models.EmployeeUpdateModel>();

    }

}
