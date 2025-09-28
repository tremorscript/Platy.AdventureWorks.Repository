using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VVendorWithAddresses"/> .
/// </summary>
public partial class VVendorWithAddressesProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VVendorWithAddressesProfile"/> class.
    /// </summary>
    public VVendorWithAddressesProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VVendorWithAddresses, AdventureWorks.Repository.Domain.Models.VVendorWithAddressesReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VVendorWithAddressesCreateModel, AdventureWorks.Repository.Data.Entities.VVendorWithAddresses>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VVendorWithAddresses, AdventureWorks.Repository.Domain.Models.VVendorWithAddressesCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VVendorWithAddresses, AdventureWorks.Repository.Domain.Models.VVendorWithAddressesUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VVendorWithAddressesUpdateModel, AdventureWorks.Repository.Data.Entities.VVendorWithAddresses>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VVendorWithAddressesReadModel, AdventureWorks.Repository.Domain.Models.VVendorWithAddressesUpdateModel>();

    }

}
