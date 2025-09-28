using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Location"/> .
/// </summary>
public partial class LocationProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LocationProfile"/> class.
    /// </summary>
    public LocationProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Location, AdventureWorks.Repository.Domain.Models.LocationReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.LocationCreateModel, AdventureWorks.Repository.Data.Entities.Location>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Location, AdventureWorks.Repository.Domain.Models.LocationCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Location, AdventureWorks.Repository.Domain.Models.LocationUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.LocationUpdateModel, AdventureWorks.Repository.Data.Entities.Location>();

        CreateMap<AdventureWorks.Repository.Domain.Models.LocationReadModel, AdventureWorks.Repository.Domain.Models.LocationUpdateModel>();

    }

}
