using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Vendor"/> .
/// </summary>
public partial class VendorProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VendorProfile"/> class.
    /// </summary>
    public VendorProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Vendor, AdventureWorks.Repository.Domain.Models.VendorReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VendorCreateModel, AdventureWorks.Repository.Data.Entities.Vendor>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Vendor, AdventureWorks.Repository.Domain.Models.VendorCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Vendor, AdventureWorks.Repository.Domain.Models.VendorUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VendorUpdateModel, AdventureWorks.Repository.Data.Entities.Vendor>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VendorReadModel, AdventureWorks.Repository.Domain.Models.VendorUpdateModel>();

    }

}
