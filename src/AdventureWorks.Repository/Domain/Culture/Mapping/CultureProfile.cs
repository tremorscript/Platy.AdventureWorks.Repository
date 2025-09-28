using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Culture"/> .
/// </summary>
public partial class CultureProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CultureProfile"/> class.
    /// </summary>
    public CultureProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Culture, AdventureWorks.Repository.Domain.Models.CultureReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CultureCreateModel, AdventureWorks.Repository.Data.Entities.Culture>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Culture, AdventureWorks.Repository.Domain.Models.CultureCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Culture, AdventureWorks.Repository.Domain.Models.CultureUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CultureUpdateModel, AdventureWorks.Repository.Data.Entities.Culture>();

        CreateMap<AdventureWorks.Repository.Domain.Models.CultureReadModel, AdventureWorks.Repository.Domain.Models.CultureUpdateModel>();

    }

}
