using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Person"/> .
/// </summary>
public partial class PersonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PersonProfile"/> class.
    /// </summary>
    public PersonProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Person, AdventureWorks.Repository.Domain.Models.PersonReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PersonCreateModel, AdventureWorks.Repository.Data.Entities.Person>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Person, AdventureWorks.Repository.Domain.Models.PersonCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Person, AdventureWorks.Repository.Domain.Models.PersonUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PersonUpdateModel, AdventureWorks.Repository.Data.Entities.Person>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PersonReadModel, AdventureWorks.Repository.Domain.Models.PersonUpdateModel>();

    }

}
