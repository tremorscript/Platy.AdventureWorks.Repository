using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductModelIllustration"/> .
/// </summary>
public partial class ProductModelIllustrationProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductModelIllustrationProfile"/> class.
    /// </summary>
    public ProductModelIllustrationProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductModelIllustration, AdventureWorks.Repository.Domain.Models.ProductModelIllustrationReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductModelIllustrationCreateModel, AdventureWorks.Repository.Data.Entities.ProductModelIllustration>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductModelIllustration, AdventureWorks.Repository.Domain.Models.ProductModelIllustrationCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductModelIllustration, AdventureWorks.Repository.Domain.Models.ProductModelIllustrationUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductModelIllustrationUpdateModel, AdventureWorks.Repository.Data.Entities.ProductModelIllustration>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductModelIllustrationReadModel, AdventureWorks.Repository.Domain.Models.ProductModelIllustrationUpdateModel>();

    }

}
