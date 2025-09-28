using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VStoreWithContacts"/> .
/// </summary>
public partial class VStoreWithContactsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithContactsProfile"/> class.
    /// </summary>
    public VStoreWithContactsProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VStoreWithContacts, AdventureWorks.Repository.Domain.Models.VStoreWithContactsReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VStoreWithContactsCreateModel, AdventureWorks.Repository.Data.Entities.VStoreWithContacts>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VStoreWithContacts, AdventureWorks.Repository.Domain.Models.VStoreWithContactsCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VStoreWithContacts, AdventureWorks.Repository.Domain.Models.VStoreWithContactsUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VStoreWithContactsUpdateModel, AdventureWorks.Repository.Data.Entities.VStoreWithContacts>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VStoreWithContactsReadModel, AdventureWorks.Repository.Domain.Models.VStoreWithContactsUpdateModel>();

    }

}
