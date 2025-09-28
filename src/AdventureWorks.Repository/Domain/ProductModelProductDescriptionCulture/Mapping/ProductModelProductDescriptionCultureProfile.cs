using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductModelProductDescriptionCulture"/> .
/// </summary>
public partial class ProductModelProductDescriptionCultureProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelProductDescriptionCultureProfile"/> class.
    /// </summary>
    public ProductModelProductDescriptionCultureProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture, AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureCreateModel, AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture, AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture, AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureUpdateModel, AdventureWorks.Repository.Data.Entities.ProductModelProductDescriptionCulture>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureReadModel, AdventureWorks.Repository.Domain.Models.ProductModelProductDescriptionCultureUpdateModel>();

    }

}
