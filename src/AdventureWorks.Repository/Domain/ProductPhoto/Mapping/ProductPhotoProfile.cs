using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductPhoto"/> .
/// </summary>
public partial class ProductPhotoProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductPhotoProfile"/> class.
    /// </summary>
    public ProductPhotoProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductPhoto, AdventureWorks.Repository.Domain.Models.ProductPhotoReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductPhotoCreateModel, AdventureWorks.Repository.Data.Entities.ProductPhoto>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductPhoto, AdventureWorks.Repository.Domain.Models.ProductPhotoCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductPhoto, AdventureWorks.Repository.Domain.Models.ProductPhotoUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductPhotoUpdateModel, AdventureWorks.Repository.Data.Entities.ProductPhoto>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductPhotoReadModel, AdventureWorks.Repository.Domain.Models.ProductPhotoUpdateModel>();

    }

}
