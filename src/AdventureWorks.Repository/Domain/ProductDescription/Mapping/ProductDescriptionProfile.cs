using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductDescription"/> .
/// </summary>
public partial class ProductDescriptionProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductDescriptionProfile"/> class.
    /// </summary>
    public ProductDescriptionProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductDescription, AdventureWorks.Repository.Domain.Models.ProductDescriptionReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductDescriptionCreateModel, AdventureWorks.Repository.Data.Entities.ProductDescription>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductDescription, AdventureWorks.Repository.Domain.Models.ProductDescriptionCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductDescription, AdventureWorks.Repository.Domain.Models.ProductDescriptionUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductDescriptionUpdateModel, AdventureWorks.Repository.Data.Entities.ProductDescription>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductDescriptionReadModel, AdventureWorks.Repository.Domain.Models.ProductDescriptionUpdateModel>();

    }

}
