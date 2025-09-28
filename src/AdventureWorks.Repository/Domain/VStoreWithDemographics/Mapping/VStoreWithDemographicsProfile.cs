using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VStoreWithDemographics"/> .
/// </summary>
public partial class VStoreWithDemographicsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VStoreWithDemographicsProfile"/> class.
    /// </summary>
    public VStoreWithDemographicsProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VStoreWithDemographics, AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsCreateModel, AdventureWorks.Repository.Data.Entities.VStoreWithDemographics>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VStoreWithDemographics, AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VStoreWithDemographics, AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsUpdateModel, AdventureWorks.Repository.Data.Entities.VStoreWithDemographics>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsReadModel, AdventureWorks.Repository.Domain.Models.VStoreWithDemographicsUpdateModel>();

    }

}
