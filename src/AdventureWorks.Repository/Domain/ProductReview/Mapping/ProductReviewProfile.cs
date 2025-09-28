using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductReview"/> .
/// </summary>
public partial class ProductReviewProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductReviewProfile"/> class.
    /// </summary>
    public ProductReviewProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductReview, AdventureWorks.Repository.Domain.Models.ProductReviewReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductReviewCreateModel, AdventureWorks.Repository.Data.Entities.ProductReview>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductReview, AdventureWorks.Repository.Domain.Models.ProductReviewCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductReview, AdventureWorks.Repository.Domain.Models.ProductReviewUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductReviewUpdateModel, AdventureWorks.Repository.Data.Entities.ProductReview>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductReviewReadModel, AdventureWorks.Repository.Domain.Models.ProductReviewUpdateModel>();

    }

}
