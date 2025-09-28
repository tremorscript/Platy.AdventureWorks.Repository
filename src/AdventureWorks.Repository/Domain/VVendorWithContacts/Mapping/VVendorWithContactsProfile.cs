using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VVendorWithContacts"/> .
/// </summary>
public partial class VVendorWithContactsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VVendorWithContactsProfile"/> class.
    /// </summary>
    public VVendorWithContactsProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VVendorWithContacts, AdventureWorks.Repository.Domain.Models.VVendorWithContactsReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VVendorWithContactsCreateModel, AdventureWorks.Repository.Data.Entities.VVendorWithContacts>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VVendorWithContacts, AdventureWorks.Repository.Domain.Models.VVendorWithContactsCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VVendorWithContacts, AdventureWorks.Repository.Domain.Models.VVendorWithContactsUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VVendorWithContactsUpdateModel, AdventureWorks.Repository.Data.Entities.VVendorWithContacts>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VVendorWithContactsReadModel, AdventureWorks.Repository.Domain.Models.VVendorWithContactsUpdateModel>();

    }

}
