using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="EmployeeDepartmentHistory"/> .
/// </summary>
public partial class EmployeeDepartmentHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeDepartmentHistoryProfile"/> class.
    /// </summary>
    public EmployeeDepartmentHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory, AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryCreateModel, AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory>();

        CreateMap<AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory, AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory, AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryUpdateModel, AdventureWorks.Repository.Data.Entities.EmployeeDepartmentHistory>();

        CreateMap<AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryReadModel, AdventureWorks.Repository.Domain.Models.EmployeeDepartmentHistoryUpdateModel>();

    }

}
