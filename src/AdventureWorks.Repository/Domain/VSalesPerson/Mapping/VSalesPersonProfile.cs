using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VSalesPerson"/> .
/// </summary>
public partial class VSalesPersonProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VSalesPersonProfile"/> class.
    /// </summary>
    public VSalesPersonProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VSalesPerson, AdventureWorks.Repository.Domain.Models.VSalesPersonReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VSalesPersonCreateModel, AdventureWorks.Repository.Data.Entities.VSalesPerson>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VSalesPerson, AdventureWorks.Repository.Domain.Models.VSalesPersonCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VSalesPerson, AdventureWorks.Repository.Domain.Models.VSalesPersonUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VSalesPersonUpdateModel, AdventureWorks.Repository.Data.Entities.VSalesPerson>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VSalesPersonReadModel, AdventureWorks.Repository.Domain.Models.VSalesPersonUpdateModel>();

    }

}
