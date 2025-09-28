using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductCostHistory"/> .
/// </summary>
public partial class ProductCostHistoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductCostHistoryProfile"/> class.
    /// </summary>
    public ProductCostHistoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductCostHistory, AdventureWorks.Repository.Domain.Models.ProductCostHistoryReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductCostHistoryCreateModel, AdventureWorks.Repository.Data.Entities.ProductCostHistory>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductCostHistory, AdventureWorks.Repository.Domain.Models.ProductCostHistoryCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductCostHistory, AdventureWorks.Repository.Domain.Models.ProductCostHistoryUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductCostHistoryUpdateModel, AdventureWorks.Repository.Data.Entities.ProductCostHistory>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductCostHistoryReadModel, AdventureWorks.Repository.Domain.Models.ProductCostHistoryUpdateModel>();

    }

}
