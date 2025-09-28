using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="StateProvince"/> .
/// </summary>
public partial class StateProvinceProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StateProvinceProfile"/> class.
    /// </summary>
    public StateProvinceProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.StateProvince, AdventureWorks.Repository.Domain.Models.StateProvinceReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.StateProvinceCreateModel, AdventureWorks.Repository.Data.Entities.StateProvince>();

        CreateMap<AdventureWorks.Repository.Data.Entities.StateProvince, AdventureWorks.Repository.Domain.Models.StateProvinceCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.StateProvince, AdventureWorks.Repository.Domain.Models.StateProvinceUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.StateProvinceUpdateModel, AdventureWorks.Repository.Data.Entities.StateProvince>();

        CreateMap<AdventureWorks.Repository.Domain.Models.StateProvinceReadModel, AdventureWorks.Repository.Domain.Models.StateProvinceUpdateModel>();

    }

}
