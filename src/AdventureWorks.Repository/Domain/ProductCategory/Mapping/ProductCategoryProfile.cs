using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductCategory"/> .
/// </summary>
public partial class ProductCategoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCategoryProfile"/> class.
    /// </summary>
    public ProductCategoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductCategory, AdventureWorks.Repository.Domain.Models.ProductCategoryReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductCategoryCreateModel, AdventureWorks.Repository.Data.Entities.ProductCategory>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductCategory, AdventureWorks.Repository.Domain.Models.ProductCategoryCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductCategory, AdventureWorks.Repository.Domain.Models.ProductCategoryUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductCategoryUpdateModel, AdventureWorks.Repository.Data.Entities.ProductCategory>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductCategoryReadModel, AdventureWorks.Repository.Domain.Models.ProductCategoryUpdateModel>();

    }

}
