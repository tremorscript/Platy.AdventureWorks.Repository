using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="BusinessEntityAddress"/> .
/// </summary>
public partial class BusinessEntityAddressProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityAddressProfile"/> class.
    /// </summary>
    public BusinessEntityAddressProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.BusinessEntityAddress, AdventureWorks.Repository.Domain.Models.BusinessEntityAddressReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.BusinessEntityAddressCreateModel, AdventureWorks.Repository.Data.Entities.BusinessEntityAddress>();

        CreateMap<AdventureWorks.Repository.Data.Entities.BusinessEntityAddress, AdventureWorks.Repository.Domain.Models.BusinessEntityAddressCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.BusinessEntityAddress, AdventureWorks.Repository.Domain.Models.BusinessEntityAddressUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.BusinessEntityAddressUpdateModel, AdventureWorks.Repository.Data.Entities.BusinessEntityAddress>();

        CreateMap<AdventureWorks.Repository.Domain.Models.BusinessEntityAddressReadModel, AdventureWorks.Repository.Domain.Models.BusinessEntityAddressUpdateModel>();

    }

}
