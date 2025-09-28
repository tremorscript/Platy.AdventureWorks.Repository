using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ContactType"/> .
/// </summary>
public partial class ContactTypeProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactTypeProfile"/> class.
    /// </summary>
    public ContactTypeProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ContactType, AdventureWorks.Repository.Domain.Models.ContactTypeReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ContactTypeCreateModel, AdventureWorks.Repository.Data.Entities.ContactType>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ContactType, AdventureWorks.Repository.Domain.Models.ContactTypeCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ContactType, AdventureWorks.Repository.Domain.Models.ContactTypeUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ContactTypeUpdateModel, AdventureWorks.Repository.Data.Entities.ContactType>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ContactTypeReadModel, AdventureWorks.Repository.Domain.Models.ContactTypeUpdateModel>();

    }

}
