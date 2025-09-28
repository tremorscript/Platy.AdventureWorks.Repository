using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="VProductModelCatalogDescription"/> .
/// </summary>
public partial class VProductModelCatalogDescriptionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VProductModelCatalogDescriptionProfile"/> class.
    /// </summary>
    public VProductModelCatalogDescriptionProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription, AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionCreateModel, AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription, AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription, AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionUpdateModel, AdventureWorks.Repository.Data.Entities.VProductModelCatalogDescription>();

        CreateMap<AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionReadModel, AdventureWorks.Repository.Domain.Models.VProductModelCatalogDescriptionUpdateModel>();

    }

}
