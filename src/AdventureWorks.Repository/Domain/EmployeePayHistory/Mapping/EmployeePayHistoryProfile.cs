using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="EmployeePayHistory"/> .
/// </summary>
public partial class EmployeePayHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeePayHistoryProfile"/> class.
    /// </summary>
    public EmployeePayHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.EmployeePayHistory, AdventureWorks.Repository.Domain.Models.EmployeePayHistoryReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.EmployeePayHistoryCreateModel, AdventureWorks.Repository.Data.Entities.EmployeePayHistory>();

        CreateMap<AdventureWorks.Repository.Data.Entities.EmployeePayHistory, AdventureWorks.Repository.Domain.Models.EmployeePayHistoryCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.EmployeePayHistory, AdventureWorks.Repository.Domain.Models.EmployeePayHistoryUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.EmployeePayHistoryUpdateModel, AdventureWorks.Repository.Data.Entities.EmployeePayHistory>();

        CreateMap<AdventureWorks.Repository.Domain.Models.EmployeePayHistoryReadModel, AdventureWorks.Repository.Domain.Models.EmployeePayHistoryUpdateModel>();

    }

}
