using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="Store"/> .
/// </summary>
public partial class StoreProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StoreProfile"/> class.
    /// </summary>
    public StoreProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.Store, AdventureWorks.Repository.Domain.Models.StoreReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.StoreCreateModel, AdventureWorks.Repository.Data.Entities.Store>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Store, AdventureWorks.Repository.Domain.Models.StoreCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.Store, AdventureWorks.Repository.Domain.Models.StoreUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.StoreUpdateModel, AdventureWorks.Repository.Data.Entities.Store>();

        CreateMap<AdventureWorks.Repository.Domain.Models.StoreReadModel, AdventureWorks.Repository.Domain.Models.StoreUpdateModel>();

    }

}
