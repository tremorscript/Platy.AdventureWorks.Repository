using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VStoreWithAddresses"/> .
/// </summary>
public partial class VStoreWithAddressesProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithAddressesProfile"/> class.
    /// </summary>
    public VStoreWithAddressesProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VStoreWithAddresses, AdventureWorks.Repository.Domain.Models.VStoreWithAddressesReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VStoreWithAddressesCreateModel, AdventureWorks.Repository.Data.Entities.VStoreWithAddresses>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VStoreWithAddresses, AdventureWorks.Repository.Domain.Models.VStoreWithAddressesCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VStoreWithAddresses, AdventureWorks.Repository.Domain.Models.VStoreWithAddressesUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VStoreWithAddressesUpdateModel, AdventureWorks.Repository.Data.Entities.VStoreWithAddresses>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VStoreWithAddressesReadModel, AdventureWorks.Repository.Domain.Models.VStoreWithAddressesUpdateModel>();

    }

}
