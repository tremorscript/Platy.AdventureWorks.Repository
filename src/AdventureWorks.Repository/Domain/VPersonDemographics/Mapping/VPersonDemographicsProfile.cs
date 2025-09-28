using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VPersonDemographics"/> .
/// </summary>
public partial class VPersonDemographicsProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VPersonDemographicsProfile"/> class.
    /// </summary>
    public VPersonDemographicsProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VPersonDemographics, AdventureWorks.Repository.Domain.Models.VPersonDemographicsReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VPersonDemographicsCreateModel, AdventureWorks.Repository.Data.Entities.VPersonDemographics>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VPersonDemographics, AdventureWorks.Repository.Domain.Models.VPersonDemographicsCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VPersonDemographics, AdventureWorks.Repository.Domain.Models.VPersonDemographicsUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VPersonDemographicsUpdateModel, AdventureWorks.Repository.Data.Entities.VPersonDemographics>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VPersonDemographicsReadModel, AdventureWorks.Repository.Domain.Models.VPersonDemographicsUpdateModel>();

    }

}
