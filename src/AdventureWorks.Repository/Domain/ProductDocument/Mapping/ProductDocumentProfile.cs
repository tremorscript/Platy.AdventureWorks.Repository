using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductDocument"/> .
/// </summary>
public partial class ProductDocumentProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductDocumentProfile"/> class.
    /// </summary>
    public ProductDocumentProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductDocument, AdventureWorks.Repository.Domain.Models.ProductDocumentReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductDocumentCreateModel, AdventureWorks.Repository.Data.Entities.ProductDocument>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductDocument, AdventureWorks.Repository.Domain.Models.ProductDocumentCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductDocument, AdventureWorks.Repository.Domain.Models.ProductDocumentUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductDocumentUpdateModel, AdventureWorks.Repository.Data.Entities.ProductDocument>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductDocumentReadModel, AdventureWorks.Repository.Domain.Models.ProductDocumentUpdateModel>();

    }

}
