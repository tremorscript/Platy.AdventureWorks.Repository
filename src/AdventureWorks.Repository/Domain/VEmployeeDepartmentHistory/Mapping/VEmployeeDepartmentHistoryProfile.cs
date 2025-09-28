using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VEmployeeDepartmentHistory"/> .
/// </summary>
public partial class VEmployeeDepartmentHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VEmployeeDepartmentHistoryProfile"/> class.
    /// </summary>
    public VEmployeeDepartmentHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory, AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryCreateModel, AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory, AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory, AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryUpdateModel, AdventureWorks.Repository.Data.Entities.VEmployeeDepartmentHistory>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryReadModel, AdventureWorks.Repository.Domain.Models.VEmployeeDepartmentHistoryUpdateModel>();

    }

}
