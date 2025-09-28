using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VEmployee"/> .
/// </summary>
public partial class VEmployeeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VEmployeeProfile"/> class.
    /// </summary>
    public VEmployeeProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployee, AdventureWorks.Repository.Domain.Models.VEmployeeReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VEmployeeCreateModel, AdventureWorks.Repository.Data.Entities.VEmployee>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployee, AdventureWorks.Repository.Domain.Models.VEmployeeCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VEmployee, AdventureWorks.Repository.Domain.Models.VEmployeeUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VEmployeeUpdateModel, AdventureWorks.Repository.Data.Entities.VEmployee>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VEmployeeReadModel, AdventureWorks.Repository.Domain.Models.VEmployeeUpdateModel>();

    }

}
