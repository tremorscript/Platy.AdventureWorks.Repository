using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="ProductInventory"/> .
/// </summary>
public partial class ProductInventoryProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductInventoryProfile"/> class.
    /// </summary>
    public ProductInventoryProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.ProductInventory, AdventureWorks.Repository.Domain.Models.ProductInventoryReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductInventoryCreateModel, AdventureWorks.Repository.Data.Entities.ProductInventory>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductInventory, AdventureWorks.Repository.Domain.Models.ProductInventoryCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.ProductInventory, AdventureWorks.Repository.Domain.Models.ProductInventoryUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductInventoryUpdateModel, AdventureWorks.Repository.Data.Entities.ProductInventory>();

        CreateMap<AdventureWorks.Repository.Domain.Models.ProductInventoryReadModel, AdventureWorks.Repository.Domain.Models.ProductInventoryUpdateModel>();

    }

}
