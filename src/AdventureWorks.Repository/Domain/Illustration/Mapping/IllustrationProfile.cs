using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Illustration"/> .
/// </summary>
public partial class IllustrationProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IllustrationProfile"/> class.
    /// </summary>
    public IllustrationProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Illustration, AdventureWorks.Repository.Domain.Models.IllustrationReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.IllustrationCreateModel, AdventureWorks.Repository.Data.Entities.Illustration>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Illustration, AdventureWorks.Repository.Domain.Models.IllustrationCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Illustration, AdventureWorks.Repository.Domain.Models.IllustrationUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.IllustrationUpdateModel, AdventureWorks.Repository.Data.Entities.Illustration>();

        CreateMap<AdventureWorks.Repository.Domain.Models.IllustrationReadModel, AdventureWorks.Repository.Domain.Models.IllustrationUpdateModel>();

    }

}
