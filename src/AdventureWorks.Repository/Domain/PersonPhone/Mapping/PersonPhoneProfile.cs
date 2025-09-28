using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PersonPhone"/> .
/// </summary>
public partial class PersonPhoneProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonPhoneProfile"/> class.
    /// </summary>
    public PersonPhoneProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.PersonPhone, AdventureWorks.Repository.Domain.Models.PersonPhoneReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PersonPhoneCreateModel, AdventureWorks.Repository.Data.Entities.PersonPhone>();

        CreateMap<AdventureWorks.Repository.Data.Entities.PersonPhone, AdventureWorks.Repository.Domain.Models.PersonPhoneCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.PersonPhone, AdventureWorks.Repository.Domain.Models.PersonPhoneUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PersonPhoneUpdateModel, AdventureWorks.Repository.Data.Entities.PersonPhone>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PersonPhoneReadModel, AdventureWorks.Repository.Domain.Models.PersonPhoneUpdateModel>();

    }

}
