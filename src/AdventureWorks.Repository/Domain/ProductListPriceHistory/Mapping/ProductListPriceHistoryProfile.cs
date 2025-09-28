using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductListPriceHistory"/> .
/// </summary>
public partial class ProductListPriceHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductListPriceHistoryProfile"/> class.
    /// </summary>
    public ProductListPriceHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductListPriceHistory, AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryCreateModel, AdventureWorks.Repository.Data.Entities.ProductListPriceHistory>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductListPriceHistory, AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductListPriceHistory, AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryUpdateModel, AdventureWorks.Repository.Data.Entities.ProductListPriceHistory>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryReadModel, AdventureWorks.Repository.Domain.Models.ProductListPriceHistoryUpdateModel>();

    }

}
