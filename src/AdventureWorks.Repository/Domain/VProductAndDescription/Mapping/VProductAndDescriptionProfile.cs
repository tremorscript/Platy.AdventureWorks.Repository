using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VProductAndDescription"/> .
/// </summary>
public partial class VProductAndDescriptionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductAndDescriptionProfile"/> class.
    /// </summary>
    public VProductAndDescriptionProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VProductAndDescription, AdventureWorks.Repository.Domain.Models.VProductAndDescriptionReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VProductAndDescriptionCreateModel, AdventureWorks.Repository.Data.Entities.VProductAndDescription>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VProductAndDescription, AdventureWorks.Repository.Domain.Models.VProductAndDescriptionCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VProductAndDescription, AdventureWorks.Repository.Domain.Models.VProductAndDescriptionUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VProductAndDescriptionUpdateModel, AdventureWorks.Repository.Data.Entities.VProductAndDescription>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VProductAndDescriptionReadModel, AdventureWorks.Repository.Domain.Models.VProductAndDescriptionUpdateModel>();

    }

}
