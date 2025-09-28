using System;

using AutoMapper;

using AdventureWorks.Repository.Data.Entities;
using AdventureWorks.Repository.Domain.Models;

namespace AdventureWorks.Repository.Domain.Mapping;

/// <summary>
/// Mapper class for entity <see cref="PurchaseOrderDetail"/> .
/// </summary>
public partial class PurchaseOrderDetailProfile
    : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PurchaseOrderDetailProfile"/> class.
    /// </summary>
    public PurchaseOrderDetailProfile()
    {
        CreateMap<AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail, AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailReadModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailCreateModel, AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail>();

        CreateMap<AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail, AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailCreateModel>();

        CreateMap<AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail, AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailUpdateModel>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailUpdateModel, AdventureWorks.Repository.Data.Entities.PurchaseOrderDetail>();

        CreateMap<AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailReadModel, AdventureWorks.Repository.Domain.Models.PurchaseOrderDetailUpdateModel>();

    }

}
