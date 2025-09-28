using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductModel"/> .
/// </summary>
public partial class ProductModelProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelProfile"/> class.
    /// </summary>
    public ProductModelProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductModel, AdventureWorks.Repository.Domain.Models.ProductModelReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductModelCreateModel, AdventureWorks.Repository.Data.Entities.ProductModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductModel, AdventureWorks.Repository.Domain.Models.ProductModelCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductModel, AdventureWorks.Repository.Domain.Models.ProductModelUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductModelUpdateModel, AdventureWorks.Repository.Data.Entities.ProductModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductModelReadModel, AdventureWorks.Repository.Domain.Models.ProductModelUpdateModel>();

    }

}
